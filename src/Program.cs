using Microsoft.AspNetCore.Hosting;
using Serilog;

namespace HelloUniverse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Serilog.Log.Logger = new Serilog
                                        .LoggerConfiguration()
                                        .MinimumLevel.Debug()
                                        .Enrich.FromLogContext()
                                        .WriteTo.LiterateConsole()
                                        .CreateLogger();
            var test = string.Format("Hello World");

            var host = new WebHostBuilder()
                          .UseKestrel()
                          .UseStartup<Startup>()
                          .UseUrls(new [] { "http://*:5000" })
                          .Build();
            host.Run();
        }
    }
}
