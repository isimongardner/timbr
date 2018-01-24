using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Timbr.Types;
using Timbr.Extensions;

namespace Timbr.Views
{
    public class CreateProjectView
    {
        private ProjectType _projectType;
        private string _projectName;
        private DateTime _projectStartDate;
        private DateTime _projectEstimatedEndDate;

        public CreateProjectView()
        {
            _projectStartDate = DateTime.Now;
            _projectEstimatedEndDate = DateTime.Now;
        }

        public ProjectType SelectedProjectType
        {
            get
            {
                return _projectType;
            }
            set
            {
                _projectType = value;
            }
        }

        public IList<string> ProjectTypes
        {
            get
            {
                return Enum.GetNames(typeof(ProjectType)).Select(b => b.SplitCamelCase()).ToList();
            }
        }

        public string ProjectName
        {
            get
            {
                return _projectName;
            }
            set
            {
                _projectName = value;
            }
        }

        public DateTime ProjectStartDate
        {
            get
            {
                return _projectStartDate;
            }
            set
            {
                _projectStartDate = value;
            }
        }

        public DateTime ProjectEstimatedEndDate
        {
            get
            {
                return _projectEstimatedEndDate;
            }
            set
            {
                _projectEstimatedEndDate = value;
            }
        }
    }
}
