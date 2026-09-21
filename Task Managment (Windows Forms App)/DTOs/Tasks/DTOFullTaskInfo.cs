using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Managment__Windows_Forms_App_.DTOs.Tasks
{
    public class DTOFullTaskInfo
    {
        public int TaskID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string PriorityName { get; set; }

        public string StatusName { get; set; }

        public string ProjectName { get; set; }

        public string AssignedUserName { get; set; }
        public string ManagerName { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime DueDate { get; set; }
    }
}
