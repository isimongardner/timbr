using System;
using System.Collections.Generic;
using System.Text;
using Timbr.Views.Items;

namespace Timbr.Views
{
    public class CreateTaskView
    {
        private List<ProjectItem> _projects;
        private ProjectItem _selectedProject;
        private string _taskName;
        private int _numberOfDays;
        private decimal _numberOfHours;

        public CreateTaskView()
        {
            _projects = new List<ProjectItem>();
        }

        public List<ProjectItem> Projects { get => _projects; set => _projects = value; }
        public ProjectItem SelectedProject { get => _selectedProject; set => _selectedProject = value; }
        public string TaskName { get => _taskName; set => _taskName = value; }
        public int NumberOfDays { get => _numberOfDays; set => _numberOfDays = value; }
        public decimal NumberOfHours { get => _numberOfHours; set => _numberOfHours = value; }
        
    }
}
