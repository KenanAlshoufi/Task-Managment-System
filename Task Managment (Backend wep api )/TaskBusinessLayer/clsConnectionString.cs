using TaskDataAccessLayer;

namespace TaskBusinessLayer
{
    public class clsConnectionString
    {
        private readonly ConnctionString _ConnctionStringdata;

        public clsConnectionString(string connectionString)
        {
            _ConnctionStringdata = new ConnctionString(connectionString);
        }
    }
}
