using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace DAL.DAO
{
    public class PositionDAO : EmployeeContent
    {
        public static void AddPosition(tbl_Position position)
        {
            try 
            { 
                db.tbl_Positions.InsertOnSubmit(position);
                db.SubmitChanges();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public static void DeletePosition(int posID)
        {
            try
            {
                tbl_Position tablePosition = db.tbl_Positions.First(x => x.PosID == posID);
                db.tbl_Positions.DeleteOnSubmit(tablePosition);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<PositionDTO> GetPosition()
        {
            try
            {
                var list = (from p in db.tbl_Positions
                            join d in db.tbl_Departments on p.DepID equals d.DepID
                            select new
                            {
                                positionID = p.PosID,
                                postionName = p.PositionName,
                                deparmentID = d.DepID,
                                deparmentName = d.DepartmentName
                            }
                          ).OrderBy(x => x.positionID).ToList();

                List<PositionDTO> positionList= new List<PositionDTO>();

                foreach (var item in list)
                {
                    PositionDTO dto = new PositionDTO();
                    dto.PosID = item.positionID;
                    dto.PositionName = item.postionName;
                    dto.DepID = item.deparmentID;
                    dto.DepartmentName = item.deparmentName;
                    positionList.Add(dto);
                }
                return positionList;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdatePosition(tbl_Position tablePositionUpdate)
        {
            try
            {
                tbl_Position tablePosition = db.tbl_Positions.First(x => x.PosID == tablePositionUpdate.PosID);
                tablePosition.DepID = tablePositionUpdate.DepID;
                tablePosition.PositionName = tablePositionUpdate.PositionName;
                db.SubmitChanges();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
