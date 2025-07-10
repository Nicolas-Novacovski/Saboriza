using System.ComponentModel.DataAnnotations;

namespace Saboriza.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
    }
}
