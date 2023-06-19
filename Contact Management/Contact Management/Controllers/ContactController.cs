using Contact_Management.Models;
using Contact_Management.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Contact_Management.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;
        
        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public IActionResult Index()
        {
            List<ContactModel> contacts = _contactRepository.GetAll();
            return View(contacts);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult ConfirmDelete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactModel model)
        {
            _contactRepository.Add(model);
            return RedirectToAction("Index");
        }

    }
}
