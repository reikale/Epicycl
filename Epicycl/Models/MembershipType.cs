using System.ComponentModel.DataAnnotations;

namespace Epicycl.Models
{
    
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        [StringLength(255)]
        public string Type { get; set; }
        public string Name { get; set; }
        
    }
}
