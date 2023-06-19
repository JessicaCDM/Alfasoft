using Contact_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Contact_Management.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        public DbSet<ContactModel> Contacts { get; set; }
    }
}
