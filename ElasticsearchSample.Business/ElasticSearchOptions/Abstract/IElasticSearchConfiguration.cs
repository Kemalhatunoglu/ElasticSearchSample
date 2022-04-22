namespace ElasticsearchSample.Business.ElasticSearchOptions.Abstract
{
    public interface IElasticSearchConfiguration
    {
        string ConnectionString { get; }
        string AuthUserName { get; }
        string AuthPassword { get; }
    }
}
