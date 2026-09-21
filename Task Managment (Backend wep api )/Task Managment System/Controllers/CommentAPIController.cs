using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskBusinessLayer;
using TaskDTOs.DTOsComment;

namespace Task_Managment_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentAPIController : ControllerBase
    {
        [HttpGet("GetCommentByID/{CommentID}", Name = "GetCommentByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DTOCommentInfo> GetCommentByID(int CommentID)
        {
            if (CommentID < 1)
            {
                return BadRequest($"this id {CommentID} is not Accespt.");
            }

            Comments CommentInfo = Comments.GetCommentByID(CommentID);

            if (CommentInfo == null)
            {
                return NotFound($"Comment with ID {CommentID} is not found.");
            }

            DTOCommentInfo fullCommentInfo = CommentInfo.DTOComment;

            return Ok(fullCommentInfo);
        }


        

        [HttpGet("GetAllCommentByTaskID/{TaskID}", Name = "GetAllCommentByTaskID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<DTOCommentInfo>> GetAllCommentByTaskID(int TaskID)
        {
            if (TaskID < 1)
            {
                return BadRequest($"this id {TaskID} is not Accespt.");
            }

            List<DTOCommentInfo> CommentInfo = Comments.GetAllCommentByTaskID(TaskID);

            if (CommentInfo == null)
            {
                return NotFound($"Comment with ID {TaskID} is not found.");
            }



            return Ok(CommentInfo);
        }


        [HttpPost("AddComment")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DTOCommentInfo> AddNewComment(DTONewComment newComment)
        {
            Comments Comment = new Comments();
            Comment.Description = newComment.Description;
            Comment.TaskID = newComment.TaskID;
           
            if (Comment.Save())
            {
                DTOCommentInfo CommentInfo = Comment.DTOComment;
                return CreatedAtRoute("GetCommentByID", new { CommentID = CommentInfo.CommentID }, CommentInfo);
            }
            else
            {
                return BadRequest("Invalid Comment data.");
            }

        }


        [HttpPut("UpdateComment/{CommentID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DTOCommentInfo> UpdateComment(int CommentID, DTONewComment updateComment)
        {

            if (CommentID < 1)
            {
                return BadRequest("Invalid student data.");
            }

            Comments Comment = Comments.GetCommentByID(CommentID);

            if (Comment == null)
            {
                return NotFound($"User with iD {CommentID} is not Exist.");
            }

            Comment.Description = updateComment.Description;
            Comment.TaskID = updateComment.TaskID;




            if (Comment.Save())
            {
                DTOCommentInfo CommentInfo = Comment.DTOComment;
                return Ok(CommentInfo);
            }
            else
            {
                return BadRequest("Invalid Comment data.");
            }

        }


        [HttpDelete("DeleteComment/{CommentID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult DeleteComment(int CommentID)
        {
            if (CommentID < 1)
            {
                return BadRequest("Invalid User data.");
            }

            bool ISDeleteComment = Comments.DeleteCommentByID(CommentID);

            if (!ISDeleteComment)
            {
                return NotFound($"Comment With ID {CommentID} Not Found.");
            }


            return Ok($"Comment with id {CommentID} has been Delete.");
        }



    }
}
