using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace C_Sharp_6__assignment
{
    
    internal class DeliveryCenter
    {
        public int CurrentItems { get; private set; } = 0;
        private Shipment[] shipments;
        public string CenterName;

        public DeliveryCenter()
        {
            shipments = new Shipment[20];
        }
        public Shipment this[int index]
        {
            get
            {
                if (shipments != null && index > 0 && index < 10)
                {
                    return shipments[index];
                }
                return default;

            }
            set
            {
                if (shipments != null && index > 0 && index < 10)
                {
                    shipments[index] = value;
                }
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                if (shipments != null)
                {
                    return shipments.FirstOrDefault(x => x.TrackingCode == trackingCode);
                }
                return default;
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            if (shipments != null)
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] == null)
                    {
                        shipments[i] = shipment;
                        return true;
                    }
                }
            }
            return false;
        }
        public bool RemoveShipment(string TrackingCode)
        {
            if (Array.Exists(shipments,x =>x.TrackingCode == TrackingCode))
            {
                int index = Array.FindIndex(shipments, x => x.TrackingCode == TrackingCode);
                shipments[index] = null!;
                CurrentItems++;
                return true;
            }
            return false;
        }
    }
}
