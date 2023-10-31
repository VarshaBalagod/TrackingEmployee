using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class SalaryDTO
    {
        public List<tbl_Department> Departments { get; set; }
        public List<PositionDTO> Positions { get; set; }
        public List<EmployeeDetailDTO> Employees { get; set; }
        public List<tbl_Month> Months { get; set; }
        public List<SalaryDetailsDTO> SalaryDetailsDTOs { get; set; }
    }
}
