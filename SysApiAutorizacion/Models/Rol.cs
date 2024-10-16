using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysApiAutorizacion.Models;

public partial class Rol
{
    [Key]
    public int Id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [InverseProperty("IdRolv")]
    public virtual ICollection<Usuario> Usuario { get; set; } = new List<Usuario>();
}
