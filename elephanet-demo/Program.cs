using System;
using Nancy.Hosting.Self;

namespace elephanet_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            HostConfiguration config = new HostConfiguration();
            config.UrlReservations.CreateAutomatically = true;
            var port = 1234;

            using (var host = new NancyHost(config, new Uri(string.Format("http://localhost:{0}", port))))
            {
                host.Start();
                //load up the database with all our toilets from file
                Seed.Run(Database.ConnectionString());
                Console.WriteLine("Nancy self host running on port {0}, press Enter to exit", port);
                Console.ReadLine();
            }
        }
    }
}
