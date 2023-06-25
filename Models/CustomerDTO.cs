using InventorySystem.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace InventorySystem.Models
{
    public class CustomerDTO
    {
        public int id { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string phone { set; get; }
        [Required]
        public string Email { set; get; }
        [Required]
        public string Address { set; get; }
        [Required]
        public TypeEnum Type { set; get; }
    }
}
