using System.ComponentModel.DataAnnotations;

namespace Contact_Management.ViewModel
{
    public class ViewModelContact
    {
        [Required(ErrorMessage = "Insira um nome")]
        [MaxLength(48)]
        [MinLength(5, ErrorMessage = "Min - 5 caracteres")]
        public string name { get; set; }

        [Required(ErrorMessage = "Insira um número de telefone")]
        [MaxLength(9)]
        [MinLength(9, ErrorMessage = "Insira um telefone válido")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Insira um email")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        [MaxLength(320)]
        public string email { get; set; }
    }
}
