using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionSKU;
using System.Collections.Generic;

namespace PromotionSKUUnitTestProj
{
    [TestClass]
    public class PromotionSKUUnitTest
    {

        ProductObj sKUProduct = new ProductObj();
        Products objProducts = new Products();
        Calculations priceCalculator = new Calculations();

        [TestMethod]
        public void GetTotalCost_1A1B1C()
        {
            List<ProductObj> listofProducts = new List<ProductObj>();
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                string skuType = string.Empty;
                if (count == 0)
                    skuType = "A";
                else if (count == 1)
                    skuType = "B";
                else if (count == 2)
                    skuType = "c";

                ProductObj product = objProducts.getProduct(skuType.ToUpper());
                listofProducts.Add(product);
                count++;
            }

            int TotalCost = priceCalculator.GetTotalPrice(listofProducts);
            Assert.AreEqual(TotalCost, 100);
        }

        [TestMethod]
        public void GetTotalCost_5A5B1C()
        {
            List<ProductObj> listofProducts = new List<ProductObj>();
            int count = 0;
            for (int i = 0; i < 11; i++)
            {
                string skuType = string.Empty;
                if (count == 0 || count < 5)
                    skuType = "A";
                else if (count > 4 && count < 10)
                    skuType = "B";
                else if (count == 10)
                    skuType = "c";

                ProductObj product = objProducts.getProduct(skuType.ToUpper());
                listofProducts.Add(product);
                count++;
            }

            int TotalCost = priceCalculator.GetTotalPrice(listofProducts);
            Assert.AreEqual(TotalCost, 370);
        }

        [TestMethod]
        public void GetTotalCost_3A5B1C1D()
        {
            List<ProductObj> listofProducts = new List<ProductObj>();
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                string skuType = string.Empty;
                if (count == 0 || count < 3)
                    skuType = "A";
                else if (count >= 3 && count <= 7)
                    skuType = "B";
                else if (count == 8)
                    skuType = "c";
                else if (count == 9)
                    skuType = "d";

                ProductObj product = objProducts.getProduct(skuType.ToUpper());
                listofProducts.Add(product);
                count++;
            }

            int TotalCost = priceCalculator.GetTotalPrice(listofProducts);
            Assert.AreEqual(TotalCost, 280);
        }

        [TestMethod]
        public void getProductPrice()
        {
            string Id = "a";
            ProductObj product = objProducts.getProduct(Id.ToUpper());
            Assert.AreEqual(50, product.price);
        }

        [TestMethod]
        public void GetTotalCostWithCandDSKUPromotion()
        {
            List<ProductObj> listofProducts = new List<ProductObj>();
            listofProducts.Add(new ProductObj() { id = "A", price = 50 });
            listofProducts.Add(new ProductObj() { id = "B", price = 30 });
            listofProducts.Add(new ProductObj() { id = "C", price = 20 });
            listofProducts.Add(new ProductObj() { id = "D", price = 15 });

            int TotalCost = priceCalculator.GetTotalPrice(listofProducts);
            Assert.AreEqual(TotalCost, 110);
        }                   
        
    }
}
