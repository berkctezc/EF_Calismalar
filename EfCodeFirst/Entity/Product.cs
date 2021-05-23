namespace EfCodeFirst.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string ProductCategory { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        //bir ürünün bir kategorisi olacaktır o yüzden bir category nesnesi cagirdik
        public Category Category { get; set; }
    }
}
