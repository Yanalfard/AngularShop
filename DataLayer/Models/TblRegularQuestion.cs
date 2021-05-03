using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblRegularQuestion")]
    public partial class TblRegularQuestion
    {
        [Key]
        public int RegularQuestionId { get; set; }
        [Required]
        [StringLength(4000)]
        public string Question { get; set; }
        [Required]
        [StringLength(4000)]
        public string Answer { get; set; }
    }
}
