﻿using System.ComponentModel.DataAnnotations;

namespace P01_HospitalDatabase.Data.Models
{
    public class Visitation
    {
        public int VisitationId { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(250)] public string Comments { get; set; } = null!;
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; } = new Patient();

        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; } = null!;
    }
}
