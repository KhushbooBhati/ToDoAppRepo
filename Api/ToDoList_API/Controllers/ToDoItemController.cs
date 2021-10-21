using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Repository;

namespace ToDoList_API.Controllers
{
    public class ToDoItemController :  BaseController<ToDoList.Entities.ToDoListItem, ToDoListItemRepository>
    {
        public ToDoItemController(ToDoListItemRepository repository) : base(repository)
        {

        }
    }
}
