using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassSerializationXML
{

    public class ShoppingCartItem 

    {
        public int productId;
        public decimal price;
        public int quantity;
        public Car car;
        public decimal total;
        public CarType carType;


        public bool taxable;
        public ShoppingCartItem(int _productId, decimal _price, int _quantity)
            : this()
        {
            productId = _productId;
            price = _price;
            quantity = _quantity;
        }

        public ShoppingCartItem() 
        {
            carType = new CarType();
        }


    }
}