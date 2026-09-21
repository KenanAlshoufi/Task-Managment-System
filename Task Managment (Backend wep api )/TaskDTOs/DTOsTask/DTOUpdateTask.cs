using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDTOs.DTOsTask
{
    public class DTOUpdateTask
    {
        public DTOUpdateTask(int taskID, string title, string description, int priorityID, int userID,
          int statusID, DateTime dueDate)
        {
            TaskID = taskID;
            Title = title;
            Description = description;
            PriorityID = priorityID;
            UserID = userID;
            StatusID = statusID;
            DueDate = dueDate;
        }

        public int TaskID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PriorityID { get; set; }
        public int UserID { get; set; }
        public int StatusID { get; set; }
        public DateTime DueDate { get; set; }

    }
}
