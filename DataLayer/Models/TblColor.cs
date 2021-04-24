using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblColor")]
    public partial class TblColor
    {
        public TblColor()
        {
            TblAmounts = new HashSet<TblAmount>();
        }

        [Key]
        public int ColorId { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(7)]
        public string ColorCode { get; set; }
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(TblProduct.TblColors))]
        public virtual TblProduct Product { get; set; }
        [InverseProperty(nameof(TblAmount.Color))]
        public virtual ICollection<TblAmount> TblAmounts { get; set; }
    }
}
