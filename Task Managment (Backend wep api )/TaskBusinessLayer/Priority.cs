
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskDataAccessLayer;
using TaskDTOs.DTOsPriority;

namespace TaskBusinessLayer
{
    public class Priority
    {
        public Priority(int priorityID, string name)
        {
            PriorityID = priorityID;
            Name = name;
        }

        public int PriorityID { get; set; }
        public string Name { get; set; }


        public DTOPriorityInfo DTOPriority
        {
            get { return new DTOPriorityInfo(PriorityID, Name); }
        }

        public static Priority GetPriorityByID(int PriorityID)
        {
            string Name = "";
            if (PriorityData.GetPriorityByID(PriorityID, ref Name))
            {
                return new Priority(PriorityID, Name);
            }
            return null;
        }

        public static Priority GetPriorityByName(string Name)
        {
            int PriorityID = -1;
            if (PriorityData.GetPriorityByName(ref PriorityID, Name))
            {
                return new Priority(PriorityID, Name);
            }
            return null;
        }


        public static List<Tuple<int, string>> GetAllPriority()
        {
            return PriorityData.GetAllPriority();
        }
    }
}
