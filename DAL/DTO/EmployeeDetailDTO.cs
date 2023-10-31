using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class EmployeeDetailDTO
    {
        public int EmpId { get; set; }
        public int DepId { get; set; }
        public int PosId { get; set; }       
        public int EmployeeNumber{ get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }        
        public string EmployeeImagePath{ get; set; }
        public string EmployeeDepartmentName { get; set; }
        public string EmployeePositionName { get; set; }
        public int EmployeeSalary { get; set; }
        public string EmployeeAddress { get; set; }
        public bool isAdmin { get; set; }
        public DateTime EmployeeBirthday { get; set; }
        public int EmployeeOldSalary { get; set; }
    }
}
