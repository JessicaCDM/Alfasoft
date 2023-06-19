using Contact_Management.Models;

namespace Contact_Management.Repository
{
    public interface IContactRepository
    {
        List<ContactModel> GetAll();
        ContactModel Add(ContactModel contact);
        ContactModel GetId(int id);
        ContactModel Update(ContactModel contact);
    }
}
