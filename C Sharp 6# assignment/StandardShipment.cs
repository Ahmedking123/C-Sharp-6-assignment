using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace C_Sharp_6__assignment
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal delivaryFee, DeliveryAddress destination) : base(trackingCode, description, weight, delivaryFee, destination)
        {
            
        }
        public override void PrintShipment()
        {
            Console.WriteLine("Standerd shipment\n");
              base.PrintShipment();
        }
    }
}
