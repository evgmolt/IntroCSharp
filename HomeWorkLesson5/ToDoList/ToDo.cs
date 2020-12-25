using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public ToDo()
        {
        }
        public ToDo(string title, bool isdone)
        {
            Title = title;
            IsDone = isdone;
        }
        public string GetString()
        {
            string s = IsDone ? "[X]" : "[ ]";
            return s + ' ' + Title;
        }
    }
}
