using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatementForPromotionEngine
{
   public interface IProductDetails
    {
        List<Product> GetProducts();
        int GetTotalPrice(List<Product> products);
    }
    public class ProductDetails : IProductDetails
    {
        LogManager log = LogManager.SingleInstance;
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            try
            {
                Console.WriteLine("total number of order");
                int a = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine("enter the type of product:A,B,C or D");
                    string type = Console.ReadLine();

                    Product p = new Product(type);
                    products.Add(p);
                }
            }
            catch (Exception e)
            {
                log.Error(e.ToString());
            }
            return products;
        }

        public int GetTotalPrice(List<Product> products)
        {
            int result = 0;
            try
            {
                int counterOfA = 0;
                int priceOfA = 50;
                int counterOfB = 0;
                int priceOfB = 30;
                int CounterOfC = 0;
                int priceOfC = 20;
                int CounterOfD = 0;
                int priceOfD = 15;
                foreach (Product pr in products)
                {
                    if (pr.Id == "A" || pr.Id == "a")
                    {
                        counterOfA = counterOfA + 1;
                    }
                    if (pr.Id == "B" || pr.Id == "b")
                    {
                        counterOfB = counterOfB + 1;
                    }
                    if (pr.Id == "C" || pr.Id == "c")
                    {
                        CounterOfC = CounterOfC + 1;
                    }
                    if (pr.Id == "D" || pr.Id == "d")
                    {
                        CounterOfD = CounterOfD + 1;
                    }
                }
                int totalPriceofA = (counterOfA / 3) * 130 + (counterOfA % 3 * priceOfA);
                int totalPriceofB = (counterOfB / 2) * 45 + (counterOfB % 2 * priceOfB);
                int totalPriceofC = (CounterOfC * priceOfC);
                int totalPriceofD = (CounterOfD * priceOfD);
                result =totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;
            
            }
            catch (Exception e)
            {
                log.Error(e.ToString());
            }

            return result;
        }
    }
}
