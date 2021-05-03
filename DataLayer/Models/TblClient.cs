using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblClient")]
    public partial class TblClient
    {
        public TblClient()
        {
            TblAddresses = new HashSet<TblAddress>();
            TblBookMarks = new HashSet<TblBookMark>();
            TblComments = new HashSet<TblComment>();
            TblOrders = new HashSet<TblOrder>();
            TblRates = new HashSet<TblRate>();
        }

        [Key]
        public int ClientId { get; set; }
        [Required]
        [StringLength(15)]
        public string TellNo { get; set; }
        [Required]
        [StringLength(64)]
        public string Password { get; set; }
        public string Auth { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        public int RoleId { get; set; }
        public long Balance { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(200)]
        public string MainImage { get; set; }

        [ForeignKey(nameof(RoleId))]
        [InverseProperty(nameof(TblRole.TblClients))]
        public virtual TblRole Role { get; set; }
        [InverseProperty(nameof(TblAddress.Client))]
        public virtual ICollection<TblAddress> TblAddresses { get; set; }
        [InverseProperty(nameof(TblBookMark.Client))]
        public virtual ICollection<TblBookMark> TblBookMarks { get; set; }
        [InverseProperty(nameof(TblComment.Client))]
        public virtual ICollection<TblComment> TblComments { get; set; }
        [InverseProperty(nameof(TblOrder.Client))]
        public virtual ICollection<TblOrder> TblOrders { get; set; }
        [InverseProperty(nameof(TblRate.Client))]
        public virtual ICollection<TblRate> TblRates { get; set; }
    }
}
