using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace FoodPaySystem
{
    internal class FileManager
    {
        public void SaveFile(List<Order> list)
        {
            string json = JsonSerializer.Serialize(list);
            File.WriteAllText("orders.json", json);
        }

        public List<Order> LoadFile()
        {
            string json = File.ReadAllText("orders.json");
            return JsonSerializer.Deserialize<List<Order>>(json);
        }
    }
}
