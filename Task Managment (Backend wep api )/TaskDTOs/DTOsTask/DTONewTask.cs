using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDTOs.DTOsTask
{
    public class DTONewTask
    {
        
        public DTONewTask(int taskID, string title, string description, int priorityID, int userID, 
            int projectID, int statusID, int createBy,
            DateTime dueDate)
        {
            TaskID = taskID;
            Title = title;
            Description = description;
            PriorityID = priorityID;
            UserID = userID;
            ProjectID = projectID;
            StatusID = statusID;
            CreateBy = createBy;
            DueDate = dueDate;
        }

        public int TaskID {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PriorityID { get; set; }
        public int UserID { get; set; }

        public int ProjectID { get; set; }
        public int StatusID { get; set; }
        public int CreateBy { get; set; }

    
        public DateTime DueDate { get; set; }


    }
}
