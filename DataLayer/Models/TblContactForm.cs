using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblContactForm")]
    public partial class TblContactForm
    {
        [Key]
        public int ContactFormId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(15)]
        public string TellNo { get; set; }
        [StringLength(500)]
        public string Message { get; set; }
    }
}
