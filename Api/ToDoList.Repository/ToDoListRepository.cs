using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Repository
{
    public class ToDoListRepository : Repository<ToDoList.Entities.ToDoList, ToDoListDBContext>
    {
        private ToDoListDBContext dbContext;
        public ToDoListRepository(ToDoListDBContext context) : base(context)
        {
            this.dbContext = context;
        }

        public override async Task<List<Entities.ToDoList>> GetAll()
        {
            return await dbContext.ToDoLists.Include(x=>x.ToDoListItems).ToListAsync();

        }

        public override async Task<Entities.ToDoList> Get(int id)
        {
            return await dbContext.ToDoLists.Include(x => x.ToDoListItems).FirstOrDefaultAsync(x => x.Id == id);
        }


    }
}
