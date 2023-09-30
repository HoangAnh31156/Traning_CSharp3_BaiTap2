using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TrainingCSharp3_BT2.Models.DomainClass;

[Table("LoaiSP")]
public partial class LoaiSp
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ma { get; set; }

    [StringLength(50)]
    public string? Ten { get; set; }

    [InverseProperty("IdLoaiSpNavigation")]
    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
