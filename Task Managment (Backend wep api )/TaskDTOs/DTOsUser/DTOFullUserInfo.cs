using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDTOs.DTOsUser
{
    public class DTOFullUserInfo
    {
        public DTOFullUserInfo(int userID, string fullName, string email, string role, bool isActive)
        {
            UserID = userID;
            FullName = fullName;
            Email = email;
            Role = role;
            IsActive = isActive;
        }

        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
    }
}
