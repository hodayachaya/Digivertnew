﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<file> file { get; set; }
        public virtual DbSet<project> project { get; set; }
        public virtual DbSet<Table1> Table1 { get; set; }
        public virtual DbSet<users> users { get; set; }
        public DbSet<T> GetDbSet<T>() where T : class
        {
            return this.Set<T>();
        }
    }

   

}
