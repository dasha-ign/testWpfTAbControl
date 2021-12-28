using Microsoft.Extensions.DependencyInjection;
using WPFDatagridInTabControlMVVM.Services.Interfaces;

namespace WPFDatagridInTabControlMVVM.Services
{
    static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
           .AddTransient<IDataService, DataService>()
           .AddTransient<IUserDialog, UserDialog>()
        ;
    }
}
