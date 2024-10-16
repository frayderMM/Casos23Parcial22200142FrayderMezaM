using System;
using System.Collections.Generic;

namespace Casos23Parcial22200142FrayderMeza.Core.Entities;

public partial class JobOffer
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int Salario { get; set; }

    public string? Location { get; set; }
}
