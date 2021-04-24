using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblSize")]
    public partial class TblSize
    {
        public TblSize()
        {
            TblAmounts = new HashSet<TblAmount>();
        }

        [Key]
        public int SizeId { get; set; }
        [Required]
        [StringLength(20)]
        public string Size { get; set; }
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(TblProduct.TblSizes))]
        public virtual TblProduct Product { get; set; }
        [InverseProperty(nameof(TblAmount.Size))]
        public virtual ICollection<TblAmount> TblAmounts { get; set; }
    }
}
