﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Customer: EntityBase, ILoggable
    {
        public Customer(): this(0)
        {
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int CustomerType { get; set; }
        public int CustomerId { get; private set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public static int InstanceCount { get; set; }

        public string FullName
        {
            get
            {
                var fullName = LastName;
                if (string.IsNullOrWhiteSpace(FirstName)) return fullName;
                if (!string.IsNullOrWhiteSpace(fullName))
                {
                    fullName += ", ";
                }

                fullName += FirstName;

                return fullName;
            }
        }

        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

        public override string ToString() => FullName;

        /// <summary>
        /// Validates the customer data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = !string.IsNullOrWhiteSpace(LastName);

            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;

        }

        /// <summary>
        /// Retrieve one customer
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            return new Customer();

        }

        /// <summary>
        /// Retrieve all customers
        /// </summary>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();

        }

        /// <summary>
        /// Saves Current Customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;

        }
    }
}
