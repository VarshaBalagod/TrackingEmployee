using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;

namespace BLL
{
    public class DepartmentBLL
    {
        public static void AddDepartment(tbl_Department department)
        {
            DepartmentDAO.AddDepartment(department);
        }

        public static void DeleteDepartment(int depID)
        {
            DepartmentDAO.DeleteDepartment(depID);
        }

        public static List<tbl_Department> GetDeparment()
        {
            return DepartmentDAO.GetDepartment();
        }

        public static void UpdateDepartment(tbl_Department tableDepartmentupdate)
        {
            DepartmentDAO.UpdateDepartment(tableDepartmentupdate);
        }
    }
}
