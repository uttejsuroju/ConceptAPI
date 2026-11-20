using System;
using System.Collections.Generic;

namespace ConceptAPI.Models.WorldWideImpModels;

public partial class CountryMaster
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? CountryCode { get; set; }

    public virtual ICollection<StateMaster> StateMasters { get; set; } = new List<StateMaster>();
}
