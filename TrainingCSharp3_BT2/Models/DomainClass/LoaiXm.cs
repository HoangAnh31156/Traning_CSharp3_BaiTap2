using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TrainingCSharp3_BT2.Models.DomainClass;

[Table("LoaiXM")]
public partial class LoaiXm
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ma { get; set; }

    [StringLength(50)]
    public string? Ten { get; set; }

    [InverseProperty("IdLxmNavigation")]
    public virtual ICollection<XeMay> XeMays { get; set; } = new List<XeMay>();
}
