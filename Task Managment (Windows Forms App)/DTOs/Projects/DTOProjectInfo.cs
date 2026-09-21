using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Managment__Windows_Forms_App_.DTOs.Users;

namespace Task_Managment__Windows_Forms_App_.DTOs.Projects
{
    public  class DTOProjectInfo
    {
        public int ProjectID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ManagerID { get; set; }

        public DateTime CreateDate { get; set; }

        public DTOUser DTOUserInfo { get; set; }

    }
}
