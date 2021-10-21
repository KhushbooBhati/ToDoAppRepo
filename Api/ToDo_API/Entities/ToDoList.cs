using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo_API.Entities
{
    public class ToDoList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ToDoListItem> toDoListItems { get; set; }
    }
}
