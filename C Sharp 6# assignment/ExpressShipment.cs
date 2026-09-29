using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_6__assignment
{
    internal class ExpressShipment : Shipment
    {
        private decimal _extraFee;

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal delivaryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, delivaryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public decimal ExtraFee
        {
            get
            {
                return _extraFee;
            }
            set
            {
                if (value >= 0 )
                {
                    _extraFee = value;
                }
            }
        }
        public override decimal EstimatedCost => DeliveryFee + ExtraFee + (Weight * 5);

        public override void PrintShipment()
        {
            Console.WriteLine("ExpressShipment\n");
            
            base.PrintShipment();
        }
    }
}
