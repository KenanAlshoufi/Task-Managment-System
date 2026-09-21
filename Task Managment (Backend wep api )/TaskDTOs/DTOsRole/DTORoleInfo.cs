using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDTOs.DTOsRole
{
    public class DTORoleInfo
    {
        public DTORoleInfo()
        {
            RoleID = 0;
            Name = "";
        }
        public DTORoleInfo(int rolesID, string name)
        {
            RoleID = rolesID;
            Name = name;
        }

        public int RoleID { get; set; }
        public string Name { get; set; }
    }
}
