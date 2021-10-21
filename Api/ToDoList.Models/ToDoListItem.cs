using System;
using System.Collections.Generic;
using System.Text;
using TODoList.Interfaces;

namespace ToDoList.Entities
{
    public class ToDoListItem :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; } = false;
        public ToDoList ToDoList { get; set; }
        public int ToDoListId { get; set; }
    }
}
