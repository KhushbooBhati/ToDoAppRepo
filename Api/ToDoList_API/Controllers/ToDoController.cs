using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Repository;
using ToDoList.Entities;

namespace ToDoList_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoController : BaseController<ToDoList.Entities.ToDoList, ToDoListRepository>
    {
        private ToDoListRepository repository;
        public ToDoController(ToDoListRepository repository) : base(repository)
        {
            this.repository = repository;

        }

    //    [HttpPut("{id}")]
    //    public override async Task<IActionResult> Put(int id, ToDoList.Entities.ToDoList entity)
    //    {
    //        if (id != entity.Id)
    //        {
    //            return BadRequest();
    //        }

    //        var entityToUpdate = repository.Get(id).Result; 

    //        if (entityToUpdate == null)
    //        {
    //            return NotFound();
    //        }

    //        entityToUpdate.Name = entity.Name;
    //        entityToUpdate.ToDoListItems = entity.ToDoListItems;
    //        await repository.Update(entityToUpdate);
    //        return NoContent();
    //    }

    } 
}
