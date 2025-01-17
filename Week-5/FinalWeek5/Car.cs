  class Car
    {
        public DateTime ProductionDate { get; set; }
        public int SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int NumbersOfDoor { get; set; }

        public Car(int serialNumber, string brand, string model, string color, int numbersOfDoor, DateTime productionDate)
        {
            SerialNumber = serialNumber;
            Brand = brand;
            Model = model;
            Color = color;
            NumbersOfDoor = numbersOfDoor;
            ProductionDate = productionDate;
        }

        public void DisplayCar()
        {
            Console.WriteLine($"\nSeri Numarası: {SerialNumber}\nMarka: {Brand}\nModel: {Model}\nRenk: {Color}\nKapı Sayısı: {NumbersOfDoor}\nÜretim Tarihi: {ProductionDate}");
        }
    }
