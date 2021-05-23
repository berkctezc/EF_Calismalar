using System.Data.Entity;

namespace EfCodeFirst.Entity
{
    /* CodeFirst Aşamaları
     * EF yüklenir, Entityler oluşturulur
     * Context oluşturulur ve entityler ile bağlamalar yapılır
     * appconfig/ webconfigde connectrionstrings>add parametreleri eklenir
     * enable-migrations , add-migration , update-database
     */
   public class Context:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
