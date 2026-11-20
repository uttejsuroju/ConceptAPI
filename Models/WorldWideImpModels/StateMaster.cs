using System;
using System.Collections.Generic;

namespace ConceptAPI.Models.WorldWideImpModels;

public partial class StateMaster
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? CountryId { get; set; }

    public virtual ICollection<CityMaster> CityMasters { get; set; } = new List<CityMaster>();

    public virtual CountryMaster? Country { get; set; }
}
