using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDTOs.DTOsProject
{
    public class DTONewProject
    {
        public DTONewProject(int projectID, string title, string description, int mangerID)
        {
            ProjectID = projectID;
            Title = title;
            Description = description;
            MangerID = mangerID;
        }

        public int ProjectID {  get; set; }
        public string Title {  get; set; }
        public string Description {  get; set; }
        public int MangerID {  get; set; }
    }
}
