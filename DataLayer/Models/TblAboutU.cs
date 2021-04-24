using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DataLayer.Models
{
    public partial class TblAboutU
    {
        [Key]
        [StringLength(256)]
        public string Key { get; set; }
        [StringLength(1000)]
        public string Value { get; set; }
    }
}
