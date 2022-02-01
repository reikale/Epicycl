using Epicycl.Models;

namespace Epicycl.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<SubscribtionTypes> MembershipTypes { get; set; }
        public Customer Customer { get; set; }


    }
}
