using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

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

        [Required(ErrorMessage = "O nome da categoria é obrigatório.")]
        [StringLength(50, ErrorMessage = "O nome da categoria deve ter no máximo 50 caracteres.")]
        public string? Name { get; set; }

        public ICollection<Vehicle>? Vehicles { get; set; }
    }
}
