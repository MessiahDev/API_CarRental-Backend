using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_CarRental.Models
{
    public class Category
    {
        public Category()
        {
            Vehicles = new Collection<Vehicle>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do grupo da categoria é obrigatório.")]
        [StringLength(50, ErrorMessage = "O nome da categoria deve ter no máximo 50 caracteres.")]
        public string? Group { get; set; }

        [Required(ErrorMessage = "O descrição da categoria é obrigatória.")]
        [StringLength(100, ErrorMessage = "O nome da categoria deve ter no máximo 100 caracteres.")]
        public string? Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        public ICollection<Vehicle>? Vehicles { get; set; }
    }
}
