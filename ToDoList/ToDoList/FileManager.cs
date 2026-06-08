using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ToDoList
{
    internal class FileManager
    {
        public void SaveFile(List<TaskItem> list)
        {
            string json = JsonSerializer.Serialize(list);
            File.WriteAllText("tasks.json", json);
        } 

        public List<TaskItem> LoadFile()
        {
            string json = File.ReadAllText("tasks.json");
            List<TaskItem> list = JsonSerializer.Deserialize<List<TaskItem>>(json);
            return list;
        }
    }
}
