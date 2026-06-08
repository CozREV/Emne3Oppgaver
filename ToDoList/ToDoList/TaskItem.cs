using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    internal class TaskItem
    {
        public string Title { get; private set; }
        public string Desc { get; private set; }

        public bool IsDone { get; private set; }

        public TaskItem(string title, string desc, bool isDone) 
        {
            Title = title;
            Desc = desc;
            IsDone = isDone;
        }
        public void Completed()
        {
            IsDone = true;
        }
    }
}
