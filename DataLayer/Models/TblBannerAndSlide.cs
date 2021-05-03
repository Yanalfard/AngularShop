using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    [Table("TblBannerAndSlide")]
    public partial class TblBannerAndSlide
    {
        [Key]
        public int BannerAndSlideId { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
        [StringLength(128)]
        public string Title { get; set; }
        [Required]
        [StringLength(4000)]
        public string ImageUrl { get; set; }
        [Required]
        [StringLength(4000)]
        public string Link { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActiveTill { get; set; }
        public bool IsSlider { get; set; }
    }
}
