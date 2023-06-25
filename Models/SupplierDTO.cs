using InventorySystem.Data;
using System.ComponentModel.DataAnnotations;

namespace InventorySystem.Models
{
    public class SupplierDTO
    {
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string phone { set; get; }
        [Required]
        public string Email { set; get; }
        [Required]
        public string Address { set; get; }
        [Required]
        public string ContactPerson { set; get; }
        [Required]
        public string ContactPersonPhone { set; get; }
    }
}
