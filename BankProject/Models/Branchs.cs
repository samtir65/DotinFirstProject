using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankProject.Models
{
    public class Branchs
    {
        #region Propeties
        public int BranchCode { get; set; }
        public string BranchName { get; set; }
        #endregion

        #region RelationShips
        public virtual Users Users { get; set; }
        public virtual AccountingDocument AccountingDocument { get; set; }
        #endregion
    }
}
