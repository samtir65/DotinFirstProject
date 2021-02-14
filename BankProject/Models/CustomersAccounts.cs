using System;
using System.Collections.Generic;

namespace BankProject.Models
{
    public class CustomersAccounts
    {
        #region Constructor
        public CustomersAccounts()
        {
            Customers = new HashSet<Customers>();
            Accounts = new HashSet<Accounts>();
        }
        #endregion

        #region Properties
        public int AccountNumber { get; set; }
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public float Amount { get; set; }
        public DateTime AccountOpeningDate { get; set; }
        #endregion

        #region Relationships
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Accounts> Accounts { get; set; }
        #endregion


    }
}
