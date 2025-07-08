using System;
using System.Collections.Generic;

namespace LabProject3.Models;

public partial class VisitsDetail
{
    public int VisitDetailsId { get; set; }

    public string VisitType { get; set; } = null!;

    public virtual ICollection<LabVisit> LabVisits { get; set; } = new List<LabVisit>();
}
