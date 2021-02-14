using System;
using System.Collections.Generic;

namespace BankProject.Models
{
    public class AccountingDocument
    {
        #region Constructor
        public AccountingDocument()
        {
            Customers = new HashSet<Customers>();
            Branchs = new HashSet<Branchs>();
        }
        #endregion

        #region Properties
        public int AccountingId { get; set; }
        public int AccountingDocumentType { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public int BranchCode { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }

        #endregion

        #region RelationShips
        public virtual ICollection<Customers>  Customers{ get; set; }
        public virtual ICollection<Branchs> Branchs { get; set; }
        #endregion
    }

}
