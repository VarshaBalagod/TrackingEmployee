using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class PermisssionDAO : EmployeeContent
    {
        public static void AddPermission(tbl_Permission tablePermission)
        {
            try
            {
                db.tbl_Permissions.InsertOnSubmit(tablePermission);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeletePermission(int perId)
        {
            try 
            {
                tbl_Permission tablePermission = db.tbl_Permissions.First(x => x.PerID == perId);
                db.tbl_Permissions.DeleteOnSubmit(tablePermission);
                db.SubmitChanges();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public static List<PermissionDetailDTO> GetAllPermissionDetail()
        {
            List<PermissionDetailDTO> permissionDetailDTOs = new List<PermissionDetailDTO>();

            var list = (from pr in db.tbl_Permissions
                        join st in db.tbl_PermissionStates on pr.PermissionState equals st.PstID
                        join e in db.tbl_Employees on pr.EmpID equals e.EmpID
                        select new
                        {
                            empId = e.EmpID,
                            depid = e.DepID,
                            posid = e.PosID,
                            perid = pr.PerID,
                            psStid = pr.PermissionState,
                            empNumbr = e.EmployeeNumber,
                            empName = e.EmployeeeName,
                            empSurname = e.EmployeeSurname,
                            psStartDate = pr.PermissionSartDate,
                            psEndDate = pr.PermissionEndDate,
                            psPermiDay = pr.PermissionDay,
                            psPermiExpln = pr.PermissionExplaination,
                            psStatNme = st.PermissionStateName
                        });
            foreach (var item in list)
            {
                PermissionDetailDTO detailDTO = new PermissionDetailDTO();
                detailDTO.EmpId = item.empId;
                detailDTO.DepId = item.depid;
                detailDTO.PosId=item.posid;
                detailDTO.PStateId=item.psStid;
                detailDTO.EmployeeName = item.empName;
                detailDTO.EmployeeSurname = item.empSurname;
                detailDTO.EmployeeNumber = item.empNumbr;
                detailDTO.PStateName = item.psStatNme;
                detailDTO.PermissionDay = item.psPermiDay;
                detailDTO.PermissionSartDate = item.psStartDate;
                detailDTO.PermissionEndDate = item.psEndDate;
                detailDTO.PermissionExplaination = item.psPermiExpln;
                detailDTO.perId = item.perid;
                permissionDetailDTOs.Add(detailDTO);
            }
            return permissionDetailDTOs;
        }

        public static List<tbl_PermissionState> GetPermissionState()
        {
            return db.tbl_PermissionStates.ToList();
        }

        public static void UpdatePermission(tbl_Permission tablePermission)
        {
            try
            {
                tbl_Permission pr = db.tbl_Permissions.First(x => x.PerID == tablePermission.PerID);
                pr.PermissionSartDate= tablePermission.PermissionSartDate;
                pr.PermissionExplaination= tablePermission.PermissionExplaination;
                pr.PermissionEndDate= tablePermission.PermissionEndDate;
                pr.PermissionDay= tablePermission.PermissionDay;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdatePermission(int perId, int approved)
        {
            try
            {
                tbl_Permission pr = db.tbl_Permissions.First(x => x.PerID == perId);
                pr.PermissionState= approved;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
