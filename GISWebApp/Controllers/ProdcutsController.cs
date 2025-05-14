using GISWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace GISWebApp.Controllers
{
    public class ProdcutsController : Controller
    {
        ProdcutsBL prodcutsBL = new ProdcutsBL();

        public IActionResult All()
        {
            List<Prodcuts> prodcutsList = prodcutsBL.GetAll(); 
            
            return View("All", prodcutsList);
        }

        public IActionResult Details(int id)
        {
            Prodcuts prodcuts = prodcutsBL.GetProdcutsByID(id);

            if (prodcuts == null) { return NotFound(); }

            return View("Details", prodcuts);
        }

        
    }
}
