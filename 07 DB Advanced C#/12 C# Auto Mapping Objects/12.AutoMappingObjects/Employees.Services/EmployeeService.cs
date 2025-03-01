﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Employees.Data;
using Employees.DtoModels;
using Employees.Models;
using Microsoft.EntityFrameworkCore;

namespace Employees.Services
{
    public class EmployeeService
    {
        private readonly EmployeesContext context;

        public EmployeeService(EmployeesContext context)
        {
            this.context = context;
        }

        public EmployeeDto ById(int id)
        {
            var currentEmployee = context.Employees.Find(id);

            var employeeDto = Mapper.Map<EmployeeDto>(currentEmployee);

            return employeeDto;
        }
        //AddEmployee<firstName> <lastName> <salary> 
        public void AddEmployee(EmployeeDto dto)
        {
            var employee = Mapper.Map<Employee>(dto);

            context.Employees.Add(employee);

            context.SaveChanges();
        }
        //SetBirthday<employeeId> <date: "dd-MM-yyyy"> 
        public string SetBirthday(int employeeId, DateTime birthday)
        {
            var employee = context.Employees.Find(employeeId);

            employee.Birthday = birthday;

            context.SaveChanges();

            return $"{employee.FirstName} {employee.LastName}";
        }
        //SetAddress<employeeId> <address> 
        public string SetAddress(int employeeId, string address)
        {
            var employee = context.Employees.Find(employeeId);

            employee.Address = address;

            context.SaveChanges();

            return $"{employee.FirstName} {employee.LastName}";
        }
        //EmployeePersonalInfo <employeeId> 
        public EmployeePersonalDto PeronalById(int id)
        {
            var currentEmployee = context.Employees.Find(id);

            var employeeDto = Mapper.Map<EmployeePersonalDto>(currentEmployee);

            return employeeDto;
        }
        //SetManager <employeeId> <managerId> 
        public void SetEmployeeToManager(int employeeId, int managerId)
        {
            var employee = GetEmployeeById(employeeId);

            var manager = GetEmployeeById(managerId);

            if (manager.Manager != null && manager.Manager.Id == employee.Id)
            {
                throw new ArgumentException($"Employee with ID {employee.Id} is already manager of {manager.Id}!");
            }

            employee.Manager = manager;

            this.context.SaveChanges();
        }
        //ManagerInfo <employeeId> 
        public string GetManagerInfo(int employeeId)
        {
            var employee = GetEmployeeById(employeeId);

            var managerDto = Mapper.Map<ManagerDto>(employee);

            var sb = new StringBuilder();

            sb.AppendLine($"{managerDto.FirstName} {managerDto.LastName} | Employees: {managerDto.SubordinatesCount}");

            foreach (var subordinate in managerDto.Subordinates)
            {
                sb.AppendLine($"    - {subordinate.FirstName} {subordinate.LastName} - ${subordinate.Salary:F2}");
            }

            return sb.ToString().Trim();
        }
        //ListEmployeesOlderThan <age>" 
        public IList<EmployeeDto> GetEmployeesOlderThan(int age)
        {
            var employees = this.context
                .Employees
                .Include(e => e.Manager)
                .Where(e => e.Birthday != null && this.CalcCurrentAge(e.Birthday.Value) > age)
                .OrderByDescending(e => e.Salary)
                .ProjectTo<EmployeeDto>()
                .ToList();

            return employees;
        }

        private Employee GetEmployeeById(int id)
        {
            var employee = this.context
                .Employees
                .Include(e => e.Subordinates)
                .SingleOrDefault(e => e.Id == id);

            if (employee == null)
            {
                throw new ArgumentException($"Employee with ID {id} not found.");
            }

            return employee;
        }

        public int CalcCurrentAge(DateTime birthday)
        {
            var currentDate = DateTime.Now;

            var age = currentDate.Year - birthday.Year;

            if (birthday > currentDate.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
