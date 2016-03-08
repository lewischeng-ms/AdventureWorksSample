using System.Data.Entity;
using System.Linq;
using AdventureWorksSample.Models;
using Microsoft.Restier.Core;
using Microsoft.Restier.EntityFramework;

namespace AdventureWorksSample
{
    public class AdventureWorksApi : DbApi<AdventureWorksContext>
    {
        public IQueryable<Product> ProductsToReorder
        {
            get
            {
                return this.Source<ProductInventory>("ProductInventories")
                    .Include("Product").Include("Location")
                    .Where(pi => pi.Location.Name == "Tool Crib" && pi.Quantity < pi.Product.ReorderPoint)
                    .Select(pi => pi.Product);
            }
        }

        public IQueryable<Employee> TopFiveEarlyEmployees
        {
            get
            {
                return this.Source<Employee>("Employees")
                    .OrderBy(e => e.HireDate).Take(5);
            }
        }
    }
}