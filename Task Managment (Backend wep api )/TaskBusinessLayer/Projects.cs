using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TaskDataAccessLayer;
using TaskDTOs.DTOsProject;
using TaskDTOs.DTOsUser;

namespace TaskBusinessLayer
{
    public class Projects
    {
        public enum enMode { AddNew = 0, UpdateNew = 1 }
        public enMode mode = enMode.AddNew;

        private Projects(DTOProjectInfo newProject)
        {
            ProjectID = newProject.ProjectID;
            Title = newProject.Title;
            Description = newProject.Description;
            MangerID = newProject.MangerID;
            CreatedData = newProject.CreatedData;

            ManagerInfo = Users.GetUserByID(MangerID).DTOUser;
            mode = enMode.UpdateNew;
        }
        public Projects()
        {
            ProjectID = -1;
            Title = "";
            Description = "";
            MangerID = 0;
            CreatedData = DateTime.Now;

            mode = enMode.AddNew;
        }
        public DTOUserInfo ManagerInfo { get; set; }
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int MangerID { get; set; }
        public DateTime CreatedData { get; set; }

        public DTONewProject DTONewProject
        {
            get
            {
                return new DTONewProject(this.ProjectID, this.Title, this.Description, this.MangerID);
            }
        }

        public DTOProjectInfo DTOProject
        {
            get
            {
                return new DTOProjectInfo(this.ProjectID, this.Title, this.Description, 
                    this.MangerID, this.CreatedData,this.ManagerInfo);
            }
        }


        public static List<DTOFullProjectInfo> GetAllProjectForManagerID(int ManagerID)
        {
            return ProjectsData.GetAllProjectForManagerID(ManagerID);
        }

        public static List<DTOFullProjectInfo> GetAllProject(int UserID)
        {
            return ProjectsData.GetAllProject(UserID);
        }
        public bool AddNewProjects(DTONewProject NewProject)
        {
            if (Users.UserIdIsEmployee(NewProject.MangerID))
            {
                return false;
            }

            this.ProjectID = ProjectsData.AddNewProjects(NewProject);

            return this.ProjectID != -1;
        }


        public bool UpdateProject(DTONewProject NewProject)
        {
            if (Users.UserIdIsEmployee(NewProject.MangerID))
            {
                return false;
            }
            return ProjectsData.UpdateProject(NewProject);
        }


        public bool Save()
        {
            switch (mode)
            {
                case enMode.AddNew:
                    if (AddNewProjects(this.DTONewProject))
                    {
                        return true;
                    }
                    return false;

                case enMode.UpdateNew:
                    return UpdateProject(this.DTONewProject);
            }
            return false;
        }

        public static Projects GetProjectByID(int ProjectID)
        {
            DTOProjectInfo projectInfo = ProjectsData.GetProjectByID(ProjectID);
            if (projectInfo != null)
            {
                return new Projects(projectInfo);
            }
            return null;
        }

        public static Projects GetProjectByTitle(string Title)
        {
            DTOProjectInfo projectInfo = ProjectsData.GetProjectByTitle(Title);
            if (projectInfo != null)
            {
                return new Projects(projectInfo);
            }
            return null;
        }

        public static bool IsProjectExist(int ProjectID)
        {
            return ProjectsData.IsProjectExist(ProjectID);
        }

        public static bool DeleteProjectByID(int ProjectID)
        {
            return ProjectsData.DeleteProjectByID(ProjectID);
        }


        public static int NumberOfProjects(int UserID)
        {
            return ProjectsData.NumberOfProjects(UserID);
        }

    }
}
