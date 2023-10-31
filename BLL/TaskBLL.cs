using DAL;
using DAL.DAO;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class TaskBLL
    {
        public static void AddTask(tbl_Task tableTask)
        {
            TaskDAO.AddTask(tableTask);
        }

        public static void ApprovedTask(int taskId, bool isAdmin)
        {
            TaskDAO.ApprovedTask(taskId, isAdmin);
        }

        public static void DeleteTask(int taskId)
        {
            TaskDAO.DeleteTask(taskId);
        }

        public static TaskDTO GetAllTask()
        {
            TaskDTO taskDTO = new TaskDTO();
            taskDTO.Departments = DepartmentDAO.GetDepartment();
            taskDTO.Positions = PositionDAO.GetPosition();
            taskDTO.Employees = EmployeeDAO.GetEmployees();
            taskDTO.TaskState = TaskDAO.GetTaskState();
            taskDTO.TaskStatesName=TaskDAO.GetAllTaskStatesName();
            taskDTO.TaskDetail = TaskDAO.GetTaskDetails();
            return taskDTO;
        }

        public static List<tbl_TaskState> GetAllTaskStatesName()
        {
            return TaskDAO.GetAllTaskStatesName();
        }

        public static void UpdateTask(tbl_Task tableTaskUpdate)
        {
            TaskDAO.UpdateTask(tableTaskUpdate);
        }
    }
}
