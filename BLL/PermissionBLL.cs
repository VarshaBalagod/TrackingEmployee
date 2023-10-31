using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;
using DAL.DTO;

namespace BLL
{
    public class PermissionBLL
    {
        public static void AddPermission(tbl_Permission tablePermission)
        {
            PermisssionDAO.AddPermission(tablePermission);
        }

        public static void DeletePermission(int perId)
        {
            PermisssionDAO.DeletePermission(perId);
        }

        public static PermissionDTO GetAllPermission()
        {
            PermissionDTO dtoPermission = new PermissionDTO();
            dtoPermission.Departments = DepartmentDAO.GetDepartment();
            dtoPermission.Positions = PositionDAO.GetPosition();
            dtoPermission.PermissionState = PermisssionDAO.GetPermissionState();
            dtoPermission.PermissionDetails = PermisssionDAO.GetAllPermissionDetail();
            return dtoPermission;
        }

        public static void UpdatePermission(tbl_Permission tablePermission)
        {
            PermisssionDAO.UpdatePermission(tablePermission);
        }

        public static void UpdatePermission(int perId, int approved)
        {
            PermisssionDAO.UpdatePermission(perId, approved);
        }
    }
}
