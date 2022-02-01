using System.ComponentModel.DataAnnotations;

namespace Epicycl.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        
        public virtual MembershipType? MembershipType { get; set; } 

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name ="Date of Birth")]
        [Min18YearsIfaMember]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
    }
}
