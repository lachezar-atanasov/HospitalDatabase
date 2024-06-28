using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_HospitalDatabase.Data.Models
{
    public class Medicament
    {
        public int MedicamentId { get; set; }
        [MaxLength(50)] public string Name { get; set; } = string.Empty;

        [ForeignKey("MedicamentId")]
        public ICollection<Patient> Patients { get; set; } = new HashSet<Patient>();
    }
}
