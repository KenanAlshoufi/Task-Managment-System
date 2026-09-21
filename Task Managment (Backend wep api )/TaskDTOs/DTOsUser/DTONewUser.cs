using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskDTOs.DTOsUser
{
    public class DTONewUser
    {
        public DTONewUser(int userId, string firstName, string lastName, string email, string password,
          int roleId, bool isActive, string profileImage)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            RoleId = roleId;
            IsActive = isActive;
            ProfileImage = profileImage;
        }



        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }
        public string ProfileImage { get; set; }
    }
}
