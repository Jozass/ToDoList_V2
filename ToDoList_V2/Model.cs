using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList_V2;

namespace ToDoList_V2
{
    public class Model
    {
        public string Aufgabe { get; set; }

        public bool Erledigt { get; set; }

        public string Deadline { get; set; }

        public string Erstellungsdatum { get; set; }

        public string Notizen { get; set; }

        public int ToDoID { get; set; }
        public string UserID { get; set; }
    }
}
