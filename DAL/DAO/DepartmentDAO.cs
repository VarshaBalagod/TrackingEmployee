using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class DepartmentDAO : EmployeeContent
    {
        public static void AddDepartment(tbl_Department department)
        {
            try
            {
                db.tbl_Departments.InsertOnSubmit(department);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        public static void DeleteDepartment(int depID)
        {
            try
            {
                tbl_Department tableDepartment = db.tbl_Departments.First(x => x.DepID == depID);
                db.tbl_Departments.DeleteOnSubmit(tableDepartment);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<tbl_Department> GetDepartment()
        {
           return db.tbl_Departments.ToList();
        }

        public static void UpdateDepartment(tbl_Department tableDepartmentupdate)
        {
           try
            {
                tbl_Department tableDeartment = db.tbl_Departments.First(x => x.DepID == tableDepartmentupdate.DepID);
                tableDeartment.DepartmentName = tableDepartmentupdate.DepartmentName;
                db.SubmitChanges();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
