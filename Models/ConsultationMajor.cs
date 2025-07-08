using System;
using System.Collections.Generic;

namespace LabProject3.Models;

public partial class ConsultationMajor
{
    public int ConsultationMajorId { get; set; }

    public string Major { get; set; } = null!;

    public string ConsultationDescription { get; set; } = null!;

    public virtual ICollection<Consultation> Consultations { get; set; } = new List<Consultation>();
}
