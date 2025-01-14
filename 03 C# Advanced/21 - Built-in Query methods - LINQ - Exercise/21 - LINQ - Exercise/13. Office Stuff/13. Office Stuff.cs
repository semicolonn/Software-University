﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Office_Stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var ordersCount = int.Parse(Console.ReadLine());

            var ordersList = new List<Order>();

            for (int i = 0; i < ordersCount; i++)
            {
                var order = Console.ReadLine()
                    .Trim('|')
                    .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim(' '))
                    .ToArray();

                ordersList.Add(new Order(order[0], order[2], int.Parse(order[1])));
            }

            var groupedCompanies = ordersList
                .GroupBy(or => or.CompanyName)               
                .OrderBy(x => x.Key); // x.Key --> CompanyName

            foreach (var company in groupedCompanies)
            {
                var products = company
                    .GroupBy(pr => pr.ProductName)
                    .Select(gr => new
                    {
                        ProdName = gr.Key,
                        Amount = gr.Sum(x => x.Amount)
                    });

                Console.WriteLine(company.Key + ": " + string.Join(", ", products.Select(x => $"{x.ProdName}-{x.Amount}")));
            }
        }
    }
    public class Order
    {
        public string CompanyName;
        public string ProductName;
        public int Amount;

        public Order(string companyName, string productName, int amount)
        {
            CompanyName = companyName;
            ProductName = productName;
            Amount = amount;
        }
    }
}
