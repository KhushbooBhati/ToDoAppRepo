using System;
using System.Collections.Generic;
using System.Text;
using TODoList.Interfaces;

namespace ToDoList.Entities
{
    public class ItemStatus:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
