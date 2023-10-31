using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class EmployeeDAO : EmployeeContent
    {
        public static void AddEmployee(tbl_Employee employee)
        {
            try
            {
                db.tbl_Employees.InsertOnSubmit(employee);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
        public static List<EmployeeDetailDTO> GetEmployees()
        {
            List<EmployeeDetailDTO> employeeDetailDTOs = new List<EmployeeDetailDTO>();

            var list = (from e in db.tbl_Employees
                        join d in db.tbl_Departments on e.DepID equals d.DepID
                        join p in db.tbl_Positions on e.PosID equals p.PosID
                        select new
                        {
                            EmpId = e.EmpID,
                            EmployeeNumber = e.EmployeeNumber,
                            EmployeePassword = e.EmployeePassword,
                            EmployeeName = e.EmployeeeName,
                            EmployeeSurname = e.EmployeeSurname,
                            EmployeeSalary = e.EmployeeSalary,
                            EmployeeImagePath = e.EmployeePhotoPath,
                            EmployeeAddres = e.EmployeeAddress,
                            isAdmin = e.IsAdmin,
                            EmployeeBirthday = e.EmployeeBirthDay,
                            EmployeeDepartmentName = d.DepartmentName,
                            EmployeeDepID = d.DepID,
                            EmployeePositionName = p.PositionName,
                            EmployeePosID = p.PosID
                        }
                      ).OrderBy(x => x.EmpId).ToList();

            foreach (var item in list)
            {
                EmployeeDetailDTO detailDTO = new EmployeeDetailDTO();
                detailDTO.EmpId = item.EmpId;
                detailDTO.EmployeeNumber = item.EmployeeNumber;
                detailDTO.EmployeePassword = item.EmployeePassword;
                detailDTO.EmployeeName = item.EmployeeName;
                detailDTO.EmployeeSurname = item.EmployeeSurname;
                detailDTO.EmployeeSalary = item.EmployeeSalary;
                detailDTO.EmployeeImagePath = item.EmployeeImagePath;
                detailDTO.EmployeeAddress = item.EmployeeAddres;
                detailDTO.isAdmin = item.isAdmin;
                detailDTO.EmployeeBirthday = item.EmployeeBirthday;
                detailDTO.EmployeeDepartmentName = item.EmployeeDepartmentName;
                detailDTO.DepId = item.EmployeeDepID;
                detailDTO.EmployeePositionName = item.EmployeePositionName;
                detailDTO.PosId = item.EmployeePosID;
                employeeDetailDTOs.Add(detailDTO);
            }

            return employeeDetailDTOs;
        }

        // for employee form to check number exist or not
        public static List<tbl_Employee> GetEmployee(int v)
        {
            return db.tbl_Employees.Where(x => x.EmployeeNumber == v).ToList();
        }

        //for login page
        public static List<tbl_Employee> GetEmployee(int v, string text)
        {
            try
            {
                List<tbl_Employee> list = db.tbl_Employees.Where(x => x.EmployeeNumber == v && x.EmployeePassword == text).ToList();
                return list;

            }
            catch(Exception ex) 
            {
                throw ex;
            }
                
        }

        //Salary update form salary page
        public static void UpdateEmployee(int empID, int Amount)
        {
            try
            {
                tbl_Employee tableEmployee = db.tbl_Employees.First(x => x.EmpID == empID);
                tableEmployee.EmployeeSalary = Amount;
                db.SubmitChanges();
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
        //employee update on employee page
        public static void UpdateEmployee(tbl_Employee tableEmployeeUpdate)
        {
            try 
            {
                tbl_Employee tableEmployee = db.tbl_Employees.First(x=>x.EmpID == tableEmployeeUpdate.EmpID);
                tableEmployee.EmpID = tableEmployeeUpdate.EmpID;
                tableEmployee.EmployeeNumber = tableEmployeeUpdate.EmployeeNumber;
                tableEmployee.EmployeePassword = tableEmployeeUpdate.EmployeePassword;
                tableEmployee.IsAdmin = tableEmployeeUpdate.IsAdmin;
                tableEmployee.EmployeeeName = tableEmployeeUpdate.EmployeeeName;
                tableEmployee.EmployeeSurname = tableEmployeeUpdate.EmployeeSurname;
                tableEmployee.EmployeePhotoPath = tableEmployeeUpdate.EmployeePhotoPath;
                tableEmployee.EmployeeSalary = tableEmployeeUpdate.EmployeeSalary;
                tableEmployee.EmployeeBirthDay = tableEmployeeUpdate.EmployeeBirthDay;
                tableEmployee.EmployeeAddress = tableEmployeeUpdate.EmployeeAddress;
                tableEmployee.DepID= tableEmployeeUpdate.DepID;
                tableEmployee.PosID= tableEmployeeUpdate.PosID;
                db.SubmitChanges();
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
        //Update employee on position update position page
        public static void UpdateEmployee(tbl_Position tablePositionUpdate)
        {
            try
            {
                List<tbl_Employee> listEmployee = db.tbl_Employees.Where(x => x.PosID == tablePositionUpdate.PosID).ToList();
                foreach(var item in listEmployee)
                {
                    item.DepID = tablePositionUpdate.DepID;
                }
                db.SubmitChanges();
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
        //Delete employee on employee list page
        public static void DeleteEmployee(int empId)
        {
            try
            {
                tbl_Employee tableEmployee = db.tbl_Employees.First(x => x.EmpID == empId);
                db.tbl_Employees.DeleteOnSubmit(tableEmployee);
                db.SubmitChanges();

                /*-----------------------------------------------------------------------------------------------------------*/
                /*as we declare triger delete_employee in sql we don't required to delete from here for related table records*/
                /*This probably use for bulk data delete if record have bulk data in related tables - Trigger use*/
                /*
                //employee related task delete
                List<tbl_Task> listTask = db.tbl_Tasks.Where(x => x.EmpID == empId).ToList();
                db.tbl_Tasks.DeleteAllOnSubmit(listTask);
                db.SubmitChanges();

                //employee releted salary delete
                List<tbl_Salary> listSalary = db.tbl_Salaries.Where(x => x.EmpID == empId).ToList();
                db.tbl_Salaries.DeleteAllOnSubmit(listSalary);
                db.SubmitChanges();

                //employee related permission delete
                List<tbl_Permission> listPermission = db.tbl_Permissions.Where(x => x.EmpID == empId).ToList();
                db.tbl_Permissions.DeleteAllOnSubmit(listPermission);
                db.SubmitChanges();*/
                /*-----------------------------------------------------------------------------------------------------------*/
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
