namespace C_Sharp_6__assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Question

            //1- class is a reference type but struct is a value type and when struct is a assigned it only copys the value while class copies the value
            //2- classes are great for memory mangment since it only stores its address in stack beside supporting inheritance which allows better coding

            #endregion

            #region Second Question

            //1-Shipment
            //2-ExpressShipment
            //3-TrackingCode
            //4-for better maintanance

            #endregion
            #region Practical

            DeliveryCenter deliveryCenter = new DeliveryCenter();
            Console.Write("Enter the delivery center name: ");
            deliveryCenter.CenterName = Console.ReadLine()!;

            for (int i = 1; i <= 3; i++)
            {
                string TrackingCode = Console.ReadLine()!;
                string Description = Console.ReadLine()!;
                decimal Weight = decimal.Parse(Console.ReadLine()!);
                decimal DeliveryFee = decimal.Parse(Console.ReadLine()!);
                string City = Console.ReadLine()!;
                string street = Console.ReadLine()!;
                int buildingNumber = int.Parse(Console.ReadLine()!);
                DeliveryAddress deliveryAddress = new DeliveryAddress(City,street,buildingNumber);

                if (i == 1)
                {
                    StandardShipment standardShipment = new StandardShipment(TrackingCode,Description,Weight,DeliveryFee,deliveryAddress);
                    deliveryCenter.AddShipment(standardShipment);
                }
                else if (i == 2)
                {
                    decimal ExtraFee = decimal.Parse(Console.ReadLine()!);
                    ExpressShipment expressShipment = new ExpressShipment(TrackingCode, Description, Weight, DeliveryFee, deliveryAddress, ExtraFee);
                    deliveryCenter.AddShipment(expressShipment);
                }
                else
                {
                    string DestinationCountry = Console.ReadLine()!;
                    decimal CustomFee = decimal.Parse(Console.ReadLine()!);
                    InternationalShipment internationalShipment = new InternationalShipment(TrackingCode, Description, Weight, DeliveryFee, deliveryAddress, DestinationCountry, CustomFee);
                    deliveryCenter.AddShipment(internationalShipment);
                }
                Console.WriteLine("Shipment added successfully.");

            }

            for (int i = 0; i < deliveryCenter.CurrentItems; i++)
            {
                Console.WriteLine("=====================");
                deliveryCenter[i].PrintShipment();
                Console.WriteLine("=====================\n");
            }

            string SearchTrackingCode = Console.ReadLine()!;
            deliveryCenter[SearchTrackingCode].PrintShipment();

            deliveryCenter.RemoveShipment(SearchTrackingCode);

            for (int i = 0;i < deliveryCenter.CurrentItems;i++)
            {
                if (deliveryCenter[i] != null)
                {
                    deliveryCenter[i].PrintShipment();
                }
            }


            #endregion
        }
    }
}
