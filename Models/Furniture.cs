using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianFurniture.Models
{
    public class Furniture
    {
        public int furnitureID { get; set; }
        public string furnitureType { get; set; }
        public string color { get; set; }
        public int categoryID { get; set; }
    }
}
