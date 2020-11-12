using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_SDTM
{
    class Package
    {
        public string Charger { get; set; }
        public string Documentation { get; set; }
        public string Headphones { get; set; }
        public string Case { get; set; }
        public string PackageType { get; set; }

        public string ShowPackageDetails()
        {
            return "Package type: " + PackageType + ";\nCharger: " + Charger + ";\nDocumentation: " + Documentation + ";\nHeadphones: " + Headphones + ";\nCase: " + Case;
        }
    }
}
