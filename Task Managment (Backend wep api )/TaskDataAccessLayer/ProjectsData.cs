using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskDTOs.DTOsProject;
using TaskDTOs.DTOsUser;

namespace TaskDataAccessLayer
{
    public class ProjectsData
    {

        public static int NumberOfProjects(int UserID)
        {
            int NumberOfProject = -1;

            string SP = @"SP_NumberOfProjects";

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

                        if (Result != null && int.TryParse(Result.ToString(), out int Count))
                        {
                            NumberOfProject = Count;
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
            return NumberOfProject;
        }

        public static List<DTOFullProjectInfo> GetAllProjectForManagerID(int ManagerID)
        {
            List<DTOFullProjectInfo> Projects = new List<DTOFullProjectInfo>();

            string SP = @"SP_GetProjectByManagerID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ManagerID", ManagerID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Projects.Add(new DTOFullProjectInfo(
                                reader.GetInt32(reader.GetOrdinal("ProjectID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetInt32(reader.GetOrdinal("MangerID")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedData"))));
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
            return Projects;
        }

        public static List<DTOFullProjectInfo> GetAllProject(int UserID)
        {
            List<DTOFullProjectInfo> Projects = new List<DTOFullProjectInfo>();

            string SP = @"SP_GetAllProject";

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
                            Projects.Add(new DTOFullProjectInfo(
                                reader.GetInt32(reader.GetOrdinal("ProjectID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetInt32(reader.GetOrdinal("MangerID")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedData"))));
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
            return Projects;
        }

        public static int AddNewProjects(DTONewProject NewProject)
        {
            int ProjectID = -1;

            string SP = @"SP_AddNewProject";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Title", NewProject.Title);
                    command.Parameters.AddWithValue("@Description", NewProject.Description);
                    command.Parameters.AddWithValue("@MangerID", NewProject.MangerID);
                  

                    SqlParameter parameter = new SqlParameter("@ProjectID", SqlDbType.Int)
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
                            ProjectID = (int)command.Parameters["@ProjectID"].Value;
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
            return ProjectID;
        }
        public static bool UpdateProject(DTONewProject NewProject)
        {
            bool IsFound = false;

            string SP = @"SP_UpdateProjectByID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ProjectID", NewProject.ProjectID);
                    command.Parameters.AddWithValue("@Title", NewProject.Title);
                    command.Parameters.AddWithValue("@Description", NewProject.Description);
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
        public static DTOProjectInfo GetProjectByID(int ProjectID)
        {
            DTOProjectInfo Project = new DTOProjectInfo();

            string SP = @"SP_GetProjectByID";

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

                        if (reader.Read())
                        {
                            Project.ProjectID = (int)reader["ProjectID"];
                            Project.Title = (string)reader["Title"];
                            Project.Description = (string)reader["Description"];
                            Project.MangerID = (int)reader["MangerID"];
                            Project.CreatedData = (DateTime)reader["CreatedData"];
                         
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
            return Project;
        }
        public static DTOProjectInfo GetProjectByTitle(string Title)
        {
            DTOProjectInfo Project = new DTOProjectInfo();

            string SP = @"SP_GetProjectByTitle";

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
                            Project.ProjectID = (int)reader["ProjectID"];
                            Project.Title = (string)reader["Title"];
                            Project.Description = (string)reader["Description"];
                            Project.MangerID = (int)reader["MangerID"];
                            Project.CreatedData = (DateTime)reader["CreatedData"];

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
            return Project;
        }
        public static bool IsProjectExist(int ProjectID)
        {
            bool IsFound = false;

            string SP = @"SP_ISExistProjectByID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ProjectID", ProjectID);


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
        public static bool DeleteProjectByID(int ProjectID)
        {
            bool IsFound = false;

            string SP = @"SP_DeleteProjectByID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ProjectID", ProjectID);


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
