using System.Security.Principal;

namespace GISWebApp.Models
{
    public class Prodcuts 
    {
        public int id { get; set; }
        public string prodcutName { get; set; }
        public float prodcutPrice { get; set; }
        public string prodcutDescription { get; set; }
        public string prodcutImageUrl { get; set; }
        public string sellerName { get; set; }
    }
}
