using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblPostOption")]
    public partial class TblPostOption
    {
        [Key]
        public int PostOptionId { get; set; }
        [Required]
        [StringLength(500)]
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
