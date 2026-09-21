using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using TaskDTOs.DTOsTask;
using TaskDTOs.DTOsUser;

namespace TaskDataAccessLayer
{
    public class UsersData
    {

        public static List<DTOFullUserInfo> GetAllUser()
        {
            List<DTOFullUserInfo> Users = new List<DTOFullUserInfo>();

            string SP = @"SP_GetAllUser";

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
                            Users.Add(new DTOFullUserInfo(
                                reader.GetInt32(reader.GetOrdinal("UserID")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetString(reader.GetOrdinal("Email")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetBoolean(reader.GetOrdinal("IsActive"))));
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
            return Users;
        }

        public static  DTOUserInfo GetUserByID(int UserID)
        {
            DTOUserInfo Users=new DTOUserInfo();

            string SP = @"SP_GetUserByID";

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

                        if (reader.Read())
                        {
                            Users.UserId = (int)reader["UserID"];
                            Users.FirstName = (string )reader["FirstName"];
                            Users.LastName = (string)reader["LastName"];
                            Users.Email = (string)reader["Email"];
                            Users.IsActive = (bool)reader["IsActive"];
                            Users.ProfileImage = reader["ProfileImage"] !=DBNull.Value ? (string)reader["ProfileImage"] : null;
                            Users.RoleId = (int)reader["RoleID"];
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
            return Users;
        }

        public static DTOUserInfo GetUserByName(string FullName)
        {
            DTOUserInfo Users = new DTOUserInfo();

            string SP = @"SP_GetUserByName";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FullName", FullName);
                   
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            Users.UserId = (int)reader["UserID"];
                            Users.FirstName = (string)reader["LastName"];
                            Users.LastName = (string)reader["FirstName"];
                            Users.Email = (string)reader["Email"];
                            Users.IsActive = (bool)reader["IsActive"];
                            Users.ProfileImage = reader["ProfileImage"] != DBNull.Value ? (string)reader["ProfileImage"] : null;
                            Users.RoleId = (int)reader["RoleID"];
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
            return Users;
        }

        public static DTOUserInfo GetUserByEamil(string Email)
        {
            DTOUserInfo Users = new DTOUserInfo();

            string SP = @"SP_GetUserByEamil";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Email", Email);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            Users.UserId = (int)reader["UserID"];
                            Users.FirstName = (string)reader["LastName"];
                            Users.LastName = (string)reader["FirstName"];
                            Users.Email = (string)reader["Email"];
                            Users.IsActive = (bool)reader["IsActive"];
                            Users.ProfileImage = reader["ProfileImage"] != DBNull.Value ? (string)reader["ProfileImage"] : null;
                            Users.RoleId = (int)reader["RoleID"];
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
            return Users;
        }

        public static int AddNewUsers(DTONewUser NewUser)
        {
            int UserID = -1;

            string SP = @"SP_AddNewUser";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", NewUser.FirstName);
                    command.Parameters.AddWithValue("@LastName", NewUser.LastName);
                    command.Parameters.AddWithValue("@Email", NewUser.Email);
                    command.Parameters.AddWithValue("@Password", NewUser.Password);
                    command.Parameters.AddWithValue("@RoleId", NewUser.RoleId);
                    command.Parameters.AddWithValue("@IsActive", NewUser.IsActive);
                    command.Parameters.AddWithValue("@ProfileImage",(object)NewUser.ProfileImage ?? DBNull.Value );

                    SqlParameter parameter = new SqlParameter("@UserID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(parameter);

                    try
                    {
                        connection.Open();

                        
                        int Result = command.ExecuteNonQuery();

                        if (Result > 0 )
                        {
                           UserID= (int)command.Parameters["@UserID"].Value;
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
            return UserID;
        }

        public static bool UpdateUser(DTONewUser NewUser)
        {
            bool IsFound = false;

            string SP = @"SP_UpdateUser";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", NewUser.UserId);
                    command.Parameters.AddWithValue("@FirstName", NewUser.FirstName);
                    command.Parameters.AddWithValue("@LastName", NewUser.LastName);
                    command.Parameters.AddWithValue("@Email", NewUser.Email);
                    command.Parameters.AddWithValue("@Password", NewUser.Password);
                    command.Parameters.AddWithValue("@RoleId", NewUser.RoleId);
                    command.Parameters.AddWithValue("@IsActive", NewUser.IsActive);
                    command.Parameters.AddWithValue("@ProfileImage", (object)NewUser.ProfileImage ?? DBNull.Value);

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

        public static bool UploadImage(int UserID,string ProfileImage)
        {
            bool IsFound = false;

            string SP = @"SP_UploadImage";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);
                
                    command.Parameters.AddWithValue("@ProfileImage", (object)ProfileImage ?? DBNull.Value);

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

        public static DTOUserInfo LoginToAccount(string Email ,ref  string Password)
        {

            DTOUserInfo Users = new DTOUserInfo();

            string SP = @"SP_LoginToAccount";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Email", Email);
                  

                    try
                    {
                        connection.Open();
              
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            Users.UserId = (int)reader["UserID"];
                            Users.FirstName = (string)reader["FirstName"];
                            Users.LastName = (string)reader["LastName"];
                            Users.Email = (string)reader["Email"];
                            Password = (string)reader["Password"];
                            Users.IsActive = (bool)reader["IsActive"];
                            Users.ProfileImage = reader["ProfileImage"] != DBNull.Value ? (string)reader["ProfileImage"] : null;
                            Users.RoleId = (int)reader["RoleID"];
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
            return Users;
        }

        public static bool DeleteUserByID(int UserID)
        {
            bool IsFound = false;

            string SP = @"SP_DeleteUserByID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);


                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0 )
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

        public static bool IsUserExist(int UserID)
        {
            bool IsFound = false;

            string SP = @"SP_ISExistUserByID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);


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

        public static bool IsEmailExist(string Email)
        {
            bool IsFound = false;

            string SP = @"SP_IsEmailExist";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Email", Email);


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

        public static bool UserIdIsAdmin(int UserID)
        {
            bool IsFound = false;

            string SP = @"SP_UserIdIsAdmin";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);
                    

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

        public static bool UserIdIsManager(int UserID)
        {
            bool IsFound = false;

            string SP = @"SP_UserIdIsManager";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);


                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null )
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

        public static bool UserIdIsEmployee(int UserID)
        {
            bool IsFound = false;

            string SP = @"SP_UserIdIsEmployee";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);


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

        public static bool UserIsActive(int UserID)
        {
            bool IsFound = false;

            string SP = @"SP_UserIsActive";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);


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
