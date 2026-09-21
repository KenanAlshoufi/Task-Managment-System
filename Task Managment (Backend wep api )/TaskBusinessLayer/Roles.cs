using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskDataAccessLayer;
using TaskDTOs.DTOsRole;

namespace TaskBusinessLayer
{
    public class Roles
    {
        public Roles(DTORoleInfo roleInfo)
        {
            RolesID = roleInfo.RoleID;
            Name = roleInfo.Name;
        }

        public int RolesID { get; set; }
        public string Name { get; set; }

        public DTORoleInfo DTORole
        {
            get { return new DTORoleInfo(this.RolesID, this.Name); }
        }

        public static Roles GetRolesByID(int RolesID)
        {
            DTORoleInfo roleInfo = RolesData.GetRolesByID(RolesID);
           
            if (roleInfo  !=null)
            {
                return new Roles(roleInfo);
            }
            return null;
        }

        public static Roles GetRolesByName(string Name)
        {
            DTORoleInfo roleInfo = RolesData.GetRolesByName(Name);

            if (roleInfo != null)
            {
                return new Roles(roleInfo);
            }
            return null;
        }


        public static List<DTORoleInfo> GetAllRoles()
        {
            return RolesData.GetAllRoles();
        }
    }
}
