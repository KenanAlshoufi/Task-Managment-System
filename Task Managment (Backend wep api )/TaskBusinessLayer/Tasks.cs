using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskDataAccessLayer;
using TaskDTOs.DTOsPriority;
using TaskDTOs.DTOsProject;
using TaskDTOs.DTOsStatus;
using TaskDTOs.DTOsTask;
using TaskDTOs.DTOsUser;
using static Microsoft.Data.SqlClient.Internal.SqlClientEventSource;

namespace TaskBusinessLayer
{
    public class Tasks
    {
        public enum enMode { AddNew = 0, UpdateNew = 1 }
        public enMode mode = enMode.AddNew;

        public int TaskID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PriorityID { get; set; }
        public DTOPriorityInfo PriorityInfo;
        public int UserID { get; set; }
        public DTOUserInfo UserInfo; 
        public int ProjectID { get; set; }
        public DTOProjectInfo ProjectInfo;
        public int StatusID { get; set; }
        public DTOStatusInfo StatusInfo;


        public int CreateBy { get; set; }

        public DTOUserInfo CreateByInfo; 

        public DateTime CreateData { get; set; }
        public DateTime DueDate { get; set; }

        private Tasks(DTOTaskInfo TaskInfo)
        {
            TaskID = TaskInfo.TaskID;
            Title = TaskInfo.Title;
            Description = TaskInfo.Description;

            PriorityID = TaskInfo.PriorityID;
            PriorityInfo=Priority.GetPriorityByID(PriorityID).DTOPriority;


            UserID = TaskInfo.UserID;
            UserInfo = Users.GetUserByID(UserID).DTOUser;

            ProjectID = TaskInfo.ProjectID ;
            ProjectInfo=Projects.GetProjectByID(ProjectID).DTOProject;

            StatusID = TaskInfo.StatusID ;
            StatusInfo = Status.GetStatusByID(StatusID).DTOStatus;

            CreateBy = TaskInfo.CreateBy ;
            CreateByInfo =Users.GetUserByID(CreateBy).DTOUser;


            CreateData = TaskInfo.CreateData ;
            DueDate = TaskInfo.DueDate;


            mode =enMode.UpdateNew;
        }

        public Tasks()
        {
            TaskID = -1;
            Title = "";
            Description = "";
            PriorityID = -1;
            UserID = -1;
            ProjectID = -1;
            StatusID = -1;
            CreateBy = -1;
            CreateData = DateTime.Now;
            DueDate = DateTime.Now;

            mode = enMode.AddNew;
        }

        public DTONewTask dTONewTask
        {
           get { return new DTONewTask(this.TaskID , this.Title, this.Description, this.PriorityID, this.UserID,
            this.ProjectID , this.StatusID, this.CreateBy,
           this.DueDate); }
        }

        public DTOTaskInfo dTOTask
        {
            get
            {
                return new DTOTaskInfo(this.TaskID, this.Title , this.Description , this.PriorityID ,
            this.PriorityInfo , this.UserID , this.UserInfo , this.ProjectID,
            this.ProjectInfo , this.StatusID , this.StatusInfo , this.CreateBy ,
            this.CreateByInfo, this.CreateData, this.DueDate);
            }
        }

        public DTOUpdateTask dTOUpdateTask
        {
            get
            {
                return new DTOUpdateTask(this.TaskID, this.Title, this.Description, this.PriorityID, this.UserID,
             this.StatusID,this.DueDate);
            }
        }

        public static Tasks GetTaskByID(int TaskID)
        {
            DTOTaskInfo taskInfo = TaskData.GetTaskByID(TaskID);

            if (taskInfo != null)
            {
                return new Tasks(taskInfo);
            }
            return null;
        }

        public static Tasks GetTaskByTitle(string Title)
        {
            DTOTaskInfo taskInfo = TaskData.GetTaskByTitle(Title);

            if (taskInfo != null)
            {
                return new Tasks(taskInfo);
            }
            return null;
        }

        private bool AddNewTasks()
        {
            if (Users.UserIdIsEmployee( this.CreateBy))
            {
                return false;
            }

            this.TaskID = TaskData.AddNewTasks(this.dTONewTask);

            return this.TaskID != -1;

        }

        private  bool UpdateTask()
        {
            if (Users.UserIdIsEmployee(this.CreateBy))
            {
                return false;
            }
            return TaskData.UpdateTask(this.dTOUpdateTask);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.AddNew:
                    if (AddNewTasks())
                    {
                        mode = enMode.UpdateNew;
                        return true;
                    }
                    else
                        return false;

                case enMode.UpdateNew:
                    return UpdateTask();

            }
            return false;
        }

        public static int NumberOfTasks(int UserID)
        {
            return TaskData.NumberOfTasks(UserID);
        }


        public static bool TaskIsCompleted(int TaskID)
        {
            return TaskData.TaskIsCompleted(TaskID);
        }


        public static bool TaskIsCancelled(int TaskID)
        {
            return TaskData.TaskIsCancelled(TaskID);
        }


        public static bool TaskIsInProgress(int TaskID)
        {
            return TaskData.TaskIsInProgress(TaskID);
        }

        public static bool IsTaskExist(int TaskID)
        {
            return TaskData.IsTaskExist(TaskID);
        }


        public static List<DTOTaskFullInfo> GetAllTask()
        {
            
            return TaskData.GetAllTask();
        }

        public static List<DTOTaskFullInfo> GetAllTaskCancelled()
        {
            return TaskData.GetAllTaskCancelled();
        }

        public static List<DTOTaskFullInfo> GetAllTaskForManagerIDCompleted()
        {
            return TaskData.GetAllTaskCompleted();
        }


        public static List<DTOTaskFullInfo> GetAllTaskForManagerID(int CreatedBy)
        {
            return TaskData.GetAllTaskForManagerID(CreatedBy);
        }

        public static List<DTOTaskFullInfo> GetAllTaskForManagerIDCancelled(int CreatedBy)
        {
            return TaskData.GetAllTaskForManagerIDCancelled(CreatedBy);
        }

        public static List<DTOTaskFullInfo> GetAllTaskForManagerIDCompleted(int CreatedBy)
        {
            return TaskData.GetAllTaskForManagerIDCompleted(CreatedBy);
        }


        public static List<DTOTaskFullInfo> GetAllTaskForUserID(int UserID)
        {
            return TaskData.GetAllTaskForUserID(UserID);
        }

        public static List<DTOTaskFullInfo> GetAllTaskForUserIDCancelled(int UserID)
        {
            return TaskData.GetAllTaskForUserIDCancelled(UserID);
        }

        public static List<DTOTaskFullInfo> GetAllTaskForUserIDCompleted(int UserID)
        {
            return TaskData.GetAllTaskForUserIDCompleted(UserID);
        }


        public static List<DTOTaskFullInfo> GetAllTaskForProjectID(int ProjectID)
        {
            return TaskData.GetAllTaskForProjectID(ProjectID);
        }

        public static List<DTOTaskFullInfo> GetAllTaskForProjectIDCancelled(int ProjectID)
        {
            return TaskData.GetAllTaskForProjectIDCancelled(ProjectID);
        }

        public static List<DTOTaskFullInfo> GetAllTaskForProjectIDCompleted(int ProjectID)
        {
            return TaskData.GetAllTaskForProjectIDCompleted(ProjectID);
        }


    }
}
