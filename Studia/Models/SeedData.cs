using Microsoft.EntityFrameworkCore;
using Studia.Data;

namespace Studia.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new StudiaContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<StudiaContext>>()))
        {
            // Look for any movies.
            if (context.Task.Any())
            {
                return;   // DB has been seeded
            }
            context.Task.AddRange(
                new Task
                {
                    Name = "Do science work",
                    Description = "Description 1",
                    Status = "Pending",
                    DueDateTime = new DateTime(2008, 5, 1, 8, 40, 00),
                    CreatedBy = "User 1"
                },
                new Task
                {
                    Name = "Do tuition work",
                    Description = "Description 1",
                    Status = "Pending",
                    DueDateTime = new DateTime(2008, 5, 1, 8, 40, 00),
                    CreatedBy = "User 1"
                },
                new Task
                {
                    Name = "Do holiday homework",
                    Description = "Description 1",
                    Status = "Pending",
                    DueDateTime = new DateTime(2008, 5, 1, 8, 40, 00),
                    CreatedBy = "User 1"
                },
                new Task
                {
                    Name = "Do coding",
                    Description = "Description 1",
                    Status = "Pending",
                    DueDateTime = new DateTime(2008, 5, 1, 8, 40, 00),
                    CreatedBy = "User 1"
                }
            );
            context.SaveChanges();
        }
    }
}