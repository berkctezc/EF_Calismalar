﻿using System.Collections.Generic;

namespace EfCodeFirst.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //bir kategoride çok ürün olacaktır o yüzden collection olarak tuttuk
        public ICollection<Product> Products { get; set; }
    }
}
