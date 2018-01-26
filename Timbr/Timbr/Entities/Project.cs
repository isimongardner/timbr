using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Timbr.Entities
{
    public class Project
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EstimatedEndDate { get; set; }
    }
}
