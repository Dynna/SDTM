using System;

namespace lab1_SDTM
{
    class Program
    {
        static void Main(string[] args)
        {
            Client xiaomiClient;
            Client hpClient;
            Factory factory = Factory.getFactoryInstance();
            factory.manufactureDevice();

            Console.WriteLine("");
            xiaomiClient = new Client(new XiaomiFactory(), "Mi");
            Console.WriteLine(xiaomiClient.GetManufacturedSmartphoneName() + " as Mi Smartphone");
            Console.WriteLine(xiaomiClient.GetManufacturedTabletName() + " as Mi Tablet");
            xiaomiClient = new Client(new XiaomiFactory(), "Redmi");
            Console.WriteLine(xiaomiClient.GetManufacturedSmartphoneName() + " as Redmi Smartphone");
            Console.WriteLine(xiaomiClient.GetManufacturedTabletName() + " as Redmi Tablet");

            hpClient = new Client(new HpFactory(), "Slate");
            Console.WriteLine(hpClient.GetManufacturedSmartphoneName() + " as Slate Smartphone");
            Console.WriteLine(hpClient.GetManufacturedTabletName() + " as Slate Tablet");
            hpClient = new Client(new HpFactory(), "Elite");
            Console.WriteLine(hpClient.GetManufacturedSmartphoneName() + " as Elite Smartphone");
            Console.WriteLine(hpClient.GetManufacturedTabletName() + " as Elite Tablet");

            factory.preparePackage();

            Package package_phone;
            PackageDirector packagePhoneDirector = new PackageDirector();
            SmartphonePackageBuilder smartphone = new SmartphonePackageBuilder();
            package_phone = packagePhoneDirector.MakePackage(smartphone);
            Console.WriteLine("\n1. " + package_phone.ShowPackageDetails());

            Package package_tablet;
            PackageDirector packageTabletDirector = new PackageDirector();
            TabletPackageBuilder tablet = new TabletPackageBuilder();
            package_tablet = packageTabletDirector.MakePackage(tablet);
            Console.WriteLine("\n2. " + package_tablet.ShowPackageDetails());

            Console.ReadLine();
        }
    }
}
