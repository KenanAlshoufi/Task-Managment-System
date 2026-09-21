using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Managment__Windows_Forms_App_.DTOs.Roles;

namespace Task_Managment__Windows_Forms_App_.DTOs.Users
{
    public class DTOUser
    {
        public DTOUser(int userId, string firstName, string lastName, string email,
          int roleId, bool isActive, string profileImage, DTORoleInfo dTORoleInfo)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            RoleId = roleId;
            IsActive = isActive;
            ProfileImage = profileImage;

            DTORoleInfo = dTORoleInfo;
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }
        public string ProfileImage { get; set; }

        public DTORoleInfo DTORoleInfo { get; set; }
    }
}
