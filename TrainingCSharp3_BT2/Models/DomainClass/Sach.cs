using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TrainingCSharp3_BT2.Models.DomainClass;

[Table("SACH")]
public partial class Sach
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

    [Column("IDNXB")]
    public Guid? Idnxb { get; set; }

    [Column("TRANGTHAI")]
    public bool? Trangthai { get; set; }

    [ForeignKey("Idnxb")]
    [InverseProperty("Saches")]
    public virtual Nxb? IdnxbNavigation { get; set; }
}
