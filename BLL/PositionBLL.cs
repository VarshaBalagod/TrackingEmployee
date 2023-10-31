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
    public class PositionBLL
    {
        public static void AddPosition(tbl_Position position)
        {
            PositionDAO.AddPosition(position);
        }

        public static void DeletePosition(int posID)
        {
            PositionDAO.DeletePosition(posID);
        }

        public static List<PositionDTO> GetAllPosition()
        {
           return  PositionDAO.GetPosition();
        }

        public static void UpdatePositon(tbl_Position tablePositionUpdate, bool control)
        {
            PositionDAO.UpdatePosition(tablePositionUpdate);
            if (control)
                EmployeeDAO.UpdateEmployee(tablePositionUpdate);
        }
    }
}
