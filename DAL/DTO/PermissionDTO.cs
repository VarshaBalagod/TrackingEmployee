using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class PermissionDTO
    {
        public List<tbl_Department> Departments { get; set; }
        public List<PositionDTO> Positions { get; set; }
        public List<PermissionDetailDTO> PermissionDetails { get; set; }
        public List<tbl_PermissionState> PermissionState { get; set; }
    }
}
