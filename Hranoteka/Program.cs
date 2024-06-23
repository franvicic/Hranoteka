using Hranoteka.Controllers;
using Hranoteka.Data;
using Hranoteka.Repositories;
using Hranoteka.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Hranoteka
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();

            //ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

            // controller
            var mainController = host.Services.GetRequiredService<MainController>();

            // views
            var mainForm = host.Services.GetRequiredService<IMainForm>() as Form;
            var loginForm = host.Services.GetRequiredService<ILoginForm>() as Form;
            var registrationForm = host.Services.GetRequiredService<IRegistrationForm>() as Form;


            while (mainController.AppState != AppStates.Main)
            {
                if (mainController.AppState == AppStates.Login)
                {
                    loginForm.ShowDialog();
                    if (mainController.AppState == AppStates.Login) break;
                }
                else if (mainController.AppState == AppStates.Registration)
                {
                    registrationForm.ShowDialog();
                    if (mainController.AppState == AppStates.Registration) break;
                }
                else
                {
                    break;
                }
            }

            if (mainController.AppState == AppStates.Main)
            {
                Application.Run(mainForm);
            }
        }

        public static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory());
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    // ConfigureServices method is called here
                    ConfigureServices(context.Configuration, services);
                });

        private static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            // database
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // repositories
            services.AddScoped<UserRepository>();
            services.AddScoped<RecipeRepository>();
            services.AddScoped<CommentRepository>();
            services.AddScoped<CategoryRepository>();
            services.AddScoped<UnitRepository>();
            services.AddScoped<IngredientRepository>();

            // controllers
            services.AddScoped<MainController>();

            // views
            services.AddScoped<IMainForm, MainForm>();
            services.AddScoped<ILoginForm, LoginForm>();
            services.AddScoped<IRegistrationForm, RegistrationForm>();
            services.AddScoped<IProfileForm, ProfileForm>();
            services.AddScoped<IEditRecipeForm, EditRecipeForm>();
            services.AddScoped<IRecipeDetailsForm, RecipeDetailsForm>();
        }
    }


    //internal static class Program
    //{
    //    /// <summary>
    //    ///  The main entry point for the application.
    //    /// </summary>
    //    [STAThread]
    //    static void Main()
    //    {

    //        // To customize application configuration such as set high DPI settings or default font,
    //        // see https://aka.ms/applicationconfiguration.
    //        ApplicationConfiguration.Initialize();

    //        var startup = new Startup();
    //        var serviceProvider = startup.BuildServiceProvider();

    //        // controllers
    //        var mainController = serviceProvider.GetRequiredService<MainController>();

    //        // views
    //        var mainForm = serviceProvider.GetRequiredService<IMainForm>() as Form;
    //        var loginForm = serviceProvider.GetRequiredService<ILoginForm>() as Form;
    //        var registrationForm = serviceProvider.GetRequiredService<IRegistrationForm>() as Form;

    //        while(mainController.AppState != AppStates.Main)
    //        {
    //            if (mainController.AppState == AppStates.Login)
    //            {
    //                loginForm.ShowDialog();
    //                if (mainController.AppState == AppStates.Login) break;
    //            }
    //            else if (mainController.AppState == AppStates.Registration)
    //            {
    //                registrationForm.ShowDialog();
    //                if (mainController.AppState == AppStates.Registration) break;
    //            }
    //            else
    //            {
    //                break;
    //            }
    //        }

    //        if (mainController.AppState == AppStates.Main)
    //        {
    //            Application.Run(mainForm);
    //        }

    //    }
    //}
}