using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;
using DAL;

namespace BLL
{
    public class EmployeeBLL
    {
        //insert employee data in table
        public static void AddEmployee(tbl_Employee employee)
        {
            EmployeeDAO.AddEmployee(employee);
        }

        public static void DeleteEmployee(int empId)
        {
            EmployeeDAO.DeleteEmployee(empId);
        }

        //to get all tables / data realted to employee
        public static EmployeeDTO GetAllEmployee()
        {
            EmployeeDTO dtoEmployee = new EmployeeDTO();
            dtoEmployee.Departments = DepartmentDAO.GetDepartment();
            dtoEmployee.Positions = PositionDAO.GetPosition();
            dtoEmployee.Employees = EmployeeDAO.GetEmployees();
            return dtoEmployee;
        }

        //to login form
        public static List<tbl_Employee> GetEmployee(int v, string text)
        {
            return EmployeeDAO.GetEmployee(v, text);
        }

        // to check employee number exists in table in employee form
        public static bool IsUniqueEmployeeNumber(int v)
        {
            List<tbl_Employee> listEmp = EmployeeDAO.GetEmployee(v);
            if (listEmp.Count > 0)
                return false;
            else
                return true;
        }
        //employee update on employee page
        public static void UpdateEmployee(tbl_Employee tableEmployeeUpdate)
        {
            EmployeeDAO.UpdateEmployee(tableEmployeeUpdate);
        }
    }
}
