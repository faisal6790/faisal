using _150_Faisal_DBForm.Data;
using _150_Faisal_DBForm.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _150_Faisal_DBForm.Controllers
{
    public class HomeController : Controller
    {
        public List<Contact> MyContacts;
        public IActionResult Index()
        {
            return View();
        }
        private readonly DataDbContext _dataDbContext;

        public HomeController(DataDbContext dataDbContext)
        {

            _dataDbContext = dataDbContext;

        }
        [HttpGet]
        public IActionResult Contactform()
        {
            MyContacts = _dataDbContext.contacts.ToList();
            return View(MyContacts);
        }
        [HttpPost]
        public object Contactform(Contact contact)
        {
            try
            {
                _dataDbContext.contacts.Add(contact);
                _dataDbContext.SaveChanges();
                TempData["message"] = "Data saved successflly";
                return RedirectToAction("Contactform");
            }
            catch (Exception)
            {
                TempData["message"] = "Data not saved";
                return RedirectToAction("Contactform");
            }
        }

        public IActionResult Edit(int? Id)
        {
            var edit_student = _dataDbContext.contacts.Find(Id);
            return View(edit_student);
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            var edit_student = _dataDbContext.contacts.Find(contact.Id);
            if (edit_student != null)
            {
                edit_student.firstname = contact.firstname;
                edit_student.price = contact.price;
                edit_student.quantity = contact.quantity;
                edit_student.description = contact.description;
                _dataDbContext.contacts.Update(edit_student);
                _dataDbContext.SaveChanges();
            }
            return RedirectToAction("Contactform");
        }


        public IActionResult Delete(int? Id)
        {
            var del_student = _dataDbContext.contacts.Find(Id);
            _dataDbContext.contacts.Remove(del_student);
            _dataDbContext.SaveChanges();
            return RedirectToAction("Contactform");
        }

        public IActionResult View(int ? Id)
        {
            return View(_dataDbContext.contacts.Find(Id));
        }
    
      
    }
}
