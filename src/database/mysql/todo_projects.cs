//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class todo_projects
    {
        public todo_projects()
        {
            this.todo_projects_todos = new HashSet<todo_projects_todos>();
            this.todo_projects_meta = new HashSet<todo_projects_meta>();
            this.todo_users_projects = new HashSet<todo_users_projects>();
        }
    
        public string project_id { get; set; }
        public string project_name { get; set; }
        public string is_active { get; set; }
        public Nullable<System.DateTime> added_on { get; set; }
    
        public virtual ICollection<todo_projects_todos> todo_projects_todos { get; set; }
        public virtual ICollection<todo_projects_meta> todo_projects_meta { get; set; }
        public virtual ICollection<todo_users_projects> todo_users_projects { get; set; }
    }
}
