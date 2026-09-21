using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDTOs.DTOsTask
{
    public class DTOTaskFullInfo
    {
        public DTOTaskFullInfo(int taskID, string title, string description, string priorityName,
            string assignedUserName
            , string projectName,
            string statusName,
            string managerName, DateTime createDate, DateTime dueDate)
        {
            TaskID = taskID;
            Title = title;
            Description = description;
            AssignedUserName = assignedUserName;
            PriorityName = priorityName;
            ProjectName = projectName;
            StatusName = statusName;
            ManagerName = managerName;
            CreateDate = createDate;
            DueDate = dueDate;
        }

        public int TaskID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string PriorityName { get; set; }

        public string AssignedUserName { get; set; }

        public string ProjectName { get; set; }

        public string StatusName { get; set; }
        public string ManagerName { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime DueDate { get; set; }
    }
}
