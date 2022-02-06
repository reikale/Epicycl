using Epicycl.Models;

namespace Epicycl.ViewModels
{
    public class CustomerDetailsViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<SubscribtionTypes> SubscribtionTypes { get; set; }

        public IEnumerable<string> ServiceList { get; set; }
    }
}
