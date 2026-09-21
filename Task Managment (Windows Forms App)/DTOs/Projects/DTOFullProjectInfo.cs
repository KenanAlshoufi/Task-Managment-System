using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Managment__Windows_Forms_App_.DTOs.Projects
{
    public class DTOFullProjectInfo
    {
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string managerName { get; set; }
        public int ManagerID { get; set; }
        public DateTime CreatedData { get; set; }

    }
}
