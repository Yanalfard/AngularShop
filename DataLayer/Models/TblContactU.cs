using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataLayer.Models
{
    public partial class TblContactU
    {
        [Key]
        [StringLength(256)]
        public string Key { get; set; }
        [StringLength(1000)]
        public string Value { get; set; }
    }
}
