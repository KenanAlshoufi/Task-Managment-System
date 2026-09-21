using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskDTOs.DTOsUser;

namespace TaskDTOs.DTOsProject
{
    public class DTOProjectInfo
    {
        public DTOProjectInfo()
        {
            
        }
        public DTOProjectInfo(int projectID, string title, string description, int mangerID, DateTime createdData, DTOUserInfo userInfo)
        {
            ProjectID = projectID;
            Title = title;
            Description = description;
            MangerID = mangerID;
            CreatedData = createdData;
            DTOUserInfo = userInfo;
        }

        public int ProjectID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int MangerID { get; set; }
        public DateTime CreatedData { get; set; }

        public DTOUserInfo DTOUserInfo { get; set; }
    }
}
