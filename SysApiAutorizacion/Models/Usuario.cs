﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysApiAutorizacion.Models;

public partial class Usuario
{
    [Key]
    public int Id { get; set; }

    public int IdRol { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Nombre { get; set; } 

    [StringLength(30)]
    [Unicode(false)]
    public string? Apellido { get; set; } 

    [StringLength(25)]
    [Unicode(false)]
    public string Login { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    public byte Estatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaRegistro { get; set; }

    [ForeignKey("IdRol")]
    [InverseProperty("Usuario")]
    public virtual Rol? IdRolv { get; set; }
}
