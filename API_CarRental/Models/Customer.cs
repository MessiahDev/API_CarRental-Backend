using System.ComponentModel.DataAnnotations;

namespace API_CarRental.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do cliente deve ter no máximo 100 caracteres.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "O email do cliente é obrigatório.")]
        [EmailAddress(ErrorMessage = "O email do cliente deve ser um endereço de email válido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O telefone do cliente é obrigatório.")]
        [Phone(ErrorMessage = "O número de telefone do cliente deve ser válido.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "O celular do cliente é obrigatório.")]
        [Phone(ErrorMessage = "O número de celular do cliente deve ser válido.")]
        public string? CellPhone { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "O CPF do cliente é obrigatório.")]
        [StringLength(14, ErrorMessage = "O CPF do cliente deve ter 11 caracteres.")]
        public string? CPF { get; set; }

        [Required(ErrorMessage = "O RG do cliente é obrigatório.")]
        [StringLength(20, ErrorMessage = "O RG do cliente deve ter no máximo 20 caracteres.")]
        public string? RG { get; set; }

        [Required(ErrorMessage = "A CNH do cliente é obrigatório.")]
        [StringLength(20, ErrorMessage = "A CNH do cliente deve ter no máximo 20 caracteres.")]
        public string? DrivingLicenseNumber { get; set; }
    }
}
