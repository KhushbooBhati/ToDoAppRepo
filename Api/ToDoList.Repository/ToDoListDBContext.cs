using Microsoft.EntityFrameworkCore;
using ToDoList.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Repository
{
    public class ToDoListDBContext:DbContext
    {
        public ToDoListDBContext(DbContextOptions<ToDoListDBContext> options) : base(options)
        {

        }

        public DbSet<ToDoList.Entities.ToDoList> ToDoLists { get; set; }
        public DbSet<ToDoList.Entities.ItemStatus> ItemStatuses { get; set; }
    }
}
