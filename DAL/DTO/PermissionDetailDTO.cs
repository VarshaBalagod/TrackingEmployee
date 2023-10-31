using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class PermissionDetailDTO
    {
        
        public int EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public DateTime PermissionSartDate { get; set; }
        public DateTime PermissionEndDate { get; set; }      
        public string PStateName { get; set; }
        public string PermissionExplaination { get; set; }
        public int PermissionDay { get; set; }
        public int PStateId { get; set; }
        public int EmpId { get; set; }
        public int DepId { get; set; }
        public int PosId { get; set; }
        public int perId { get; set; }
    }
}
