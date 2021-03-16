using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService;
using TransactionManagement.ApplicationService.ManagementServices.PersonManagementService;
using TransactionManagement.ApplicationService.ManagementServices.PersonManagementService.Icumbent;
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
                .AddTransient<IIncumbentManagementService, IncumbentManagementService>()
                .AddTransient<IDocumentTypeManagementService,DocumentTypeManagementService>()
                .AddTransient<DashBoard>();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                DashBoard dashBoard = serviceProvider.GetRequiredService<DashBoard>();
                Application.Run(dashBoard);
            }
        }
    }
}
