﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace database.mysql
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class todosEntities : DbContext
    {
        public todosEntities()
            : base("name=todosEntities")
            //: base("server=localhost;user id=root;database=awesome_todos")
    		//: base(Libraries.MySQL.ConnectionStringHelper.cs())
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<todo_events> todo_events { get; set; }
        public DbSet<todo_logs> todo_logs { get; set; }
        public DbSet<todo_projects> todo_projects { get; set; }
        public DbSet<todo_projects_todos> todo_projects_todos { get; set; }
        public DbSet<todo_statuses> todo_statuses { get; set; }
        public DbSet<todo_todos> todo_todos { get; set; }
        public DbSet<todo_todos_statuses> todo_todos_statuses { get; set; }
        public DbSet<todo_users> todo_users { get; set; }
        public DbSet<todo_users_projects> todo_users_projects { get; set; }
        public DbSet<todo_users_todos> todo_users_todos { get; set; }
        public DbSet<v_statuses> v_statuses { get; set; }
        public DbSet<v_todos> v_todos { get; set; }
    }
}
