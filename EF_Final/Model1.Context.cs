﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_Final
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbOgrenciSinavEntities : DbContext
    {
        public DbOgrenciSinavEntities()
            : base("name=DbOgrenciSinavEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_clubs> tbl_clubs { get; set; }
        public virtual DbSet<tbl_grades> tbl_grades { get; set; }
        public virtual DbSet<tbl_lessons> tbl_lessons { get; set; }
        public virtual DbSet<tbl_students> tbl_students { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    
        public virtual ObjectResult<clubs_Result> clubs()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<clubs_Result>("clubs");
        }
    }
}
