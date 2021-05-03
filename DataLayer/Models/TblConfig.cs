using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblConfig")]
    public partial class TblConfig
    {
        [Key]
        [StringLength(128)]
        public string Key { get; set; }
        [StringLength(500)]
        public string Value { get; set; }
    }
}
