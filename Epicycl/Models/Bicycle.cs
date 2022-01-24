namespace Epicycl.Models
{
    public class Bicycle
    {
        public enum Type
        {
            City,
            Montain,
            Electric,
            Hybrid
        }
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}
