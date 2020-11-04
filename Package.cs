using System;

namespace PolymorphismTest
{
    public abstract class Package
    {

            public string SenderAddress { get; set; }
            public string RecieverAddress { get; set; }

            public Package(string senderAddress, string recieverAddress)
            {
                SenderAddress = senderAddress;
                RecieverAddress = recieverAddress;
            }
            public abstract decimal CalculateCost();

            public override string ToString()
            {
                return $"Sender address : {SenderAddress}\nReciever address: {RecieverAddress}";
            }

    }
}