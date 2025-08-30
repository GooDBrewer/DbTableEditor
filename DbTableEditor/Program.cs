using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;
using Npgsql;


namespace DbTableEditor
{
    internal static class Program
    {

        public static IServiceProvider ServiceProvider { get; private set; }
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using var connectionForm = new ConnectionForm();
            if(connectionForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            //подключаю DI
            var services = new ServiceCollection();
            string connectionString = connectionForm.ConnectionString;
            services.AddSingleton(new DatabaseConfig { ConnectionString = connectionString });
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();


            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }
        /// <summary>
        /// Регистрируем наши сервисы и репозитории и формыы
        /// </summary>
        /// <param name="services"></param>
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<ITableRepository, TableRepository>();
            services.AddScoped<ITableService, TableService>();

            services.AddTransient<MainForm>(); 
            services.AddTransient<CreateTableForm>();
            services.AddTransient<UpdateForm>();
        }
    }
}