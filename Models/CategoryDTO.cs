using InventorySystem.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace InventorySystem.Models
{
    public class CategoryDTO
    {
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public StatusEnum Status { set; get; }
    }
}
