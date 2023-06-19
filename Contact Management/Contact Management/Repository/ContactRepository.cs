using Contact_Management.Data;
using Contact_Management.Models;

namespace Contact_Management.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly DataContext _dataContext;
        public ContactRepository(DataContext bdContext) 
        {
            _dataContext = bdContext;
        }

        public List<ContactModel> GetAll()
        {
            return _dataContext.Contacts.ToList();
        }
        public ContactModel Add(ContactModel contact) 
        {
            _dataContext.Contacts.Add(contact);
            _dataContext.SaveChanges();
            return contact;
        }

        public ContactModel GetId(int id)
        {
            return _dataContext.Contacts.FirstOrDefault(x => x.Id == id);
        }

        public ContactModel Update(ContactModel contact)
        {
            ContactModel contactModel = GetId(contact.Id);
            if (contactModel == null) throw new Exception("Erro ao Actualizar");
            
            contactModel.Name = contact.Name;
            contactModel.Email = contact.Email;
            contactModel.Phone = contact.Phone;

            _dataContext.Contacts.Update(contactModel);
            _dataContext.SaveChanges();
            return contactModel;
        }
    }
}
