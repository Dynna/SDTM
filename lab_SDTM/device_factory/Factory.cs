using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_SDTM
{
    class Factory
    {
        // Singleton pattern
        private Factory() { }

        private static Factory factoryInstance = null;
        private static object padlock = new object();

        public static Factory getFactoryInstance()
        {
            if (factoryInstance == null)
            {
                lock (padlock)
                {
                    if (factoryInstance == null)
                    {
                        factoryInstance = new Factory();
                    }
                }
            }

            return factoryInstance;
        }

        public void manufactureDevice()
        {
            Console.WriteLine("\nThe Factory manufactures the following devices: ");
        }

        public void preparePackage()
        {
            Console.WriteLine("\nThe Factory prepares the following packages: ");
        }
    }
}
