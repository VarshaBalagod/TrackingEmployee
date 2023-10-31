using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class TaskDAO : EmployeeContent
    {
        public static void AddTask(tbl_Task tableTask)
        {
            try 
            {
                db.tbl_Tasks.InsertOnSubmit(tableTask);
                db.SubmitChanges();
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }

        public static void ApprovedTask(int taskId, bool isAdmin)
        {
            try
            {
                tbl_Task tableTask = db.tbl_Tasks.First(x => x.TaskID == taskId);
                if (isAdmin)
                    tableTask.TaskSate = TaskState.Approved;
                else
                    tableTask.TaskSate = TaskState.Delivered;
                tableTask.TaskDeleveryDate = DateTime.Today;
                db.SubmitChanges();                             
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteTask(int taskId)
        {
            try 
            {
                tbl_Task tableTask = db.tbl_Tasks.First(x => x.TaskID == taskId);
                db.tbl_Tasks.DeleteOnSubmit(tableTask);
                db.SubmitChanges();
            }
            catch(Exception ex) 
            { 
                throw ex; 
            }
        }

        public static List<tbl_TaskState> GetAllTaskStatesName()
        {
            return db.tbl_TaskStates.ToList();
        }

        public static List<TaskDetailDTO> GetTaskDetails()
        {
            List<TaskDetailDTO> taskDetailDTOs = new List<TaskDetailDTO>();

            var list = (from t in db.tbl_Tasks
                        join ts in db.tbl_TaskStates on t.TaskSate equals ts.TskstID
                        join e in db.tbl_Employees on t.EmpID equals e.EmpID
                        join d in db.tbl_Departments on e.DepID equals d.DepID
                        join p in db.tbl_Positions on e.PosID equals p.PosID
                        select new
                        {
                            taskId = t.TaskID,
                            taskTitle = t.TaskTitle,
                            taskContent = t.TaskContent,
                            startDate = t.TaskStartDate,
                            deliveryDate = t.TaskDeleveryDate,
                            taskStateId = t.TaskSate,
                            taskState = ts.TaskStateName,
                            empId = t.EmpID,
                            empNumber = e.EmployeeNumber,
                            empName = e.EmployeeeName,
                            empSurname = e.EmployeeSurname,
                            depId = e.DepID,
                            depName = d.DepartmentName,
                            posId = e.PosID,
                            posName = p.PositionName
                        }).OrderBy(x => x.startDate).ToList();

            foreach (var item in list)
            {
               TaskDetailDTO dto = new TaskDetailDTO();
                dto.TaskId = item.taskId;
                dto.TaskTitle = item.taskTitle;
                dto.TaskContent = item.taskContent;
                dto.TaskStartDate = Convert.ToDateTime(item.startDate);
                dto.TaskDeliveryDate = Convert.ToDateTime(item.deliveryDate);
                
                dto.TaskStateId = item.taskStateId;
                dto.TaskStateName = item.taskState;
               
                dto.EmpId = item.empId;
                dto.EmployeeNumber = item.empNumber;
                dto.EmployeeName = item.empName;
                dto.EmployeeSurname = item.empSurname;

                dto.DepId = item.depId;
                dto.EmployeeDepartmentName = item.depName;

                dto.PosId = item.posId;
                dto.EmployeePositionName = item.posName;
                taskDetailDTOs.Add(dto);
            }

            return taskDetailDTOs;
        }

        public static List<tbl_Task> GetTaskState()
        {
            return db.tbl_Tasks.ToList();
        }

        public static void UpdateTask(tbl_Task tableTaskUpdate)
        {
            try 
            {
                tbl_Task tableTask = db.tbl_Tasks.First(x => x.TaskID == tableTaskUpdate.TaskID);
                tableTask.TaskTitle = tableTaskUpdate.TaskTitle;
                tableTask.TaskContent = tableTaskUpdate.TaskContent;
                tableTask.TaskSate = tableTaskUpdate.TaskSate;
                tableTask.EmpID= tableTaskUpdate.EmpID;
                db.SubmitChanges();
            }
            catch (Exception ex)
            { 
                throw ex; 
            }
        }
    }
}
