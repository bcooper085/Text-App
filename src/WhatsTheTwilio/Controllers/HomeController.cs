using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WhatsTheTwilio.Models;

namespace WhatsTheTwilio.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext db = new ContactContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewContact(string newName, string newNumber)
        {
            Contact newContact = new Contact(newName, newNumber);
            db.Contacts.Add(newContact);
            db.SaveChanges();
            Console.WriteLine("I WAS USED");
            return Json(newContact);
        }

        public IActionResult GetMessages()
        {
            var allMessages = Message.GetMessages();
            return View(allMessages);
        }

        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message newMessage)
        {
            newMessage.Send();
            return RedirectToAction("Index");
        }
    }
}
