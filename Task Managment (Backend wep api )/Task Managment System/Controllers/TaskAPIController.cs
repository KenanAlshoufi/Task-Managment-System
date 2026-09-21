using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TaskBusinessLayer;
using TaskDTOs.DTOsPriority;
using TaskDTOs.DTOsStatus;
using TaskDTOs.DTOsTask;

namespace Task_Managment_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskAPIController : ControllerBase
    {
        [HttpGet("GetAllTaskForManagerID/{CreatedBy}", Name = "GetAllTaskForManagerID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<DTOTaskFullInfo>> GetAllTaskForManagerID(int CreatedBy)
        {
            if (CreatedBy < 1)
            {
                return BadRequest($"this id {CreatedBy} is not Accespt.");
            }

            List<DTOTaskFullInfo> AllTasks = Tasks.GetAllTaskForManagerID(CreatedBy);

            if (AllTasks == null || AllTasks.Count == 0)
            {
                return NotFound($"Tasks with ID {CreatedBy} is not found.");
            }

          
            return Ok(AllTasks);
        }


        [HttpGet("GetAllTaskForManagerIDCompleted/{CreatedBy}", Name = "GetAllTaskForManagerIDCompleted")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<DTOTaskFullInfo>> GetAllTaskForManagerIDCompleted(int CreatedBy)
        {
            if (CreatedBy < 1)
            {
                return BadRequest($"this id {CreatedBy} is not Accespt.");
            }

            List<DTOTaskFullInfo> AllTasks = Tasks.GetAllTaskForManagerIDCompleted(CreatedBy);

            if (AllTasks == null || AllTasks.Count == 0)
            {
                return NotFound($"Tasks with ID {CreatedBy} is not found.");
            }


            return Ok(AllTasks);
        }


        [HttpGet("GetAllTaskForManagerIDCancelled/{CreatedBy}", Name = "GetAllTaskForManagerIDCancelled")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<DTOTaskFullInfo>> GetAllTaskForManagerIDCancelled(int CreatedBy)
        {
            if (CreatedBy < 1)
            {
                return BadRequest($"this id {CreatedBy} is not Accespt.");
            }

            List<DTOTaskFullInfo> AllTasks = Tasks.GetAllTaskForManagerIDCancelled(CreatedBy);

            if (AllTasks == null || AllTasks.Count == 0)
            {
                return NotFound($"Tasks with ID {CreatedBy} is not found.");
            }


            return Ok(AllTasks);
        }



        [HttpGet("GetAllTaskForUserID/{UserID}", Name = "GetAllTaskForUserID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<DTOTaskFullInfo>> GetAllTaskForUserID(int UserID)
        {
            if (UserID < 1)
            {
                return BadRequest($"this id {UserID} is not Accespt.");
            }

            List<DTOTaskFullInfo> AllTasks = Tasks.GetAllTaskForUserID(UserID);

            if (AllTasks == null || AllTasks.Count == 0)
            {
                return NotFound($"Tasks with ID {UserID} is not found.");
            }


            return Ok(AllTasks);
        }


        [HttpGet("GetAllTaskForUserIDCompleted/{UserID}", Name = "GetAllTaskForUserIDCompleted")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<DTOTaskFullInfo>> GetAllTaskForUserIDCompleted(int UserID)
        {
            if (UserID < 1)
            {
                return BadRequest($"this id {UserID} is not Accespt.");
            }

            List<DTOTaskFullInfo> AllTasks = Tasks.GetAllTaskForUserIDCompleted(UserID);

            if (AllTasks == null || AllTasks.Count == 0)
            {
                return NotFound($"Tasks with ID {UserID} is not found.");
            }


            return Ok(AllTasks);
        }


        [HttpGet("GetAllTaskForUserIDCancelled/{UserID}", Name = "GetAllTaskForUserIDCancelled")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<DTOTaskFullInfo>> GetAllTaskForUserIDCancelled(int UserID)
        {
            if (UserID < 1)
            {
                return BadRequest($"this id {UserID} is not Accespt.");
            }

            List<DTOTaskFullInfo> AllTasks = Tasks.GetAllTaskForUserIDCancelled(UserID);

            if (AllTasks == null || AllTasks.Count == 0)
            {
                return NotFound($"Tasks with ID {UserID} is not found.");
            }


            return Ok(AllTasks);
        }


        [HttpGet("GetAllTaskForProjectID/{ProjectID}", Name = "GetAllTaskForProjectID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<DTOTaskFullInfo>> GetAllTaskForProjectID(int ProjectID)
        {
            if (ProjectID < 1)
            {
                return BadRequest($"this id {ProjectID} is not Accespt.");
            }

            List<DTOTaskFullInfo> AllTasks = Tasks.GetAllTaskForProjectID(ProjectID);

            if (AllTasks == null || AllTasks.Count == 0)
            {
                return NotFound($"Tasks with ID {ProjectID} is not found.");
            }


            return Ok(AllTasks);
        }


        [HttpGet("GetAllTaskForProjectIDCompleted/{ProjectID}", Name = "GetAllTaskForProjectIDCompleted")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<DTOTaskFullInfo>> GetAllTaskForProjectIDCompleted(int ProjectID)
        {
            if (ProjectID < 1)
            {
                return BadRequest($"this id {ProjectID} is not Accespt.");
            }

            List<DTOTaskFullInfo> AllTasks = Tasks.GetAllTaskForProjectIDCompleted(ProjectID);

            if (AllTasks == null || AllTasks.Count == 0)
            {
                return NotFound($"Tasks with ID {ProjectID} is not found.");
            }


            return Ok(AllTasks);
        }



        [HttpGet("GetAllTaskForProjectIDCancelled/{ProjectID}", Name = "GetAllTaskForProjectIDCancelled")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<DTOTaskFullInfo>> GetAllTaskForProjectIDCancelled(int ProjectID)
        {
            if (ProjectID < 1)
            {
                return BadRequest($"this id {ProjectID} is not Accespt.");
            }

            List<DTOTaskFullInfo> AllTasks = Tasks.GetAllTaskForProjectIDCancelled(ProjectID);

            if (AllTasks == null || AllTasks.Count == 0)
            {
                return NotFound($"Tasks with ID {ProjectID} is not found.");
            }


            return Ok(AllTasks);
        }


        [HttpGet("GetTaskByTaskID/{TaskID}", Name = "GetTaskByTaskID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DTOTaskInfo> GetTaskByTaskID(int TaskID)
        {
            if (TaskID < 1)
            {
                return BadRequest($"this id {TaskID} is not Accespt.");
            }

            Tasks TaskInfo = Tasks.GetTaskByID(TaskID);

            if (TaskInfo == null)
            {
                return NotFound($"Task with Title {TaskID} is not found.");
            }

            DTOTaskInfo fullTaskInfo = TaskInfo.dTOTask;

            return Ok(fullTaskInfo);
        }

        [HttpGet("GetTaskByTitle/{Title}", Name = "GetTaskByTitle")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DTOTaskInfo> GetTaskByTitle(string Title)
        {
            if (Title == "")
            {
                return BadRequest($"this Title {Title} is not Accespt.");
            }

            Tasks TaskInfo = Tasks.GetTaskByTitle(Title);

            if (TaskInfo == null)
            {
                return NotFound($"Task with Title {Title} is not found.");
            }

            DTOTaskInfo fullTaskInfo = TaskInfo.dTOTask;

            return Ok(fullTaskInfo);
        }


        [HttpGet("NumberOfTasks/{UserID}", Name = "NumberOfTasks")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<int> NumberOfTasks(int UserID)
        {
            if (UserID < 1)
            {
                return BadRequest($"this id {UserID} is not Accespt.");
            }

            int Number = Tasks.NumberOfTasks(UserID);

            return Ok(Number);
        }




        [HttpGet("GetStatusByID/{StatusID}", Name = "GetStatusByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DTOStatusInfo> GetStatusByID(int StatusID)
        {
            if (StatusID < 1)
            {
                return BadRequest($"this id {StatusID} is not Accespt.");
            }

            Status StatusInfo = Status.GetStatusByID(StatusID);

            if (StatusInfo == null)
            {
                return NotFound($"Task with Title {StatusID} is not found.");
            }

            DTOStatusInfo DTOStatusInfo = StatusInfo.DTOStatus;

            return Ok(DTOStatusInfo);
        }


        [HttpGet("GetPriorityByName/{Name}", Name = "GetPriorityByName")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DTOPriorityInfo> GetPriorityByName(string Name)
        {
            if (Name == "")
            {
                return BadRequest($"this id {Name} is not Accespt.");
            }

            Priority PriorityInfo = Priority.GetPriorityByName(Name);

            if (PriorityInfo == null)
            {
                return NotFound($"Task with Title {Name} is not found.");
            }

            DTOPriorityInfo DTOPriorityInfo = PriorityInfo.DTOPriority;

            return Ok(DTOPriorityInfo);
        }


        [HttpPost("AddNewTask")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DTOTaskInfo> AddNewTask(DTONewTask newTask)
        {
            Tasks Task = new Tasks();
            Task.Title = newTask.Title;
            Task.Description = newTask.Description;
            Task.DueDate = newTask.DueDate;
            Task.CreateBy = newTask.CreateBy;
            Task.PriorityID = newTask.PriorityID;
            Task.ProjectID = newTask.ProjectID;
            Task.UserID = newTask.UserID;



            if (Task.Save())
            {
                DTOTaskInfo TaskInfo = Task.dTOTask;
                return CreatedAtRoute("GetTaskByTaskID", new { TaskID = TaskInfo.TaskID }, TaskInfo);
            }
            else
            {
                return BadRequest("Invalid Task data.");
            }

        }


        [HttpPut("UpdateTask/{TaskID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DTOTaskInfo> UpdateTask(int TaskID, DTOUpdateTask updateTask)
        {

            if (TaskID < 1)
            {
                return BadRequest("Invalid student data.");
            }

            Tasks Task = Tasks.GetTaskByID(TaskID);

            if (Task == null)
            {
                return NotFound($"User with iD {TaskID} is not Exist.");
            }

            Task.Title = updateTask.Title;
            Task.Description = updateTask.Description;
            Task.PriorityID = updateTask.PriorityID;
            Task.UserID = updateTask.UserID;
            Task.DueDate = updateTask.DueDate;
           


            if (Task.Save())
            {
                DTOTaskInfo TaskInfo = Task.dTOTask;
                return Ok(TaskInfo);
            }
            else
            {
                return BadRequest("Invalid Task data.");
            }

        }
      
        [HttpGet("IsTaskExist/{TaskID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult IsTaskExist(int TaskID)
        {
            if (TaskID < 1)
            {
                return BadRequest("Invalid Task data.");
            }

            bool ISExistTask = Tasks.IsTaskExist(TaskID);

            if (!ISExistTask)
            {
                return NotFound($"Task With ID {TaskID} is Not Exist.");
            }


            return Ok($"Task with id {TaskID} Is Exist.");
        }




        [HttpPut("TaskIsCompleted/{TaskID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DTOTaskInfo> TaskIsCompleted(int TaskID)
        {

            if (TaskID < 1)
            {
                return BadRequest("Invalid student data.");
            }

            bool IsCompleted = Tasks.TaskIsCompleted(TaskID);

            if (!IsCompleted)
            {
                return NotFound($"User with iD {TaskID} is not Exist.");
            }

             return Ok($"this task {TaskID} has been Completed");
        }


        [HttpPut("TaskIsCancelled/{TaskID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DTOTaskInfo> TaskIsCancelled(int TaskID)
        {

            if (TaskID < 1)
            {
                return BadRequest("Invalid student data.");
            }

            bool IsCancelled = Tasks.TaskIsCancelled(TaskID);

            if (!IsCancelled)
            {
                return NotFound($"User with iD {TaskID} is not Exist.");
            }

            return Ok($"this task {TaskID} has been Cancelled");
        }

        [HttpPut("TaskIsInProgress/{TaskID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DTOTaskInfo> TaskIsInProgress(int TaskID)
        {
            if (TaskID < 1)
            {
                return BadRequest("Invalid student data.");
            }

            bool IsInProgress = Tasks.TaskIsInProgress(TaskID);

            if (!IsInProgress)
            {
                return NotFound($"User with iD {TaskID} is not Exist.");
            }

            return Ok($"this task {TaskID} has been InProgress");
        }


    }
}
