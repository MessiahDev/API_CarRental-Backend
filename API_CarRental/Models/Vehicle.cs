using System.ComponentModel.DataAnnotations;

namespace API_CarRental.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O ID do veículo é obrigatório.")]
        public int VehicleId { get; set; }

        [Required(ErrorMessage = "O nome do veículo é obrigatório.")]
        [StringLength(100, ErrorMessage = "Nome do veículo deve ter 100 caracteres no máximo!")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "O modelo do veículo é obrigatório.")]
        [StringLength(100, ErrorMessage = "Nome do modelo do veículo deve ter 100 caracteres no máximo!")]
        public string? Model { get; set; }

        [Required(ErrorMessage = "O ID do cliente é obrigatório.")]
        public int CustomerId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [StringLength(50)]
        public string? Status { get; set; }

        [Required(ErrorMessage = "O ID da categoria é obrigatório.")]
        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
