using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindActivity.Models;

namespace FindActivity.Controllers
{
    public class SampleData
    {
        public static void Initialize(EventContext context)
        {           
                context.Events.Add(
                    new Event
                    {
                        Id = 001,
                        Name = "test@gmail.com",
                        Type = "123",
                        Description = "Vasya",
                        Date = DateTime.Today
                    }
                    );
                context.SaveChanges();
        }
        public static void Initialize(UserContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Id = 001,
                        Email = "test@gmail.com",
                        Password = "123",
                        Name = "Vasya",
                        LastName = "Pupkin",
                        Age = 18,
                    },
                    new User
                    {
                        Id = 002,
                        Email = "test2@gmail.com",
                        Password = "1234",
                        Name = "Kolya",
                        LastName = "Admin",
                        Age = 18,
                    },
                    new User
                    {
                        Id = 003,
                        Email = "test3@gmail.com",
                        Password = "12345",
                        Name = "Petya",
                        LastName = "Kolhoz",
                        Age = 18,
                    }
                    );
                context.SaveChanges();
            }
        }
        

    }
}
