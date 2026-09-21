using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskBusinessLayer;
using TaskDTOs.DTOsProject;
using TaskDTOs.DTOsUser;

namespace Task_Managment_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectAPIController : ControllerBase
    {
        [HttpGet("GetProjectByID/{ProjectID}", Name = "GetProjectByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DTOProjectInfo> GetProjectByID(int ProjectID)
        {
            if (ProjectID < 1)
            {
                return BadRequest($"this id {ProjectID} is not Accespt.");
            }

            Projects ProjectInfo = Projects.GetProjectByID(ProjectID);

            if (ProjectInfo == null)
            {
                return NotFound($"Project with ID {ProjectID} is not found.");
            }

            DTOProjectInfo fullProjectInfo = ProjectInfo.DTOProject;

            return Ok(fullProjectInfo);
        }


        [HttpGet("GetProjectByTitle/{Title}", Name = "GetProjectByTitle")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DTOProjectInfo> GetProjectByTitle(string Title)
        {
            if (Title == "")
            {
                return BadRequest($"this id {Title} is not Accespt.");
            }

            Projects ProjectInfo = Projects.GetProjectByTitle(Title);

            if (ProjectInfo == null)
            {
                return NotFound($"Project with Title {Title} is not found.");
            }

            DTOProjectInfo fullProjectInfo = ProjectInfo.DTOProject;

            return Ok(fullProjectInfo);
        }


        [HttpGet("GetAllProject/{UserID}", Name = "GetAllProject")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<DTOFullProjectInfo>> GetAllProject(int UserID)
        {
            if (UserID < 1)
            {
                return BadRequest($"this id {UserID} is not Accespt.");
            }

            List<DTOFullProjectInfo> ProjectInfo = Projects.GetAllProject(UserID);

            if (ProjectInfo == null)
            {
                return NotFound($"Project with ID {UserID} is not found.");
            }

            

            return Ok(ProjectInfo);
        }


        [HttpGet("GetAllProjectForManagerID/{MangerID}", Name = "GetAllProjectForManagerID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<DTOFullProjectInfo>> GetAllProjectForManagerID(int MangerID)
        {
            if (MangerID < 1)
            {
                return BadRequest($"this id {MangerID} is not Accespt.");
            }

            List<DTOFullProjectInfo> ProjectInfo = Projects.GetAllProjectForManagerID(MangerID);

            if (ProjectInfo == null)
            {
                return NotFound($"Project with ID {MangerID} is not found.");
            }



            return Ok(ProjectInfo);
        }

        [HttpPost("AddNewProject")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DTOProjectInfo> AddNewProject(DTONewProject newProject)
        {
            Projects project = new Projects();
            project.Title = newProject.Title;
            project.Description = newProject.Description;
            project.MangerID = newProject.MangerID;
           
          

            if (project.Save())
            {
                DTOProjectInfo ProjectInfo = project.DTOProject;
                return CreatedAtRoute("GetProjectByID", new { projectID = ProjectInfo.ProjectID }, ProjectInfo);
            }
            else
            {
                return BadRequest("Invalid Project data.");
            }

        }


        [HttpPut("UpdateProject/{ProjectID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DTOProjectInfo> UpdateProject(int ProjectID, DTONewProject updateProject)
        {

            if (ProjectID < 1)
            {
                return BadRequest("Invalid student data.");
            }

            Projects Project = Projects.GetProjectByID(ProjectID);

            if (Project == null)
            {
                return NotFound($"User with iD {ProjectID} is not Exist.");
            }

            Project.Title = updateProject.Title;
            Project.Description = updateProject.Description;
           


            if (Project.Save())
            {
                DTOProjectInfo ProjectInfo = Project.DTOProject;
                return Ok(ProjectInfo);
            }
            else
            {
                return BadRequest("Invalid Project data.");
            }

        }


        [HttpDelete("DeleteProject/{ProjectID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult DeleteProject(int ProjectID)
        {
            if (ProjectID < 1)
            {
                return BadRequest("Invalid User data.");
            }

            bool ISDeleteProject = Projects.DeleteProjectByID(ProjectID);

            if (!ISDeleteProject)
            {
                return NotFound($"Project With ID {ProjectID} Not Found.");
            }


            return Ok($"Project with id {ProjectID} has been Delete.");
        }


        [HttpGet("IsProjectExist/{ProjectID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult IsProjectExist(int ProjectID)
        {
            if (ProjectID < 1)
            {
                return BadRequest("Invalid Project data.");
            }

            bool ISExistProject = Projects.IsProjectExist(ProjectID);

            if (!ISExistProject)
            {
                return NotFound($"Project With ID {ProjectID} is Not Exist.");
            }


            return Ok($"Project with id {ProjectID} Is Exist.");
        }

        [HttpGet("NumberOfProjects/{UserID}", Name = "NumberOfProjects")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<int> NumberOfProjects(int UserID)
        {
            if (UserID < 1)
            {
                return BadRequest($"this id {UserID} is not Accespt.");
            }

            int Number = Projects.NumberOfProjects(UserID);

            return Ok(Number);
        }

    }
}
