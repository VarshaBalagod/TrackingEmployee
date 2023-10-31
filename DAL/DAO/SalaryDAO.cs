using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class SalaryDAO : EmployeeContent
    {
        public static void AddSalaryAmmount(tbl_Salary tableSalary)
        {
            try
            {
                db.tbl_Salaries.InsertOnSubmit(tableSalary);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteSalary(int salId)
        {
            try
            {
                tbl_Salary tableSalary = db.tbl_Salaries.First(x => x.SalID == salId);
                db.tbl_Salaries.DeleteOnSubmit(tableSalary);
                db.SubmitChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<tbl_Month> GetMonth()
        {
            return db.tbl_Months.ToList();
        }

        public static List<SalaryDetailsDTO> GetSalaryDetails()
        {
           List<SalaryDetailsDTO> salaryDetails = new List<SalaryDetailsDTO>();

            var list = (from sa in db.tbl_Salaries
                        join e in db.tbl_Employees on sa.EmpID equals e.EmpID
                        join m in db.tbl_Months on sa.MonthID equals m.MonID
                        join d in db.tbl_Departments on e.DepID equals d.DepID
                        join p in db.tbl_Positions on e.PosID equals p.PosID
                        select new
                        {
                            empid = e.EmpID,
                            empNumber = e.EmployeeNumber,
                            empName = e.EmployeeeName,
                            empSurname = e.EmployeeSurname,
                            empSalId = sa.SalID,
                            empAmount = sa.Amount,
                            empYear = sa.Year,
                            empSalMonth = m.MonthName,
                            empMontId = m.MonID,
                            empDepid = e.DepID,
                            empPosid = e.PosID,
                            empDeparmeName = d.DepartmentName,
                            empPosName = p.PositionName
                        });

            foreach ( var item in list )
            {
                SalaryDetailsDTO dto = new SalaryDetailsDTO();
                dto.EmpId = item.empid;
                dto.EmployeeNumber = item.empNumber;
                dto.EmployeeName = item.empName;
                dto.EmployeeSurname = item.empSurname;
                dto.SalaryAmount = item.empAmount;
                dto.SalaryMonth = item.empSalMonth;
                dto.MonthId = item.empMontId;
                dto.SalaryYear = item.empYear;
                dto.DepId = item.empDepid;
                dto.PosId = item.empPosid;
                dto.SalId = item.empSalId;
                dto.OldSalary = item.empAmount;
                dto.EmployeeDepartmentName = item.empDeparmeName;
                dto.EmployeePositionName = item.empPosName;
                salaryDetails.Add(dto);
            }
            return salaryDetails;
        }

        public static void UpdateSalary(tbl_Salary tableSalaryUpdate)
        {
            try 
            {
                tbl_Salary tableSalary = db.tbl_Salaries.First(x => x.SalID == tableSalaryUpdate.SalID);
                tableSalary.Amount = tableSalaryUpdate.Amount;
                tableSalary.Year = tableSalaryUpdate.Year;
                tableSalary.MonthID = tableSalaryUpdate.MonthID;
                db.SubmitChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
