namespace BankProject.Models
{
    public class Customers
    {
        #region Properties
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public int CustomerType { get; set; }
        public string NationalCode { get; set; }
        public int CompanyNumber { get; set; }
        public int PhoneNumber { get; set; }
        public int MobileNumber { get; set; }
       
        #endregion

        #region RelationShips
        public virtual AccountingDocument AccountingDocument { get; set; }
        public virtual CustomersAccounts CustomersAccounts { get; set; }
        #endregion

    }
}
