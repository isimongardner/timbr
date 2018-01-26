using System;
using System.Collections.Generic;
using System.Text;

namespace Timbr.Views.Items
{
    public class ProjectItem
    {
        private int _id;
        private string _name;
        private DateTime _startDate;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
    }
}
