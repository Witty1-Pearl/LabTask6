using System;
namespace PolymorphismTest
{
    public class TwoDayPackage : Package
    {
        private decimal shippingCost;

        public TwoDayPackage(string senderAddress, string recieverAddress, decimal shippingCost) : base(senderAddress, recieverAddress)
        {
            ShippingCost = shippingCost;
        }

        public decimal ShippingCost
        {
            get { return shippingCost; }

            private set
            {
                if (value > 0)
                {
                    shippingCost = value;
                } else {
                
                throw new ArgumentOutOfRangeException("shipping Cost", value, "Must be greater than 0");
               
                }
            }
        }

        public override decimal CalculateCost()
        {
            return ShippingCost;
        }

        public override string ToString()
        {
            return $"\n========Two Day Package=========\n{base.ToString()}\nTwo Day Package Cost: {ShippingCost:C}";
        }

    }
}