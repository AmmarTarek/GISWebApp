using System.Security.Principal;

namespace GISWebApp.Models
{
    public class ProdcutsBL 
    {
        List<Prodcuts> prodcutsList;

        public ProdcutsBL()
        {
            prodcutsList = new()
            {
                new(){id=1, prodcutName="Tea", prodcutDescription="Arosa Tea", prodcutPrice= 30, prodcutImageUrl="Tea.jpg", sellerName="3m Sayed"},
                new(){id=2, prodcutName="Coffe", prodcutDescription="El Baz Coffe", prodcutPrice= 120, prodcutImageUrl="Coffee.jpg", sellerName="3m EL Baz"},
                new(){id=3, prodcutName="Sahlab", prodcutDescription="Sahlab bl moksarat", prodcutPrice= 50, prodcutImageUrl="Sa7lab.jpg", sellerName="EL Ma3lem Sa7lab"},
                new(){id=4, prodcutName="3nab", prodcutDescription="3nab sake3", prodcutPrice= 90, prodcutImageUrl="3nab.jpg", sellerName="El Ragol EL 3nab"}

            };
        }

        public List<Prodcuts> GetAll()
        {
            return prodcutsList;
        }

        public Prodcuts GetProdcutsByID(int id)
        {
            return prodcutsList.FirstOrDefault(p=> p.id == id);
        }

        
    }



}
