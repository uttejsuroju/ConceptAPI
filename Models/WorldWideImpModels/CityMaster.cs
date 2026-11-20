using System;
using System.Collections.Generic;

namespace ConceptAPI.Models.WorldWideImpModels;

public partial class CityMaster
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? StateId { get; set; }

    public virtual StateMaster? State { get; set; }
}
