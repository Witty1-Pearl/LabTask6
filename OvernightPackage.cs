using System;
namespace PolymorphismTest
{
    public class OvernightPackage : Package
    {
        private decimal overNightPackageCost;

        public OvernightPackage(string senderAddress, string recieverAddress, decimal overNightPackageCost) : base(senderAddress, recieverAddress)
        {
            OverNightPackageCost = overNightPackageCost;
        }

        public decimal OverNightPackageCost
        {
            get { return overNightPackageCost; }

            private set
            {
                if (value > 0)
                {
                    overNightPackageCost = value;
                } else {
                
                    throw new ArgumentOutOfRangeException("Over Night Package Cost", value, "Must be greater than 0");
                }
            }
        }

        public override decimal CalculateCost()
        {
            return OverNightPackageCost;
        }

        public override string ToString()
        {
            return $"\n=======OverNight Package========\n{base.ToString()}\nOver Night Package Cost: {OverNightPackageCost:C}";
        }
    }
}