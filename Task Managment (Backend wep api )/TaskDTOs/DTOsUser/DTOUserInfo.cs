using System.Data;
using TaskDTOs.DTOsRole;

namespace TaskDTOs.DTOsUser
{
    public class DTOUserInfo
    {
        public DTOUserInfo()
        {
            UserId = -1;
            FirstName = "";
            LastName = "";
            Email = "";
            RoleId = -1;
            IsActive = false;
            ProfileImage = "";
            DTORoleInfo = new DTORoleInfo();
        }

        public DTOUserInfo(int userId, string firstName, string lastName, string email, 
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

      public  DTORoleInfo DTORoleInfo { get; set; }
      
    }
}
