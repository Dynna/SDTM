using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_SDTM
{
    class SmartphonePackageBuilder : PackageBuilder
    {
        public override void SetCharger()
        {
            getPackage().Charger = "Type-C";
        }

        public override void SetDocumentation()
        {
            getPackage().Documentation = "12 months of guarantee";
        }

        public override void SetHeadphones()
        {
            getPackage().Headphones = "Classic";
        }

        public override void SetCase()
        {
            getPackage().Case = "2, silicone";
        }

        public override void SetPackageType()
        {
            getPackage().PackageType = "Smartphone";
        }
    }
}
