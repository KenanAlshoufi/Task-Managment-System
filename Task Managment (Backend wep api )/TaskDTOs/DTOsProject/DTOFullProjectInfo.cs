using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskDTOs.DTOsUser;

namespace TaskDTOs.DTOsProject
{
    public class DTOFullProjectInfo
    {
        public DTOFullProjectInfo(int projectID, string title, string description, string managername,int managerID, DateTime createdData)
        {
            ProjectID = projectID;
            Title = title;
            Description = description;
            managerName = managername;
            ManagerID = managerID;
            CreatedData = createdData;
        }

        public int ProjectID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string managerName { get; set; }
        public int ManagerID {  get; set; }
        public DateTime CreatedData { get; set; }

        
    }
}
