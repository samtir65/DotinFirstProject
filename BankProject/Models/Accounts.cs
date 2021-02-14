namespace BankProject.Models
{
    public class Accounts
    {
        #region Properties
        public int AccountId { get; set; }
        public string AccountName { get; set; }

        #endregion

        #region Relationships
        public virtual CustomersAccounts CustomersAccounts { get; set; }
        #endregion

    }
}
