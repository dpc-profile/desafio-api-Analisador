using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AnalisadorDados.Repository;

public static class Extension
{
    public static TBuilder RepositoryExtension<TBuilder>(this TBuilder builder) 
        where TBuilder : IHostApplicationBuilder
    {
        builder.Services.AddDbContext<MainDbContext>(o => o.UseInMemoryDatabase("niisan"));

        return builder;
    }
}

