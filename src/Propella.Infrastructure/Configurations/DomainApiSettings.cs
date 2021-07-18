using Propella.Application.Configurations;

namespace Propella.Infrastructure.Configurations
{
    public class DomainApiSettings : IHavePath
    {
        public string Path => "Integrations:Domain";

        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
    }
}