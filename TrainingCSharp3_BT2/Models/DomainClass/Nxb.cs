using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TrainingCSharp3_BT2.Models.DomainClass;

[Table("NXB")]
public partial class Nxb
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("MA")]
    [StringLength(5)]
    [Unicode(false)]
    public string? Ma { get; set; }

    [Column("TEN")]
    [StringLength(50)]
    public string? Ten { get; set; }

    [InverseProperty("IdnxbNavigation")]
    public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();
}
