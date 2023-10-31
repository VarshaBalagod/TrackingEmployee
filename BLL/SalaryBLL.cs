using DAL;
using DAL.DAO;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SalaryBLL
    {
        public static void AddSalaryAmmount(tbl_Salary tableSalary, bool controlSal)
        {
            SalaryDAO.AddSalaryAmmount(tableSalary);
            if (controlSal)
                EmployeeDAO.UpdateEmployee(tableSalary.EmpID, tableSalary.Amount);
        }

        public static void DeleteSalary(int salId)
        {
            SalaryDAO.DeleteSalary(salId);
        }

        public static SalaryDTO GetAllSalary()
        {
            SalaryDTO dtoSalary = new SalaryDTO();
            dtoSalary.Employees = EmployeeDAO.GetEmployees();
            dtoSalary.Departments = DepartmentDAO.GetDepartment();
            dtoSalary.Positions = PositionDAO.GetPosition();
            dtoSalary.Months = SalaryDAO.GetMonth();
            dtoSalary.SalaryDetailsDTOs = SalaryDAO.GetSalaryDetails();
            return dtoSalary;
        }

        public static void UpdateSalary(tbl_Salary tableSalaryUpdate, bool controlSal)
        {
            SalaryDAO.UpdateSalary(tableSalaryUpdate);
            if (controlSal)
                EmployeeDAO.UpdateEmployee(tableSalaryUpdate.EmpID, tableSalaryUpdate.Amount);
        }
    }
}
