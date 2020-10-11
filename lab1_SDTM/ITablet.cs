namespace lab1_SDTM
{
    // Abstract product for manufacturing Tablet
    public interface ITablet
    {
        string Name();
    }

    // Concrete products for their abstract products
    public class XiaomiMiTablet : ITablet
    {
        public string Name()
        {
            return "Xiaomi Mi Pad 4 Plus";
        }
    }

    public class XiaomiRedmiTablet : ITablet
    {
        public string Name()
        {
            return "Xiaomi Redmi Pad 5G";
        }
    }

    public class HpSlateTablet : ITablet
    {
        public string Name()
        {
            return "HP Slate 2800";
        }
    }

    public class HpEliteTablet : ITablet
    {
        public string Name()
        {
            return "HP Elite x2 G4";
        }
    }
}