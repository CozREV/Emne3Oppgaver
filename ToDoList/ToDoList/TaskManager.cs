using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToDoList
{
    internal class TaskManager
    {
        List<TaskItem> items = new List<TaskItem>();

        public void AddItem(TaskItem item)
        {
            items.Add(item);
        }

        public void ShowItem()
        {
            foreach (TaskItem item in items)
            {
                Console.WriteLine($"Tittel: {item.Title}\n" +
                                  $"Beskrivelse: {item.Desc}\n" +
                                  $"Fullført: {item.IsDone}\n");
            }
        }

        public void Completed(string title)
        {
           foreach (TaskItem item in items)
            {
                if (item.Title == title)
                {
                    item.Completed();
                    break;
                }
            }
        }

        public List<TaskItem> GetUncompleted()
        {
            return items.Where(i => i.IsDone == false).ToList();
        }

        public List<TaskItem> Search(string keyword)
        {
            return items.Where(i => i.Title.Contains(keyword)).ToList();
        }

        public int CountCompleted()
        {
            return items.Count(i => i.IsDone == true);
        }
    }
}
