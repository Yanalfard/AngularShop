using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblBookMark")]
    public partial class TblBookMark
    {
        [Key]
        public int BookMarkId { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }

        [ForeignKey(nameof(ClientId))]
        [InverseProperty(nameof(TblClient.TblBookMarks))]
        public virtual TblClient Client { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(TblProduct.TblBookMarks))]
        public virtual TblProduct Product { get; set; }
    }
}
