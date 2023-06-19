using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SerializableDemo
{
    [Serializable]
    internal class ShoppingCartItem : IDeserializationCallback

    {
        public int productId;
        public decimal price;
        public int quantity;
        [NonSerialized]
        public decimal total;

        [OptionalField]
        public bool taxable;
        public ShoppingCartItem(int _productId, decimal _price, int _quantity)
        {
            productId = _productId;
            price = _price;
            quantity = _quantity;
        }

        public void OnDeserialization(object sender)
        {
            total = price * quantity;
        }
    }
}
