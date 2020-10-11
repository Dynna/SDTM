namespace lab1_SDTM
{
    // Abstract product for manufacturing Smartphone
    public interface ISmartphone
    {
        string Name();
    }

    // Concrete products for their abstract products
    public class XiaomiMiSmartphone : ISmartphone
    {
        public string Name()
        {
            return "Xiaomi Mi6X";
        }
    }

    public class XiaomiRedmiSmartphone : ISmartphone
    {
        public string Name()
        {
            return "Xiaomi Redmi 9A";
        }
    }

    public class HpSlateSmartphone : ISmartphone
    {
        public string Name()
        {
            return "HP Slate 6 VoiceTab II ";
        }
    }

    public class HpEliteSmartphone : ISmartphone
    {
        public string Name()
        {
            return "HP Elite X3";
        }
    }
}