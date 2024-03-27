using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace API_CarRental.Models
{
    public class SalesPerson
    {
        public SalesPerson()
        {
            Sales = new Collection<Sale>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do vendedor é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do vendedor deve ter no máximo 100 caracteres.")]
        public string? Name { get; set; }

        [EmailAddress(ErrorMessage = "O email do vendedor deve ser um endereço de email válido.")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "O número de telefone do vendedor deve ser válido.")]
        public string? Phone { get; set; }

        public string? Address { get; set; }

        public string? Role { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O salário do vendedor deve ser maior que zero.")]
        public decimal Salary { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Required]
        public decimal CommissionRate { get; set; }

        public ICollection<Sale>? Sales { get; set; }
    }
}
