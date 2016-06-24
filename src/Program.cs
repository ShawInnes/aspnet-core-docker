using Microsoft.AspNetCore.Hosting;

namespace HelloUniverse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Serilog.Log.Logger = new Serilog
                                        .LoggerConfiguration()
                                        .MinimumLevel.Debug()
                                        .CreateLogger();

            var host = new WebHostBuilder()
                          .UseKestrel()
                          .UseStartup<Startup>()
                          .UseUrls(new [] { "http://*:5000" })
                          .Build();
            host.Run();
        }
    }
}
