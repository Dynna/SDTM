using design_patterns.device_factory;
using design_patterns.client;
using lab1_SDTM;

namespace design_patterns.device_package
{
    class PackageAdapter : IClient
    {
        private readonly PackageAdaptee _adaptee;

        public PackageAdapter(PackageAdaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
             return $"Specifications: {this._adaptee.GetSpecification()}\nColor: {this._adaptee.GetColor()}";
        }

        public void Update(Stock stock) { }
    }
}
