using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TransactionManagement.ApplicationService.Application.ManagementServices;
using TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService;
using TransactionManagement.ApplicationService.ManagementServices.UserManagementServices;
using TransactionManagement.Infrastructure.DependencyInjection;
using TransactionManagement.WinFormApp.Views;

namespace TransactionManagement.WinFormApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IServiceCollection services = new ServiceCollection();

            services
                .AddInfrastructure()
                .AddTransient<IDocumentTypeManagementService, DocumentTypeManagementService>()
                .AddSingleton<IUserManagementService, UserManagementServices>()
                .AddSingleton<IBankManagementService,BankManagementService>()
                .AddTransient<DashBoard>();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                DashBoard dashBoard = serviceProvider.GetRequiredService<DashBoard>();
                Application.Run(dashBoard);
            }
        }
    }
}
