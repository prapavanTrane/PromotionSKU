using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionSKU
{
    class Program
    {
        static void Main(string[] args)
        {
            Products sKUProduct = new Products();
            Calculations priceCalculator = new Calculations();
            List<ProductObj> listofProducts = new List<ProductObj>();

            Console.WriteLine("Enter total number of order");
            int numberOfUnits=0;
            try
            {
                numberOfUnits = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
           

            for (int i = 0; i < numberOfUnits; i++)
            {
                Console.WriteLine("Please enter type of SKU product A,B,C,D");
                string skuType = Console.ReadLine();
                ProductObj product = sKUProduct.getProduct(skuType.ToUpper());
                listofProducts.Add(product);
            }

            int totalCost = priceCalculator.GetTotalPrice(listofProducts);
            Console.WriteLine("Total Cost For {0} Product's is {1}", numberOfUnits, totalCost);
            Console.ReadLine();
        }
    }
}
