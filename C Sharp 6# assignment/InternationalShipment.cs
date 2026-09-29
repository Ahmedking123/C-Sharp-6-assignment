using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace C_Sharp_6__assignment
{
    internal class InternationalShipment : Shipment
    {
        private string _destinationCountry;
        public string DestinationCountry
        {
            get
            {
                return _destinationCountry;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value != "")
                {
                    _destinationCountry = value;
                }
            }
        }
        private decimal _customsFee;

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal delivaryFee, DeliveryAddress destination,string destinationCountry,decimal CustomsFee) : base(trackingCode, description, weight, delivaryFee, destination)
        {
            DestinationCountry = destinationCountry;
            this.CustomsFee = CustomsFee;
        }

        public decimal CustomsFee
        {
            get
            {
                return _customsFee;
            }
            set
            {
                if (value >= 0)
                {
                    _customsFee = value;
                }
            }
        }
        public override decimal EstimatedCost => base.EstimatedCost + CustomsFee;

        public override void PrintShipment()
        {
            Console.WriteLine("International shipment \n");
            base.PrintShipment();
        }
    }
}
