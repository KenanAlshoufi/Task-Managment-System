using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaskDTOs.DTOsComment;
using TaskDataAccessLayer;

namespace CommentDataAccessLayer
{
    public class CommentData
    {
        public static DTOCommentInfo GetCommentByID(int CommentID)
        {
            DTOCommentInfo commentInfo = new DTOCommentInfo();

            string SP = @"SP_GetCommentByID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CommentID", CommentID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            commentInfo.CommentID = (int)reader["CommentID"];
                            commentInfo.Description = (string)reader["Description"];
                            commentInfo.TaskID = (int)reader["TaskID"];
                            commentInfo.CreateData = (DateTime)reader["CreatedData"];

                        

                        }
                        else
                        {
                           return null;
                        }

                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
            return commentInfo;
        }

        public static List <DTOCommentInfo> GetAllCommentByTaskID(int TaskID)
        {
            List<DTOCommentInfo> ALLcommentInfo = new List<DTOCommentInfo>();

            string SP = @"SP_GetAllCommentByTaskID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TaskID", TaskID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {

                            ALLcommentInfo.Add(new DTOCommentInfo
                                (
                                    reader.GetInt32(reader.GetOrdinal("CommentID")),
                                    reader.GetString(reader.GetOrdinal("Description")),
                                    reader.GetInt32(reader.GetOrdinal("TaskID")),
                                    reader.GetDateTime(reader.GetOrdinal("CreatedData")))
                                );
                        }
                        

                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
            return ALLcommentInfo;
        }

        public static int AddNewComments(DTONewComment NewComment)
        {
            int CommentID = -1;

            string SP = @"SP_AddNewComment";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Description", NewComment.Description);
                    command.Parameters.AddWithValue("@TaskID", NewComment.TaskID);

                   
                    SqlParameter parameter = new SqlParameter("@CommentID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(parameter);

                    try
                    {
                        connection.Open();


                        int Result = command.ExecuteNonQuery();

                        if (Result > 0)
                        {
                            CommentID = (int)command.Parameters["@CommentID"].Value;
                        }

                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
            return CommentID;
        }

        public static bool UpdateComment(DTONewComment NewComment)
        {
            bool IsFound = false;

            string SP = @"SP_UpdateCommentByID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CommentID", NewComment.CommentID);
                    command.Parameters.AddWithValue("@Description", NewComment.Description);
                    command.Parameters.AddWithValue("@TaskID", NewComment.TaskID);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            IsFound = true;
                        }


                    }
                    catch (Exception ex)
                    {
                        IsFound = false;
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
            return IsFound;
        }

        public static bool DeleteCommentByID(int CommentID)
        {
            bool IsFound = false;

            string SP = @"SP_DeleteCommentByID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CommentID", CommentID);


                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            IsFound = true;
                        }


                    }
                    catch (Exception ex)
                    {
                        IsFound = false;
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
            return IsFound;
        }

    }
}
