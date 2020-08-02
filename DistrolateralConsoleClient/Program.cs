using DistrolateralServer;
using Grpc.Net.Client;
using System;

namespace DistrolateralConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:32772");
            var client = new Greeter.GreeterClient(channel);
            var request = new HelloRequest { Name = "Mark" };
            Console.Write(client.SayHello(request).Message);

            Console.ReadKey();
        }
    }
}
