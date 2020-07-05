using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionSKU
{
     public class Products
    {
        public ProductObj getProduct(string ProductId)
        {
            
            ProductObj objProduct = new ProductObj();
                    
            switch (ProductId)
            {
                case "A":
                    objProduct.id = ProductId;
                    objProduct.price = 50;                    

                    break;
                case "B":
                    objProduct.id = ProductId;
                    objProduct.price = 30;   
                    break;
                case "C":
                    objProduct.id = ProductId;                
                    objProduct.price = 20;                    

                    break;
                case "D":
                    objProduct.id = ProductId;
                    objProduct.price = 15;                     
                    break;
            }

            return objProduct;
        }

    }
}

 
