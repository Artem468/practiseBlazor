using System.ComponentModel.DataAnnotations;

namespace practiseBlazor.Models
{
    public class Driver
    {
        [Key] public long Id { get; set; }
        public string Name { get; set; }
        public long LicenseNumber { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfHire { get; set; }
        public ICollection<Waybill>? Waybills { get; set; }
    }
}