using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDTOs.DTOsPriority
{
    public class DTOPriorityInfo
    {
        public DTOPriorityInfo(int priorityID, string name)
        {
            PriorityID = priorityID;
            Name = name;
        }

        public int PriorityID {  get; set; }

        public string Name { get; set; }

    }
}
