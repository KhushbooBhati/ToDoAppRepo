using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Repository;

namespace ToDoList_API
{
    public class PreFillData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ToDoListDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<ToDoListDBContext>>()))
            {

                if (context.ItemStatuses.Any())
                {
                    return;  
                }

                context.ItemStatuses.AddRange(
                    new ToDoList.Entities.ItemStatus
                    {
                        Id = 1,
                        Name = "Pending"
                    },
                    new ToDoList.Entities.ItemStatus
                    {
                        Id = 2,
                        Name = "Completed"
                    });

                context.SaveChanges();
            }
        }
    }
}
