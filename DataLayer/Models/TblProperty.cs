using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblProperty")]
    public partial class TblProperty
    {
        public TblProperty()
        {
            TblProductPropertyRels = new HashSet<TblProductPropertyRel>();
        }

        [Key]
        public int PropertyId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsMini { get; set; }
        [StringLength(250)]
        public string Image { get; set; }

        [InverseProperty(nameof(TblProductPropertyRel.Property))]
        public virtual ICollection<TblProductPropertyRel> TblProductPropertyRels { get; set; }
    }
}
