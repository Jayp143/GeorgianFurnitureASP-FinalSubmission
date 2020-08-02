using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianFurniture.Models
{
    public class Category
    {
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public string categoryType { get; set; }
        public int storeID { get; set; }

    }
}
