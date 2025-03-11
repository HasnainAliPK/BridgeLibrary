namespace BridgeLibrary
{
    public abstract class Vehicle
    {
        private string _licenseplate;

        public string Licenseplate
        {
            get => _licenseplate;
            set
            {
                if (value.Length > 7)
                    throw new ArgumentException("License plate cannot be longer than 7 characters.");
                _licenseplate = value;
            }
        }

        public DateTime Date { get; set; }

        public abstract double Price();
        public abstract string VehicleType();
    }
}
