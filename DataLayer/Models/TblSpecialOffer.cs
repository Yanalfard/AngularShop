using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblSpecialOffer")]
    public partial class TblSpecialOffer
    {
        [Key]
        public int SpecialOfferId { get; set; }
        public int ProductId { get; set; }
        public short Percentage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ValidTill { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(TblProduct.TblSpecialOffers))]
        public virtual TblProduct Product { get; set; }
    }
}
