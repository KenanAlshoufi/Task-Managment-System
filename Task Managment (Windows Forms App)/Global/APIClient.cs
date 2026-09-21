using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Managment__Windows_Forms_App_.Global
{
    public class APIClient
    {
        public static readonly HttpClient UsersAPI = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7152/api/UsersApi/")
        };

        public static readonly HttpClient TasksAPI = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7152/api/TaskAPI/")
        };


        public static readonly HttpClient ProjectAPI = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7152/api/ProjectAPI/")
        };


    }
}
