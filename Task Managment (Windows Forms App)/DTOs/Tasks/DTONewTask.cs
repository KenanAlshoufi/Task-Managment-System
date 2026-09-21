using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Managment__Windows_Forms_App_.DTOs.Tasks
{
    public class DTONewTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int PriorityID { get; set; }
        public int UserID { get; set; }
        public int ProjectID { get; set; }
        public int CreateBy { get; set; }


        public DateTime DueDate { get; set; }
    }
}
