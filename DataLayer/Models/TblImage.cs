using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblImage")]
    public partial class TblImage
    {
        public TblImage()
        {
            TblProductImageRels = new HashSet<TblProductImageRel>();
        }

        [Key]
        public int ImageId { get; set; }
        [Required]
        public string Image { get; set; }

        [InverseProperty(nameof(TblProductImageRel.Image))]
        public virtual ICollection<TblProductImageRel> TblProductImageRels { get; set; }
    }
}
