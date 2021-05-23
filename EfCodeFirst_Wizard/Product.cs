namespace EfCodeFirst_Wizard
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public int? Stock { get; set; }

        public string ProductCategory { get; set; }

        public string Description { get; set; }

        public int? Category_Id { get; set; }

        public virtual Category Category { get; set; }
    }
}
