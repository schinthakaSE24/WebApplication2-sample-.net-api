﻿namespace WebApplication2.model
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Due { get; set; }
        public Todostatus Status { get; set; } //new, inprogress, completed



    }
}
