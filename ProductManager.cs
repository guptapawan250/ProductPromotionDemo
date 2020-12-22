using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatementForPromotionEngine
{
    public class ProductManager
    {
       
        public IProductDetails _IProductDetails;

        public ProductManager (IProductDetails iProductDetails)
        {
            this._IProductDetails = iProductDetails;
        }
       
        public List<Product> GetProductList()
        {
            return _IProductDetails.GetProducts();;
        }

        public int GetTotalPrice(List<Product> products)
        {
            return _IProductDetails.GetTotalPrice(products);
        }
    }
}
