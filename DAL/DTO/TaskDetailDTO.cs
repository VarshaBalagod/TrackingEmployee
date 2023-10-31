using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class TaskDetailDTO
    {       
        public int EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }              
        public string TaskTitle { get; set; }
        public string TaskStateName { get; set; }
        public string TaskContent { get; set; }
        public DateTime TaskStartDate { get; set; }
        public DateTime TaskDeliveryDate { get; set; }
        public int EmpId { get; set; }
        public int DepId { get; set; }
        public int PosId { get; set; }
        public int TaskId { get; set; }
        public int TaskStateId { get; set; }
        public string EmployeeDepartmentName { get; set; }
        public string EmployeePositionName { get; set; }
    }
}
