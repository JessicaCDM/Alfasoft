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
    }
}
