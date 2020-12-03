using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_SDTM
{
    class TabletPackageBuilder : PackageBuilder
    {
        public override void SetCharger()
        {
            getPackage().Charger = "Micro-USB";
        }

        public override void SetDocumentation()
        {
            getPackage().Documentation = "2 years of guarantee";
        }

        public override void SetHeadphones()
        {
            getPackage().Headphones = "Earbuds";
        }

        public override void SetCase()
        {
            getPackage().Case = "1, book case cover";
        }

        public override void SetPackageType()
        {
            getPackage().PackageType = "Tablet";
        }
    }
}
