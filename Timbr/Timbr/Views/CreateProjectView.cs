using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Timbr.Extensions;
using Timbr.Services;
using Timbr.Types;

namespace Timbr.Views
{
    public class CreateProjectView : ApplicationView, INotifyPropertyChanged
    {
        private readonly IProjectService _projectService;
        public string ProjectName { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime ProjectEstimatedEndDate { get; set; }
        public ProjectType SelectedProjectType { get; set; }

        public IList<string> ProjectTypes
        {
            get
            {
                return Enum.GetNames(typeof(ProjectType)).Select(b => b.SplitCamelCase()).ToList();
            }
        }

        public CreateProjectView(IProjectService projectService)
        {
            _projectService = projectService;

            ProjectStartDate = DateTime.Now;
            ProjectEstimatedEndDate = DateTime.Now;
        }

        public void CreateProject()
        {
            _projectService.CreateProject(ProjectName, ProjectStartDate, ProjectEstimatedEndDate);
        }
    }
}
