using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class SalaryDetailsDTO
    {
        public int EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }        
        public int SalaryAmount { get; set; }
        public string SalaryMonth { get; set; }
        public int SalaryYear { get; set; }
        public int EmpId { get; set; }
        public int DepId { get; set; }
        public int PosId { get; set; }
        public int SalId { get; set; }
        public int MonthId { get; set; }
        public string EmployeeDepartmentName { get; set; }
        public string EmployeePositionName { get; set; }
        public int OldSalary { get; set; }
    }
}
