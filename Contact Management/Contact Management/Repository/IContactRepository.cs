using Contact_Management.Models;

namespace Contact_Management.Repository
{
    public interface IContactRepository
    {
        List<ContactModel> GetAll();
        ContactModel Add(ContactModel contact);
    }
}
