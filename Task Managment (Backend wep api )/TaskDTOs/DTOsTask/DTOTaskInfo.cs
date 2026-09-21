using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TaskDTOs.DTOsPriority;
using TaskDTOs.DTOsProject;
using TaskDTOs.DTOsStatus;
using TaskDTOs.DTOsUser;

namespace TaskDTOs.DTOsTask
{
    public class DTOTaskInfo
    {
        public DTOTaskInfo() { }
        public int TaskID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PriorityID { get; set; }
        public DTOPriorityInfo PriorityInfo { get; set; }
        public int UserID { get; set; }
        public DTOUserInfo UserInfo { get; set; }
        public int ProjectID { get; set; }
        public DTOProjectInfo ProjectInfo { get; set; }
        public int StatusID { get; set; }
        public DTOStatusInfo StatusInfo { get; set; }


        public int CreateBy { get; set; }

        public DTOUserInfo CreateByInfo { get; set; }
        public DateTime CreateData { get; set; }
        public DateTime DueDate { get; set; }

        public DTOTaskInfo(int taskID, string title, string description, int priorityID, 
            DTOPriorityInfo priorityInfo, int userID, DTOUserInfo userInfo, int projectID,
            DTOProjectInfo projectInfo, int statusID, DTOStatusInfo statusInfo, int createBy,
            DTOUserInfo createByInfo, DateTime createData, DateTime dueDate)
        {
            TaskID = taskID;
            Title = title;
            Description = description;
            PriorityID = priorityID;
            PriorityInfo = priorityInfo;
            UserID = userID;
            UserInfo = userInfo;
            ProjectID = projectID;
            ProjectInfo = projectInfo;
            StatusID = statusID;
            StatusInfo = statusInfo;
            CreateBy = createBy;
            CreateByInfo = createByInfo;
            CreateData = createData;
            DueDate = dueDate;
        }

      
    }
}
