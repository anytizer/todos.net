﻿namespace dtos
{
    public class todosDTO
    {
        public string todo_id { get; set; }
        public string todo_text { get; set; }

        public string project_id { get; set; }
        public string project_name;

        public string status_id { get; set; }
        public string status_name;

        public string issue_number { get; set; }
        public System.DateTime added_on { get; set; }
    }
}
