using ElasticsearchSample.Business.ElasticSearchOptions.Abstract;
using Microsoft.Extensions.Configuration;

namespace ElasticsearchSample.Business.ElasticSearchOptions.Concrete
{
    public class ElasticSearchConfiguration : IElasticSearchConfiguration
    {
        public IConfiguration Configuration { get; }

        public ElasticSearchConfiguration(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public string ConnectionString { get { return Configuration.GetSection("ElasticSearchOption:ConnectionString:HostUrls").Value; } }

        public string AuthUserName { get { return Configuration.GetSection("ElasticSearchOption:ConnectionString:UserName").Value; } }

        public string AuthPassword { get { return Configuration.GetSection("ElasticSearchOption:ConnectionString:Password").Value; } }
    }
}
