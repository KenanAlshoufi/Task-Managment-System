using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDTOs.DTOsComment
{
    public class DTOCommentInfo
    {
        public DTOCommentInfo() {

            CommentID = 0;
            Description = "";
            TaskID = 0;
            CreateData = DateTime.Now;
        }

        public DTOCommentInfo(int commentID, string description, int taskID, DateTime createData)
        {
            CommentID = commentID;
            Description = description;
            TaskID = taskID;
            CreateData = createData;
        }

        public int CommentID {  get; set; }
        public string Description { get; set; }

        public int TaskID {  get; set; }

        public DateTime CreateData {  get; set; }
    }
}
