using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Managment__Windows_Forms_App_.DTOs.Priority;
using Task_Managment__Windows_Forms_App_.DTOs.Projects;
using Task_Managment__Windows_Forms_App_.DTOs.Status;
using Task_Managment__Windows_Forms_App_.DTOs.Users;

namespace Task_Managment__Windows_Forms_App_.DTOs.Tasks
{
    public class DTOTaskInfo
    {
        public int TaskID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PriorityID { get; set; }
        public DTOPriorityInfo PriorityInfo { get; set; }
        public int UserID { get; set; }
        public DTOUser UserInfo { get; set; }
        public int ProjectID { get; set; }
        public DTOProjectInfo ProjectInfo { get; set; }
        public int StatusID { get; set; }
        public DTOStatusInfo StatusInfo { get; set; }
        public int CreateBy { get; set; }

        public DTOUser CreateByInfo { get; set; }
        public DateTime CreateData { get; set; }
        public DateTime DueDate { get; set; }
    }
}
