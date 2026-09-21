using CommentDataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TaskDTOs.DTOsComment;
using static Microsoft.Data.SqlClient.Internal.SqlClientEventSource;

namespace TaskBusinessLayer
{
    public class Comments
    {
        public enum enMode { AddNew = 0, UpdateNew = 1 }
        public enMode mode = enMode.AddNew;

        public Comments()
        {
            CommentID = 0;
            Description = "";
            TaskID = 0;
            CreateData = DateTime.Now;

            mode = enMode.AddNew;
        }

        public Comments(DTOCommentInfo commentInfo)
        {
            CommentID = commentInfo.CommentID;
            Description = commentInfo.Description;
            TaskID = commentInfo.TaskID;
            CreateData = commentInfo.CreateData;

            mode = enMode.UpdateNew;
        }

        public int CommentID { get; set; }
        public string Description { get; set; }
        public int TaskID { get; set; }
        public DateTime CreateData { get; set; }

        public  DTOCommentInfo DTOComment
        {
            get { return new DTOCommentInfo(this.CommentID, this.Description, this.TaskID, this.CreateData); }
        }

        DTONewComment DTONewComment
        {
            get {  return new  DTONewComment(this.CommentID ,this.Description ,this.TaskID); }
        }

        public static Comments GetCommentByID(int CommentID)
        {
            DTOCommentInfo commentInfo = CommentData.GetCommentByID(CommentID);
            if (commentInfo != null) {

                return new Comments(commentInfo);
            }
            return null;
        }


        public static List<DTOCommentInfo> GetAllCommentByTaskID(int TaskID)
        {
            return CommentData.GetAllCommentByTaskID(TaskID);
        }


        private  bool AddNewComments()
        {
            this.CommentID=CommentData.AddNewComments(this .DTONewComment);

            return this.CommentID!=-1;
        }

        private  bool UpdateComment()
        {
            return CommentData.UpdateComment(this.DTONewComment);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.AddNew:
                    if (AddNewComments())
                    {
                        mode = enMode.UpdateNew;
                        return true;
                    }
                    else
                        return false;

                case enMode.UpdateNew:
                    return UpdateComment();

            }
            return false;
        }


        public static bool DeleteCommentByID(int CommentID)
        {
            return CommentData.DeleteCommentByID(CommentID);
        }
    }
}
