using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Repository
{
    public class ToDoListItemRepository : Repository<ToDoList.Entities.ToDoListItem, ToDoListDBContext>
    {
        private ToDoListDBContext dbContext;
        public ToDoListItemRepository(ToDoListDBContext context) : base(context)
        {
            this.dbContext = context;
        }
    }
}
