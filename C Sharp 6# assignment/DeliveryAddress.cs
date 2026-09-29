using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_6__assignment
{
    internal struct DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildingNumber;
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            return $"{BuildingNumber} {Street} street {City} city";
        }
    }
}
