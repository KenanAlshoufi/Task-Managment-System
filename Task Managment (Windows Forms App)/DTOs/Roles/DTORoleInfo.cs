using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Managment__Windows_Forms_App_.DTOs.Roles
{
    public class DTORoleInfo
    {
        public DTORoleInfo()
        {
            RolesID = 0;
            Name = "";
        }
        public DTORoleInfo(int rolesID, string name)
        {
            RolesID = rolesID;
            Name = name;
        }

        public int RolesID { get; set; }
        public string Name { get; set; }
    }
}
