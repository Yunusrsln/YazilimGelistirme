

internal class AutofacServiceProviderFactory : IServiceProviderFactory<object>
{
    public object CreateBuilder(IServiceCollection services)
    {
        throw new NotImplementedException();
    }

    public IServiceProvider CreateServiceProvider(object containerBuilder)
    {
        throw new NotImplementedException();
    }
}