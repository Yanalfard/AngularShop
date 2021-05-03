using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblAddress")]
    public partial class TblAddress
    {
        public TblAddress()
        {
            TblOrders = new HashSet<TblOrder>();
        }

        [Key]
        public int AddressId { get; set; }
        [Required]
        [StringLength(150)]
        public string Address { get; set; }
        [Required]
        [StringLength(50)]
        public string City { get; set; }
        [Required]
        [StringLength(50)]
        public string Province { get; set; }
        public int ClientId { get; set; }
        [StringLength(20)]
        public string PostalCode { get; set; }

        [ForeignKey(nameof(ClientId))]
        [InverseProperty(nameof(TblClient.TblAddresses))]
        public virtual TblClient Client { get; set; }
        [InverseProperty(nameof(TblOrder.Address))]
        public virtual ICollection<TblOrder> TblOrders { get; set; }
    }
}
