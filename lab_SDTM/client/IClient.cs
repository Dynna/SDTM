using design_patterns.device_factory;
using design_patterns.device_package;

namespace design_patterns.client
{
    interface IClient
    {
        string GetRequest();
        void Update(Stock stock);
    }
}
