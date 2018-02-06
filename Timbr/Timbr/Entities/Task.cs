using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Timbr.Entities
{
    public class Task
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public int NumberOfHours { get; set; }
        public int NumberOfDays { get; set; }
    }
}
