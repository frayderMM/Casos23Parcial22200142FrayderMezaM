﻿using System;
using System.Collections.Generic;

namespace Casos23Parcial22200142FrayderMeza.Core.Entities;

public partial class Competency
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Level { get; set; }
}
