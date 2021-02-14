namespace BankProject.Models
{
    public class Roles
    {
        #region Properties
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        #endregion

        #region RelationShips
        public virtual Users Users { get; set; }
       
        #endregion
    }
}
