using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblProductImageRel")]
    public partial class TblProductImageRel
    {
        [Key]
        public int ProductImageRelId { get; set; }
        public int ProductId { get; set; }
        public int ImageId { get; set; }

        [ForeignKey(nameof(ImageId))]
        [InverseProperty(nameof(TblImage.TblProductImageRels))]
        public virtual TblImage Image { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(TblProduct.TblProductImageRels))]
        public virtual TblProduct Product { get; set; }
    }
}
