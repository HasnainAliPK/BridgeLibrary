namespace BridgeLibrary
{
    public abstract class Vehicle
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        public abstract double Price();
        public abstract string VehicleType();
    }
}
