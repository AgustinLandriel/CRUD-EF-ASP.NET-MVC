using System;
using System.Collections.Generic;

namespace CRUD_CORE_EF.Models;

public partial class Cargo
{
    public int IdCargo { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();
}
