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
    
    public partial class todo_users
    {
        public todo_users()
        {
            this.todo_logs = new HashSet<todo_logs>();
            this.todo_todos_statuses = new HashSet<todo_todos_statuses>();
            this.todo_users_projects = new HashSet<todo_users_projects>();
            this.todo_users_todos = new HashSet<todo_users_todos>();
        }
    
        public string user_id { get; set; }
        public string user_fullname { get; set; }
        public string user_username { get; set; }
        public string user_password { get; set; }
        public string user_salt { get; set; }
        public string is_active { get; set; }
        public System.DateTime added_on { get; set; }
    
        public virtual ICollection<todo_logs> todo_logs { get; set; }
        public virtual ICollection<todo_todos_statuses> todo_todos_statuses { get; set; }
        public virtual ICollection<todo_users_projects> todo_users_projects { get; set; }
        public virtual ICollection<todo_users_todos> todo_users_todos { get; set; }
    }
}
