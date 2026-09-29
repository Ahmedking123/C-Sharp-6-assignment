using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace C_Sharp_6__assignment
{
    internal class Shipment
    {
        private string? _trackingCode;

        public string? TrackingCode
        {
            get
            {
                return _trackingCode;
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _trackingCode = value;
                }
            }
        }
        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _description = value;
                }
            }
        }
        private decimal _weight;
        public decimal Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }
        private decimal _DeliveryFee;
        public decimal DeliveryFee
        {
            get
            {
                return _DeliveryFee;
            }
            set
            {
                if (value > 0)
                {
                    _DeliveryFee = value;
                }
            }
        }
        public DeliveryAddress Destination { get; set; }

        public virtual decimal EstimatedCost => DeliveryFee + (Weight * 5);

        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
        }
        public Shipment(string trackingCode, string description, decimal weight, decimal delivaryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = delivaryFee;
            Destination = destination;
        }
        
        public void UpdateDelivaryFee(decimal newDelivaryFee)
        {
            if (newDelivaryFee > 0)
            {
                DeliveryFee = newDelivaryFee;
            }
        }
        public virtual void PrintShipment()
        {
            Console.WriteLine($"""
                Tracking Code: {TrackingCode}
                Description: {Description} 
                Weight: {Weight}
                Delivery Fee: {DeliveryFee}
                Destination: {Destination.GetFullAddress()}
                Estimated Cost: {EstimatedCost} EGP
                """);
        }
    }
}
