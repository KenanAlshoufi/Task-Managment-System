using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDTOs.DTOsComment
{
    public class DTONewComment
    {
        public DTONewComment()
        {
            CommentID = 0;
            Description = "";
            TaskID = 0;
        }

        public DTONewComment(int commentID, string description, int taskID)
        {
            CommentID = commentID;
            Description = description;
            TaskID = taskID;
        }

        public int CommentID { get; set; }
        public string Description { get; set; }
        public int TaskID { get; set; }
    }
}
