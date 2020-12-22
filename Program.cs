using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatementForPromotionEngine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LogManager log = LogManager.SingleInstance;
        
            try
            {
                IProductDetails prodDetail = new ProductDetails();
                ProductManager prodMgr = new ProductManager(prodDetail);
                List<Product> products = prodMgr.GetProductList();

                if (products != null && products.Count > 0)
                {
                    int totalPrice = prodMgr.GetTotalPrice(products);

                    Console.WriteLine(totalPrice);
                }
                
                Console.ReadLine();
            }
            catch (Exception e)
            {
                log.Error(e.ToString());
            }
        }
    }

    
}
