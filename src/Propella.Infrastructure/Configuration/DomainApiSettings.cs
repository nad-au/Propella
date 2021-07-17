using Propella.Domain.Configuration;

namespace Propella.Infrastructure.Configuration
{
    public class DomainApiSettings : IHavePath
    {
        public string Path => "Integrations:Domain";

        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
    }
}