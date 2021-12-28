using Microsoft.Extensions.DependencyInjection;

namespace WPFDatagridInTabControlMVVM.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainWindowModel => App.Services.GetRequiredService<MainWindowViewModel>();
    }
}
