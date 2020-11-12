using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_SDTM
{
    class PackageDirector
    {
        public Package MakePackage(PackageBuilder packageBuilder)
        {
            packageBuilder.CreatePackage();

            packageBuilder.SetPackageType();
            packageBuilder.SetCharger();
            packageBuilder.SetDocumentation();
            packageBuilder.SetHeadphones();
            packageBuilder.SetCase();

            return packageBuilder.getPackage();
        }
    }
}
