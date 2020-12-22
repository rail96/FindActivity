using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FindActivity.ViewModels; // пространство имен моделей RegisterModel и LoginModel
using FindActivity.Models; // пространство имен UserContext и класса User
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

namespace FindActivity.Controllers
{
    public class EventController : Controller
    {
        private EventContext db;
        public EventController(EventContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateEventModel model)
        {
            if (ModelState.IsValid)
            {
                Event even = await db.Events.FirstOrDefaultAsync(u => u.Name == model.Name);
                if (even == null)
                {
                    Random rand = new Random();
                    int i = rand.Next(1, 1000);
                    db.Events.Add(new Event {Id = i*5, Name = model.Name, Type = model.Type, Description = model.Description, Date = model.Date });
                    await db.SaveChangesAsync();

                    return View("Index", "Event");
                }
                else
                {
                    ModelState.AddModelError("", "Something went wrong...");
                }
                 return View(model);
            }
            return View(model);
        }
    }
}
