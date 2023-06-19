using System.ComponentModel.DataAnnotations;

namespace Contact_Management.Models
{
    public class ContactModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome")]
        [MinLength(5, ErrorMessage = "Min - 5 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Digite o telefone")]
        [MinLength(9, ErrorMessage = "Número de telefone inválido")]
        [MaxLength(9, ErrorMessage = "Número de telefone inválido")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Digite o e-mail")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        [MaxLength(320)]
        public string Email { get; set; }
    }
}
