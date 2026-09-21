using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBusinessLayer.Security;
using TaskDataAccessLayer;
using TaskDTOs.DTOsRole;
using TaskDTOs.DTOsUser;

namespace TaskBusinessLayer
{
    public class Users
    {
        public enum enMode { AddNew=0, UpdateNew=1 }
        public enMode mode=enMode.AddNew;

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public DTORoleInfo RoleInfo { get; set; }

        public bool IsActive { get; set; }
        public string ProfileImage { get; set; }


        public DTONewUser DTONewUser
        {
            get {
                return new DTONewUser(this.UserId, this.FirstName, this.LastName, this.Email,this.Password,
                this.RoleId, this.IsActive, this.ProfileImage); }
        }

        public DTOUserInfo DTOUser
        {
            get
            {
                return new DTOUserInfo(this.UserId, this.FirstName, this.LastName, this.Email,
                this.RoleId, this.IsActive, this.ProfileImage,this.RoleInfo);
            }
        }

        public Users() 
        {
            UserId = -1;
            FirstName = "";
            LastName = "";
            Email = "";
            Password = "";
            RoleId = -1;
            IsActive = false;
            ProfileImage = "";

            mode = enMode.AddNew;
        }

        private Users(DTOUserInfo DTOFullUser)
        {
            UserId = DTOFullUser.UserId;
            FirstName = DTOFullUser.FirstName;
            LastName = DTOFullUser.LastName;
            Email = DTOFullUser.Email;
            RoleId = DTOFullUser.RoleId;
            IsActive = DTOFullUser.IsActive;
            ProfileImage = DTOFullUser.ProfileImage;

            RoleInfo=Roles.GetRolesByID(RoleId).DTORole;
            mode =enMode.UpdateNew;
        }
        public static List<DTOFullUserInfo> GetAllUser()
        {
            return UsersData.GetAllUser();
        }

        public static Users GetUserByID(int UserID)
        {
            DTOUserInfo fullUserInfo = UsersData.GetUserByID(UserID);
            if (fullUserInfo != null)
            {
                return new Users(fullUserInfo);
            }

            return null  ;
        }

        public static Users GetUserByName(string FullName)
        {
            DTOUserInfo fullUserInfo = UsersData.GetUserByName(FullName);
            if (fullUserInfo != null)
            {
                return new Users(fullUserInfo);
            }

            return null;
        }

        public static Users GetUserByEamil(string Email)
        {
            DTOUserInfo fullUserInfo = UsersData.GetUserByEamil(Email);
            if (fullUserInfo != null)
            {
                return new Users(fullUserInfo);
            }

            return null;
        }
        public static Users LoginToAccount(string Email, string Password)
        {
            string PasswordHashed = "";
            DTOUserInfo User = UsersData.LoginToAccount(Email,ref PasswordHashed);
            if (User == null)
            {
                return null;
            }

            bool IsLogin = PasswordHasherService.VerifyPassword(PasswordHashed, Password);
            if (IsLogin)
            {
                return new Users(User);
            }
          
            return null;
        }


        public static bool UserIdIsAdmin(int UserID)
        {
            return UsersData.UserIdIsAdmin(UserID);
        }

        public static bool UserIdIsManager(int UserID)
        {
            return UsersData.UserIdIsManager(UserID);
        }

        public static bool UserIdIsEmployee(int UserID)
        {
            return UsersData.UserIdIsEmployee(UserID);
        }

        public static bool UserIsActive(int UserID)
        {
            return UsersData.UserIsActive(UserID);
        }

        private bool AddNewUsers(DTONewUser NewUser)
        {
            if(NewUser.ProfileImage == "")
                NewUser.ProfileImage = null;


            NewUser.Password= PasswordHasherService.HashPassword(Password); 

            this.UserId=UsersData.AddNewUsers(NewUser);

            return this.UserId != -1;
        }

        public static bool UploadImage(int UserID, string ProfileImage)
        {
            return UsersData.UploadImage(UserID, ProfileImage);
        }

        private bool UpdateUser(DTONewUser NewUser)
        {
            if (NewUser.ProfileImage == "")
                NewUser.ProfileImage = null;

            NewUser.Password = PasswordHasherService.HashPassword(Password);

            return UsersData.UpdateUser(NewUser);
        }

        public static bool DeleteUserByID(int UserID)
        {
            return UsersData.DeleteUserByID(UserID);
        }

        public static bool IsUserExist(int UserID)
        {
            return UsersData.IsUserExist(UserID);
        }


        public static bool IsEmailExist(string Email)
        {
            return UsersData.IsEmailExist(Email);
        }
        public bool Save()
        {
            switch (mode)
            {
                case enMode.AddNew:
                    if (AddNewUsers(this.DTONewUser))
                    {
                        mode = enMode.UpdateNew;
                        return true;
                    }
                    else
                        return false;

                case enMode.UpdateNew:
                    return UpdateUser(this.DTONewUser);

            }
            return false;
        }



    }
}
