﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class todoEntities : DbContext
    {
        public todoEntities()
            : base("name=todoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<todo_projects> todo_projects { get; set; }
        public DbSet<todo_statuses> todo_statuses { get; set; }
        public DbSet<todo_todo> todo_todo { get; set; }
        public DbSet<v_todo> v_todo { get; set; }
    }
}