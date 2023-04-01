using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Xpto.Core.Customers;
using Xpto.Core.Shared.Entities.Addresses;
using Xpto.Core.Shared.Entities.Emails;
using Xpto.Core.Shared.Entities.Phones;
using Xpto.Repositories.Addresses;
using Xpto.Repositories.Customers;
using Xpto.Repositories.Emails;
using Xpto.Repositories.Phones;
using Xpto.Repositories.Shared.Sql;
using Xpto.Services.Addresses;
using Xpto.Services.Customers;
using Xpto.Services.Emails;
using Xpto.Services.Phones;

namespace Xpto.UI
{
    internal static class Program
    {
 
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            ApplicationConfiguration.Initialize();

            Application.Run(ServiceProvider.GetRequiredService<FrmApp>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
      
                    services.AddTransient<FrmApp>();
                    services.AddTransient<FrmCustomerRegister>();
                    services.AddTransient<FrmCustomerSearch>();

                    services.AddTransient<SqlConnectionProvider>(_ => new SqlConnectionProvider("server=localhost;database=db_xpto;user=xpto;password=1q2w3e4r"));
                    services.AddTransient<ICustomerRepository, CustomerRepository>();
                    services.AddTransient<ICustomerService, CustomerService>();
                    services.AddTransient<IAddressRepository, AddressRepository>();
                    services.AddTransient<IAddressService, AddressService>();
                    services.AddTransient<IPhoneRepository, PhoneRepository>();
                    services.AddTransient<IPhoneService, PhoneService>();
                    services.AddTransient<IEmailRepository, EmailsRepository>();
                    services.AddTransient<IEmailService, EmailService>();


                });
        }
    }
}