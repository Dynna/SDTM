using lab1_SDTM;

namespace design_patterns.device_factory
{
    class PackageAdaptee
    {
        string deviceModel = Program.model;

        public string GetSpecification()
        {
            switch(deviceModel)
            {
                case "Xiaomi Mi6X":
                    return "AMOLED display, 6/64 version";
                case "HP Slate 2800":
                    return "IPS LCD, 4/16 version";
                case "Xiaomi Mi Pad 4 Plus":
                    return "IPS LCD, 8/128 version";
                case "Xiaomi Redmi 9A":
                    return "IPS LCD, 400 nits (typ), 4/16 version";
                case "Xiaomi Redmi Pad 5G":
                    return "Snapdragon 765G, Octa Core, 2.4 GHz Processor, 16/256 version";
                case "HP Slate 6 VoiceTab II":
                    return "IPS LCD, Android 4.3 (Jelly Bean), 8/128 version";
                case "HP Elite X3":
                    return "TFT, Corning Gorilla Glass 4, 6/128 version";
                case "HP Elite x2 G4":
                    return "Intel Core i7-8665U vPro processor, 16/256 version";
                default:
                    return "No such device.";
            }
        }

        public string GetColor()
        {
            switch (deviceModel)
            {
                case "Xiaomi Mi6X":
                    return "pink";
                case "HP Slate 2800":
                    return "blue";
                case "Xiaomi Mi Pad 4 Plus":
                    return "gray";
                case "Xiaomi Redmi 9A":
                    return "black";
                case "Xiaomi Redmi Pad 5G":
                    return "red";
                case "HP Slate 6 VoiceTab II":
                    return "green";
                case "HP Elite X3":
                    return "gradient";
                case "HP Elite x2 G4":
                    return "white";
                default:
                    return "No such device.";
            }
        }
    }
}
