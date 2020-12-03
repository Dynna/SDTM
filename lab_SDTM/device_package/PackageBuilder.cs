using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_SDTM
{
    abstract class PackageBuilder
    {
        protected Package package;

        public void CreatePackage()
        {
            package = new Package();
        }

        public Package getPackage()
        {
            return package;
        }

        public abstract void SetCharger();
        public abstract void SetDocumentation();
        public abstract void SetHeadphones();
        public abstract void SetCase();
        public abstract void SetPackageType();
    }
}
