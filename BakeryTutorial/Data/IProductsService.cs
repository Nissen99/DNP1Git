using System.Collections.Generic;
using BakeryTutorial.Models;

namespace BakeryTutorial.Data
{
    public interface IProductsService
    {
        public IList<Product> Products { get; }
    }
}