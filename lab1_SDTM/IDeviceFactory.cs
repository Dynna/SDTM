using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_SDTM
{
    // Abstract device factory
    interface IDeviceFactory
    {
        ISmartphone ManufactureSmartphone(string series);
        ITablet ManufactureTablet(string series);
    }

    // Concrete factories for Xiaomi and HP which implement the abstract factory to manufacture devices
    public class XiaomiFactory : IDeviceFactory
    {
        public ISmartphone ManufactureSmartphone(string series)
        {
            switch (series)
            {
                case "Mi":
                    return new XiaomiMiSmartphone();
                case "Redmi":
                    return new XiaomiRedmiSmartphone();
                default:
                    throw new Exception();
            }
        }

        public ITablet ManufactureTablet(string series)
        {
            switch (series)
            {
                case "Mi":
                    return new XiaomiMiTablet();
                case "Redmi":
                    return new XiaomiRedmiTablet();
                default:
                    throw new Exception();
            }
        }
    }

    public class HpFactory : IDeviceFactory
    {
        public ISmartphone ManufactureSmartphone(string series)
        {
            switch (series)
            {
                case "Slate":
                    return new HpSlateSmartphone();
                case "Elite":
                    return new HpEliteSmartphone();
                default:
                    throw new Exception();
            }
        }

        public ITablet ManufactureTablet(string series)
        {
            switch (series)
            {
                case "Slate":
                    return new HpSlateTablet();
                case "Elite":
                    return new HpEliteTablet();
                default:
                    throw new Exception();
            }
        }
    }
}
