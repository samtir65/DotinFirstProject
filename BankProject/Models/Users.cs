using System.Collections.Generic;

namespace BankProject.Models
{
    public class Users
    {
        #region Constructor
        public Users()
        {
            Branchs = new HashSet<Branchs>();
            Roles = new HashSet<Roles>();
        }
        #endregion

        #region Properties
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int RoleId { get; set; }
        public int BranchCode { get; set; }
        #endregion

        #region RelationShips
        public virtual ICollection<Branchs> Branchs { get; set; }
        public virtual ICollection<Roles> Roles { get; set; }
        #endregion

    }
}
