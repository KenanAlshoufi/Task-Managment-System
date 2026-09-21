using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using TaskBusinessLayer;
using TaskDTOs;
using TaskDTOs.DTOsLogin;
using TaskDTOs.DTOsUser;

namespace Task_Managment_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersApiController : ControllerBase
    {

        [HttpGet("GetAllUser", Name = "GetAllUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DTOFullUserInfo> GetAllUser()
        {
         
            List<DTOFullUserInfo> UsersInfo = Users.GetAllUser();

            if (UsersInfo == null)
            {
                return NotFound("No think.");
            }
        
            return Ok(UsersInfo);
        }



        [HttpGet("GetUserByID/{UserID}",Name = "GetUserByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DTOUserInfo> GetUserByID(int UserID)
        {
            if (UserID < 1)
            {
                return BadRequest($"this id {UserID} is not Accespt.");
            }

            Users UserInfo = Users.GetUserByID(UserID);

            if (UserInfo == null)
            {
                return NotFound($"User with ID {UserID} is not found.");
            }

            DTOUserInfo fullUserInfo = UserInfo.DTOUser;

            return Ok(fullUserInfo);
        }

        [HttpGet("GetUserByName/{FullName}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DTOUserInfo> GetUserByName(string FullName)
        {
            if ( FullName == "")
            {
                return BadRequest($"this Name is Required.");
            }

            Users UserInfo = Users.GetUserByName(FullName);

            if (UserInfo == null)
            {
                return NotFound($"User with Name {FullName} is not found.");
            }

            DTOUserInfo fullUserInfo = UserInfo.DTOUser;

            return Ok(fullUserInfo);
        }

        [HttpPost("UploadImage")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UploadImage(IFormFile ImageFile)
        {
            if (ImageFile == null || ImageFile.Length == 0)
            {
                return BadRequest($"Image with Path not found.");
            }

            string UploadDirctory = @"D:\UploadUserImage";
            string FileName = Guid.NewGuid().ToString() + Path.GetExtension(ImageFile.FileName);
            string FilePath = Path.Combine(UploadDirctory, FileName);

            if (!Directory.Exists(UploadDirctory))
            {
                Directory.CreateDirectory(UploadDirctory);
            }

            using (var Stream = new FileStream(FilePath, FileMode.Create))
            {
                await ImageFile.CopyToAsync(Stream);
            }

            return Ok(new { FileName });
        }


        private string GetMimeType(string FilePath)
        {
            var extension = Path.GetExtension(FilePath).ToLowerInvariant();
            return extension switch
            {
                ".jpg" or ".jpeg" => "image/jepg",
                ".png" => "image/png",
                ".gif" => "image/gif",
                _ => "application/octet-stream",
            };
        }

        [HttpGet("GetImage/{fileName}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetImage(string fileName)
        {
            string UploadDirctory = @"D:\UploadUserImage";
            string FilePath = Path.Combine(UploadDirctory,fileName);

            if (!Path.Exists(FilePath))
            {
                return NotFound("Image not found");
            }

            var Image = System.IO.File.OpenRead(FilePath);
            var mimetype = GetMimeType(FilePath);

            return File(Image, mimetype);
        }


       

        [HttpPost("AddNewUser")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DTOUserInfo> AddNewUser(DTONewUser newUser)
        {
            Users user = new Users();
            user.FirstName=newUser.FirstName;
            user.LastName=newUser.LastName;
            user.Email=newUser.Email;
            user.Password=newUser.Password;
            user.IsActive= newUser.IsActive;
            user.RoleId=newUser.RoleId;
            user.ProfileImage=newUser.ProfileImage;

            
           if (user.Save())
            {
                DTOUserInfo userInfo=user.DTOUser;
                return CreatedAtRoute("GetUserByID", new { UserId = newUser.UserId }, userInfo);
            }
           else
            {
                return BadRequest("Invalid student data.");
            }

        }

        [HttpPut("UpdateImage/{UserID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult UpdateImage(int UserID, [FromBody]  string ProfileImage)
        {

            if (UserID < 1)
            {
                return BadRequest("Invalid student data.");
            }

            bool user = Users.IsUserExist(UserID);

            if (!user )
            {
                return NotFound($"User with iD {UserID} is not Exist.");
            }

           
            if (Users.UploadImage(UserID, ProfileImage))
            {
                return Ok("Sccessful!.");
            }
            else
            {
                return BadRequest("Invalid student data.");
            }

        }


        [HttpPut("UpdateUser/{UserID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DTOUserInfo> UpdateUser(int UserID,DTONewUser updateUser)
        {

            if (UserID < 1)
            {
                return BadRequest("Invalid student data.");
            }

            Users user = Users.GetUserByID(UserID);

            if (user == null)
            {
                return NotFound($"User with iD {UserID} is not Exist.");
            }

            user.FirstName = updateUser.FirstName;
            user.LastName = updateUser.LastName;
            user.Email = updateUser.Email;
            user.Password = updateUser.Password;
            user.IsActive = updateUser.IsActive;
            user.RoleId = updateUser.RoleId;
            user.ProfileImage = updateUser.ProfileImage;


            if (user.Save())
            {
                DTOUserInfo userInfo = user.DTOUser;
                return Ok(userInfo);
            }
            else
            {
                return BadRequest("Invalid student data.");
            }

        }


        [HttpDelete("DeleteUser{UserID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult DeleteUser(int UserID)
        {
            if (UserID < 1)
            {
                return BadRequest("Invalid User data.");
            }

            bool ISDeleteUser = Users.DeleteUserByID(UserID);

            if (!ISDeleteUser)
            {
                return NotFound($"User With ID {UserID} Not Found.");
            }


            return Ok($"User with id {UserID} has been Delete.");
        }


        [HttpGet("IsUserExist/{UserID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult IsUserExist(int UserID)
        {
            if (UserID < 1)
            {
                return BadRequest("Invalid User data.");
            }

            bool ISExistUser = Users.IsUserExist(UserID);

            if (!ISExistUser)
            {
                return NotFound($"User With ID {UserID} is Not Exist.");
            }


            return Ok($"User with id {UserID} Is Exist.");
        }


        [HttpGet("IsEmailExist/{Email}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult IsEmailExist(string Email)
        {
            if (Email == "")
            {
                return BadRequest("Invalid User data.");
            }

            bool ISExistUser = Users.IsEmailExist(Email);

            if (!ISExistUser)
            {
                return NotFound($"User With Email {Email} is Not Exist.");
            }


            return Ok($"User with Email {Email} Is Exist.");
        }


        [HttpGet("UserIsActive/{UserID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult UserIsActive(int UserID)
        {
            if (UserID < 1)
            {
                return BadRequest("Invalid User data.");
            }

            bool ISExistUser = Users.UserIsActive(UserID);

            if (!ISExistUser)
            {
                return NotFound($"User With ID {UserID} Not Found.");
            }


            return Ok($"User with id {UserID} Is Active.");
        }


        [HttpGet("UserIdIsAdmin/{UserID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult UserIdIsAdmin(int UserID)
        {
            if (UserID < 1)
            {
                return BadRequest("Invalid User data.");
            }

            bool ISExistUser = Users.UserIdIsAdmin(UserID);

            if (!ISExistUser)
            {
                return NotFound($"User With ID {UserID} is not Admin.");
            }


            return Ok($"User with id {UserID} Is Admin.");
        }


        [HttpGet("UserIdIsManager/{UserID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult UserIdIsManager(int UserID)
        {
            if (UserID < 1)
            {
                return BadRequest("Invalid User data.");
            }

            bool ISExistUser = Users.UserIdIsManager(UserID);

            if (!ISExistUser)
            {
                return NotFound($"User With ID {UserID} is Not Manager.");
            }


            return Ok($"User with id {UserID} Is Manager.");
        }


        [HttpGet("UserIdIsEmployee/{UserID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult UserIdIsEmployee(int UserID)
        {
            if (UserID < 1)
            {
                return BadRequest("Invalid User data.");
            }

            bool ISExistUser = Users.UserIdIsEmployee(UserID);

            if (!ISExistUser)
            {
                return NotFound($"User With ID {UserID} is Not Employee.");
            }


            return Ok($"User with id {UserID} Is Employee.");
        }


        [HttpPost("LoginToAccount")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DTOUserInfo> LoginToAccount(DTOLogin loginRequest)
        {
            if (loginRequest.Email == "" || loginRequest.Password == "")
            {
                return BadRequest("Invalid User data.");
            }

            Users User = Users.LoginToAccount(loginRequest.Email, loginRequest.Password);

            if (User ==null )
            {
                return NotFound($"Incorrect email or password.");
            }
            DTOUserInfo fullUserInfo = User.DTOUser;

            return Ok(fullUserInfo);

        }


    }
}
