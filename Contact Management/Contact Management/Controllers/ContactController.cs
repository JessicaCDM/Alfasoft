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

        public IActionResult Edit(int id)
        {
            ContactModel contact = _contactRepository.GetId(id);
            return View(contact);
        }

        public IActionResult Details(int id)
        {
            ContactModel contact = _contactRepository.GetId(id);
            return View(contact);
        }

        public IActionResult ConfirmDelete(int id)
        {
            ContactModel contact = _contactRepository.GetId(id);
            return View(contact);
        }
        public IActionResult Delete(int id)
        {
            _contactRepository.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(ContactModel model)
        {
            if(ModelState.IsValid)
            {
                _contactRepository.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ContactModel model)
        {
            _contactRepository.Update(model);
            return RedirectToAction("Index");
        }

    }
}
