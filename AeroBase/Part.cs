using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace AeroBase.Models
{
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string StorageLocation { get; set; }

        public Part(int id, string name, string category, int quantity, string storageLocation)
        {
            Id = id;
            Name = name;
            Category = category;
            Quantity = quantity;
            StorageLocation = storageLocation;
        }
    }
}
