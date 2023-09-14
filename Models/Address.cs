using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string? AddressType { get; set; }
        public string? FullAddress { get; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }

        [ForeignKey("Employee")]
        public string? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
