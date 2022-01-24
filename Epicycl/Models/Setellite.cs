namespace Epicycl.Models
{
    public class Setellite
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
