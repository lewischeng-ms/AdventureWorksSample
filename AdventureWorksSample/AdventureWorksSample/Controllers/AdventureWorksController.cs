using System.Linq;
using System.Web.OData;
using System.Web.OData.Routing;
using AdventureWorksSample.Models;

namespace AdventureWorksSample.Controllers
{
    public class AdventureWorksController : ODataController
    {
        [ODataRoute("Products")]
        public IQueryable<Product> GetFirstThreeProducts()
        {
            var context = new AdventureWorksContext();
            return context.Products.Take(3);
        }
    }
}