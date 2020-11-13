using design_patterns.client;
using design_patterns.device;
using design_patterns.device_factory;
using design_patterns.device_package;
using design_patterns.order;
using System;
using System.Security.Cryptography.X509Certificates;

namespace lab1_SDTM
{
    class Program
    {
        internal static string model;

        static void Main(string[] args)
        {
            Client xiaomiClient;
            Client hpClient;
            Factory factory = Factory.getFactoryInstance();
            factory.manufactureDevice();

            Console.WriteLine("");
            xiaomiClient = new Client(new XiaomiFactory(), "Mi");
            Console.WriteLine(xiaomiClient.GetManufacturedSmartphoneName());
            Console.WriteLine(xiaomiClient.GetManufacturedTabletName());
            xiaomiClient = new Client(new XiaomiFactory(), "Redmi");
            Console.WriteLine(xiaomiClient.GetManufacturedSmartphoneName());
            Console.WriteLine(xiaomiClient.GetManufacturedTabletName());

            hpClient = new Client(new HpFactory(), "Slate");
            Console.WriteLine(hpClient.GetManufacturedSmartphoneName());
            Console.WriteLine(hpClient.GetManufacturedTabletName());
            hpClient = new Client(new HpFactory(), "Elite");
            Console.WriteLine(hpClient.GetManufacturedSmartphoneName());
            Console.WriteLine(hpClient.GetManufacturedTabletName());

            Console.WriteLine("=========================================================================");

            Console.WriteLine("Please type in a device model you want to purchase from the list above:");
            model = Console.ReadLine();

            PackageAdaptee adaptee = new PackageAdaptee();
            IClient client = new PackageAdapter(adaptee);


            if (model.Contains("Xiaomi Mi6X") || model.Contains("Xiaomi Redmi 9A") || model.Contains("HP Slate 6 VoiceTab II") || model.Contains("HP Elite X3"))
            {
                Console.WriteLine("\nThis is your package for " + model + " ready to deliver!");

                Package package_phone;
                PackageDirector packagePhoneDirector = new PackageDirector();
                SmartphonePackageBuilder smartphone = new SmartphonePackageBuilder();
                package_phone = packagePhoneDirector.MakePackage(smartphone);
                Console.WriteLine("\n" + package_phone.ShowPackageDetails());

                Console.WriteLine(client.GetRequest());

                Console.WriteLine("\nDevice feedback given by customers:");
                OpenToFeedback rateDevice = new OpenToFeedback(new Smartphone(model, "4.5/5", 10));
                rateDevice.RateItem("Danette Windsor");
                rateDevice.RateItem("Elise Abdulla");
                rateDevice.RateItem("Joep Adam");
                rateDevice.Display();

            } else if (model.Contains("Xiaomi Mi Pad 4 Plus") || model.Contains("HP Slate 2800") || model.Contains("Xiaomi Redmi Pad 5G") || model.Contains("HP Elite x2 G4"))
            {
                Console.WriteLine("\nThis is your package for " + model + " ready to deliver!");

                Package package_tablet;
                PackageDirector packageTabletDirector = new PackageDirector();
                TabletPackageBuilder tablet = new TabletPackageBuilder();
                package_tablet = packageTabletDirector.MakePackage(tablet);
                Console.WriteLine("\n" + package_tablet.ShowPackageDetails());

                Console.WriteLine(client.GetRequest());

                Console.WriteLine("\nDevice feedback given by customers:");
                OpenToFeedback rateDevice = new OpenToFeedback(new Tablet(model, "4.8/5", 10));
                rateDevice.RateItem("Adriana Eline");
                rateDevice.RateItem("Ziyaeddin Lyna");
                rateDevice.RateItem("Laila Lylou");
                rateDevice.Display();

            } else
            {
                Console.WriteLine("Sorry, we do not manufacture such device model!");
            }

            Console.WriteLine("\n=========================================================================");
            CompositeOrder order = new CompositeOrder("Orders for " + DateTime.Now.ToString("M/d/yyyy"));

            order.Add(new PrimitiveElement(model));
            order.Add(new PrimitiveElement("HP Slate 2800"));
            order.Add(new PrimitiveElement("Xiaomi Mi Pad 4 Plus"));

            CompositeOrder dev1 = new CompositeOrder(model);
            dev1.Add(new PrimitiveElement(adaptee.GetColor()));
            dev1.Add(new PrimitiveElement(adaptee.GetSpecification()));

            CompositeOrder dev2 = new CompositeOrder("HP Slate 2800");
            dev2.Add(new PrimitiveElement("blue"));
            dev2.Add(new PrimitiveElement("IPS LCD, 4/16 version"));

            CompositeOrder dev3 = new CompositeOrder("Xiaomi Mi Pad 4 Plus");
            dev3.Add(new PrimitiveElement("gray"));
            dev3.Add(new PrimitiveElement("IPS LCD, 8/128 version"));

            order.Add(dev1);
            order.Add(dev2);
            order.Add(dev3);

            order.Display(1);
/*
            Console.WriteLine("\nDevice feedback given by customers:");
            OpenToFeedback rateDevice = new OpenToFeedback(new Smartphone(model, "4.5/5", 10));
            rateDevice.RateItem("Danette Windsor");
            rateDevice.RateItem("Elise Abdulla");
            rateDevice.RateItem("Joep Adam");*/

            

            Console.ReadLine();
        }
    }
}
