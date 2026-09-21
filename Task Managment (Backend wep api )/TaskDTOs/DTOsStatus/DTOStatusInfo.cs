using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDTOs.DTOsStatus
{
    public class DTOStatusInfo
    {
        public DTOStatusInfo(int statusID, string name)
        {
            StatusID = statusID;
            Name = name;
        }

        public int StatusID { get; set; }

        public string Name { get; set; }
    }
}
