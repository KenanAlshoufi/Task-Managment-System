using StatusDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaskDTOs.DTOsPriority;
using TaskDTOs.DTOsStatus;

namespace TaskBusinessLayer
{
    public  class Status
    {
       
        public Status(int statusID, string name)
        {
            StatusID = statusID;
            Name = name;
        }

        public int StatusID {  get; set; }
        public string  Name {  get; set; }


        public DTOStatusInfo DTOStatus
        {
            get { return new DTOStatusInfo(StatusID, Name); }
        }

        public static Status GetStatusByID(int StatusID)
        {
            string Name = "";
            if (StatusData.GetStatusByID(StatusID, ref Name))
            {
                return new Status(StatusID, Name);
            }
            return null;
        }

        public static Status GetStatusByName( string Name)
        {
            int StatusID =-1;   
            if (StatusData.GetStatusByName(ref StatusID,  Name))
            {
                return new Status(StatusID, Name);
            }
            return null;
        }


        public static List<Tuple<int, string>> GetAllStatus()
        {
            return StatusData.GetAllStatus();
        }

    }
}
