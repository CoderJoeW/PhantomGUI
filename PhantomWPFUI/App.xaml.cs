using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using PhantomLib.Services;
using PhantomWPFUI.Services;
using PhantomWPFUI.ViewModels;
using PhantomWPFUI.Views;

namespace PhantomWPFUI
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceProvider = GetServiceProvider();

            var mainWindow = new MainWindow
            {
                DataContext = serviceProvider.GetRequiredService<MainWindowViewModel>()
            };
            mainWindow.Show();

            base.OnStartup(e);
        }

        private static IServiceProvider GetServiceProvider() =>
            new ServiceCollection()
                .AddSingleton<MainWindowViewModel>()
                .AddSingleton<PhantomFactory>()
                .AddSingleton<PhantomRunner>()
                .AddSingleton<IDialogService, DialogService>()
                .BuildServiceProvider();
    }
}
