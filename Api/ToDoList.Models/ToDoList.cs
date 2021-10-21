using TODoList.Interfaces;
using System;
using System.Collections.Generic;

namespace ToDoList.Entities
{
    public class ToDoList:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ToDoListItem> ToDoListItems { get; set; } = new List<ToDoListItem>(); 
    }
}
