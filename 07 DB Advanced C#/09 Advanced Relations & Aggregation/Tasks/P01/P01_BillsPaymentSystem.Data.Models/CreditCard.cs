﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_BillsPaymentSystem.Data.Models
{
    public class CreditCard
    {
        public int CreditCardId { get; set; }

        public DateTime ExpirationDate { get; set; }

        public decimal Limit { get; set; }

        public decimal MoneyOwed { get; set; }

        public decimal LimitLeft => Limit - MoneyOwed;

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
