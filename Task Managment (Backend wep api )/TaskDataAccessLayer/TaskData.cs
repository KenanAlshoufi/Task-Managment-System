using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskDTOs.DTOsTask;

namespace TaskDataAccessLayer
{
    public class TaskData
    {

        public static int NumberOfTasks(int UserID)
        {
            int NumberOfTask = -1;

            string SP = @"SP_NumberOfTasks";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                   
                    command.Parameters.AddWithValue("@UserID", UserID);
                

                    try
                    {
                        connection.Open();


                        object Result = command.ExecuteScalar();

                        if (Result !=null && int.TryParse(Result.ToString(),out int Count))
                        {
                            NumberOfTask = Count;
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
            return NumberOfTask;
        }

        public static List<DTOTaskFullInfo> GetAllTask()
        {
            List<DTOTaskFullInfo> Tasks = new List<DTOTaskFullInfo>();

            string SP = @"SP_GetAllTask";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Tasks.Add(new DTOTaskFullInfo(
                                reader.GetInt32(reader.GetOrdinal("TaskID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetString(reader.GetOrdinal("Project")),
                                reader.GetString(reader.GetOrdinal("Status")),
                                reader.GetString(reader.GetOrdinal("CreatedBy")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedData")),
                                reader.GetDateTime(reader.GetOrdinal("DueData"))));
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
            return Tasks;
        }
        public static List<DTOTaskFullInfo> GetAllTaskCancelled()
        {
            List<DTOTaskFullInfo> Tasks = new List<DTOTaskFullInfo>();

            string SP = @"SP_GetAllTaskCancelled";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                  
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Tasks.Add(new  DTOTaskFullInfo(
                                reader.GetInt32(reader.GetOrdinal("TaskID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetString(reader.GetOrdinal("Project")),
                                reader.GetString(reader.GetOrdinal("Status")),
                                reader.GetString(reader.GetOrdinal("CreatedBy")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedData")),
                                reader.GetDateTime(reader.GetOrdinal("DueData"))));
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
            return Tasks;
        }
        public static List<DTOTaskFullInfo> GetAllTaskCompleted()
        {
            List<DTOTaskFullInfo> Tasks = new List<DTOTaskFullInfo>();

            string SP = @"SP_GetAllTaskCompleted";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                 

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Tasks.Add(new DTOTaskFullInfo(
                                reader.GetInt32(reader.GetOrdinal("TaskID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetString(reader.GetOrdinal("Project")),
                                reader.GetString(reader.GetOrdinal("Status")),
                                reader.GetString(reader.GetOrdinal("CreatedBy")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedData")),
                                reader.GetDateTime(reader.GetOrdinal("DueData"))));
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
            return Tasks;
        }


        public static List<DTOTaskFullInfo> GetAllTaskForManagerID(int CreatedBy)
        {
            List<DTOTaskFullInfo> Tasks = new List<DTOTaskFullInfo>();

            string SP = @"SP_GetAllTaskForManagerID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CreatedBy", CreatedBy);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                           

                            Tasks.Add(new DTOTaskFullInfo(
                                reader.GetInt32(reader.GetOrdinal("TaskID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetString(reader.GetOrdinal("Project")),
                                reader.GetString(reader.GetOrdinal("Status")),
                                reader.GetString(reader.GetOrdinal("CreatedBy")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedData")),
                                reader.GetDateTime(reader.GetOrdinal("DueData"))));
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
            return Tasks;
        }
        public static List<DTOTaskFullInfo> GetAllTaskForManagerIDCancelled(int CreatedBy)
        {
            List<DTOTaskFullInfo> Tasks = new List<DTOTaskFullInfo>();

            string SP = @"SP_GetAllTaskForManagerIDCancelled";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CreatedBy", CreatedBy);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Tasks.Add(new DTOTaskFullInfo(
                                reader.GetInt32(reader.GetOrdinal("TaskID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetString(reader.GetOrdinal("Project")),
                                reader.GetString(reader.GetOrdinal("Status")),
                                reader.GetString(reader.GetOrdinal("CreatedBy")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedData")),
                                reader.GetDateTime(reader.GetOrdinal("DueData"))));
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
            return Tasks;
        }
        public static List<DTOTaskFullInfo> GetAllTaskForManagerIDCompleted(int CreatedBy)
        {
            List<DTOTaskFullInfo> Tasks = new List<DTOTaskFullInfo>();

            string SP = @"SP_GetAllTaskForManagerIDCompleted";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CreatedBy", CreatedBy);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Tasks.Add(new DTOTaskFullInfo(
                                reader.GetInt32(reader.GetOrdinal("TaskID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetString(reader.GetOrdinal("Project")),
                                reader.GetString(reader.GetOrdinal("Status")),
                                reader.GetString(reader.GetOrdinal("CreatedBy")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedData")),
                                reader.GetDateTime(reader.GetOrdinal("DueData"))));
                        }

                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                  

                }
            }
            return Tasks;
        }

        public static List<DTOTaskFullInfo> GetAllTaskForUserID(int UserID)
        {
            List<DTOTaskFullInfo> Tasks = new List<DTOTaskFullInfo>();

            string SP = @"SP_GetAllTaskForUserID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Tasks.Add(new DTOTaskFullInfo(
                                reader.GetInt32(reader.GetOrdinal("TaskID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetString(reader.GetOrdinal("Project")),
                                reader.GetString(reader.GetOrdinal("Status")),
                                reader.GetString(reader.GetOrdinal("CreatedBy")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedData")),
                                reader.GetDateTime(reader.GetOrdinal("DueData"))));
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
            return Tasks;
        }
        public static List<DTOTaskFullInfo> GetAllTaskForUserIDCancelled(int UserID)
        {
            List<DTOTaskFullInfo> Tasks = new List<DTOTaskFullInfo>();

            string SP = @"SP_GetAllTaskForUserIDCancelled";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Tasks.Add(new DTOTaskFullInfo(
                                reader.GetInt32(reader.GetOrdinal("TaskID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetString(reader.GetOrdinal("Project")),
                                reader.GetString(reader.GetOrdinal("Status")),
                                reader.GetString(reader.GetOrdinal("CreatedBy")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedData")),
                                reader.GetDateTime(reader.GetOrdinal("DueData"))));
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
            return Tasks;
        }
        public static List<DTOTaskFullInfo> GetAllTaskForUserIDCompleted(int UserID)
        {
            List<DTOTaskFullInfo> Tasks = new List<DTOTaskFullInfo>();

            string SP = @"SP_GetAllTaskForUserIDCompleted";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Tasks.Add(new DTOTaskFullInfo(
                                reader.GetInt32(reader.GetOrdinal("TaskID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetString(reader.GetOrdinal("Project")),
                                reader.GetString(reader.GetOrdinal("Status")),
                                reader.GetString(reader.GetOrdinal("CreatedBy")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedData")),
                                reader.GetDateTime(reader.GetOrdinal("DueData"))));
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
            return Tasks;
        }

        public static List<DTOTaskFullInfo> GetAllTaskForProjectID(int ProjectID)
        {
            List<DTOTaskFullInfo> Tasks = new List<DTOTaskFullInfo>();

            string SP = @"SP_GetAllTaskForProjectID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ProjectID", ProjectID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Tasks.Add(new DTOTaskFullInfo(
                                reader.GetInt32(reader.GetOrdinal("TaskID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetString(reader.GetOrdinal("Project")),
                                reader.GetString(reader.GetOrdinal("Status")),
                                reader.GetString(reader.GetOrdinal("CreatedBy")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedData")),
                                reader.GetDateTime(reader.GetOrdinal("DueData"))));
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
            return Tasks;
        }
        public static List<DTOTaskFullInfo> GetAllTaskForProjectIDCancelled(int ProjectID)
        {
            List<DTOTaskFullInfo> Tasks = new List<DTOTaskFullInfo>();

            string SP = @"SP_GetAllTaskForProjectIDCancelled";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ProjectID", ProjectID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Tasks.Add(new DTOTaskFullInfo(
                                reader.GetInt32(reader.GetOrdinal("TaskID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetString(reader.GetOrdinal("Project")),
                                reader.GetString(reader.GetOrdinal("Status")),
                                reader.GetString(reader.GetOrdinal("CreatedBy")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedData")),
                                reader.GetDateTime(reader.GetOrdinal("DueData"))));
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
            return Tasks;
        }
        public static List<DTOTaskFullInfo> GetAllTaskForProjectIDCompleted(int ProjectID)
        {
            List<DTOTaskFullInfo> Tasks = new List<DTOTaskFullInfo>();

            string SP = @"SP_GetAllTaskForProjectIDCompleted";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ProjectID", ProjectID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Tasks.Add(new DTOTaskFullInfo(
                                reader.GetInt32(reader.GetOrdinal("TaskID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetString(reader.GetOrdinal("Project")),
                                reader.GetString(reader.GetOrdinal("Status")),
                                reader.GetString(reader.GetOrdinal("CreatedBy")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedData")),
                                reader.GetDateTime(reader.GetOrdinal("DueData"))));
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
            return Tasks;
        }

        public static DTOTaskInfo GetTaskByID(int TaskID)
        {
            DTOTaskInfo Task = new DTOTaskInfo();

            string SP = @"SP_GetTaskByID";

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

                        if (reader.Read())
                        {
                            Task.TaskID = (int)reader["TaskID"];
                            Task.Title = (string)reader["Title"];
                            Task.Description = (string)reader["Description"];
                            Task.StatusID = (int)reader["StatusID"];
                            Task.PriorityID = (int)reader["PriorityID"];
                            Task.CreateBy = (int)reader["CreatedBy"];
                            Task.ProjectID = (int)reader["ProjectID"];
                            Task.UserID = (int)reader["UserID"];
                            Task.CreateData = (DateTime)reader["CreatedData"];
                            Task.DueDate = (DateTime)reader["DueData"];

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
            return Task;
        }
        public static DTOTaskInfo GetTaskByTitle(string Title)
        {
            DTOTaskInfo Task = new DTOTaskInfo();

            string SP = @"SP_GetTaskByTitle";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Title", Title);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            Task.TaskID = (int)reader["TaskID"];
                            Task.Title = (string)reader["Title"];
                            Task.Description = (string)reader["Description"];
                            Task.StatusID = (int)reader["StatusID"];
                            Task.PriorityID = (int)reader["PriorityID"];
                            Task.CreateBy = (int)reader["CreatedBy"];
                            Task.ProjectID = (int)reader["ProjectID"];
                            Task.UserID = (int)reader["UserID"];
                            Task.CreateData = (DateTime)reader["CreatedData"];
                            Task.DueDate = (DateTime)reader["DueData"];

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
            return Task;
        }
        public static int AddNewTasks(DTONewTask NewTask)
        {
            int TaskID = -1;

            string SP = @"SP_AddNewTask";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Title", NewTask.Title);
                    command.Parameters.AddWithValue("@Description", NewTask.Description);
                    command.Parameters.AddWithValue("@PriorityID", NewTask.PriorityID);
                    command.Parameters.AddWithValue("@UserID", NewTask.UserID);
                    command.Parameters.AddWithValue("@ProjectID", NewTask.ProjectID);
                    command.Parameters.AddWithValue("@CreatedBy", NewTask.CreateBy);
                    command.Parameters.AddWithValue("@DueData", NewTask.DueDate);


                    SqlParameter parameter = new SqlParameter("@TaskID", SqlDbType.Int)
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
                            TaskID = (int)command.Parameters["@TaskID"].Value;
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
            return TaskID;
        }
        public static bool UpdateTask(DTOUpdateTask NewTask)
        {
            bool IsFound = false;

            string SP = @"SP_UpdateTaskByID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TaskID", NewTask.TaskID);
                    command.Parameters.AddWithValue("@Title", NewTask.Title);
                    command.Parameters.AddWithValue("@Description", NewTask.Description);
                    command.Parameters.AddWithValue("@PriorityID", NewTask.PriorityID);
                    command.Parameters.AddWithValue("@UserID", NewTask.UserID);
                    command.Parameters.AddWithValue("@DueData", NewTask.DueDate);

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

        public static bool TaskIsCompleted(int TaskID)
        {
            bool IsFound = false;

            string SP = @"SP_TaskIsCompleted";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TaskID", TaskID);
                  

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

        public static bool TaskIsCancelled(int TaskID)
        {
            bool IsFound = false;

            string SP = @"SP_TaskIsCancelled";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TaskID", TaskID);


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

        public static bool TaskIsInProgress(int TaskID)
        {
            bool IsFound = false;

            string SP = @"SP_TaskIsInProgress";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TaskID", TaskID);


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

        public static bool IsTaskExist(int TaskID)
        {
            bool IsFound = false;

            string SP = @"SP_IsTaskExist";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TaskID", TaskID);


                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
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
