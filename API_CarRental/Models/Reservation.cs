using System.ComponentModel.DataAnnotations;

namespace API_CarRental.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O ID do veículo é obrigatório.")]
        public int VehicleId { get; set; }

        [Required(ErrorMessage = "O ID do cliente é obrigatório.")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "A data de início da reserva é obrigatória.")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "A data de fim da reserva é obrigatória.")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsPaid { get; set; }
        public bool IsActive { get; set; }
    }
}
