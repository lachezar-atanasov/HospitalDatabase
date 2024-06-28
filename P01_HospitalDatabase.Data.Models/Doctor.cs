using System.ComponentModel.DataAnnotations;

namespace P01_HospitalDatabase.Data.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        [MaxLength(100)]public string Name { get; set; } = null!;
        [MaxLength(100)]public string Specialty { get; set; } = null!;

        public ICollection<Visitation> Visitations { get; set; } = new HashSet<Visitation>();
    }
}
