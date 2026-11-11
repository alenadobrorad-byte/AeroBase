using System;
using System.Collections.Generic;
using System.Text;

namespace AeroBase.Models
{
    public class Drone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string InventoryNumber { get; set; }
        public string Status { get; set; }

        public Drone(int id, string name, string model, string type, string inventoryNumber, string status)
        {
            Id = id; Name = name; Model = model; Type = type;
            InventoryNumber = inventoryNumber; Status = status;
        }
    }
}

