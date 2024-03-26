using System.ComponentModel.DataAnnotations;

namespace API_CarRental.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O ID do vendedor é obrigatório.")]
        public int SalesPeopleId { get; set; }

        [Required(ErrorMessage = "O ID do veículo é obrigatório.")]
        public int VehicleId { get; set; }

        [Required(ErrorMessage = "O valor da venda é obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "O valor da venda deve ser maior que zero.")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "A data da venda é obrigatória.")]
        public DateTime SaleDate { get; set; }

        [Display(Name = "Método de Pagamento")]
        public string? PaymentMethod { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        public string? CustomerName { get; set; }

        [EmailAddress(ErrorMessage = "O email do cliente deve ser um endereço de email válido.")]
        public string? CustomerEmail { get; set; }

        [Phone(ErrorMessage = "O número de telefone do cliente deve ser válido.")]
        public string? CustomerPhone { get; set; }

        public string? Notes { get; set; }

        [Required(ErrorMessage = "O ID do vendedor é obrigatório.")]
        public int SalesPersonId { get; set; }
        public SalesPerson? SalesPerson { get; set; }
    }
}
