using Grpc.Net.Client;
using GrpcService1;
using System;
using System.Threading.Tasks;

namespace grpcclient
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            //var channel = GrpcChannel.ForAddress("https://192.168.31.114:50001");
            var channel = GrpcChannel.ForAddress("https://192.168.31.114:443");
            var client = new Greeter.GreeterClient(channel);

            while (true)
            {
                var reply = await client.SayHelloAsync(
                             new HelloRequest { Name = "GreeterClient" });
                Console.WriteLine("Greeting: " + reply.Message);
                await Task.Delay(500);
            }
        }
    }
}
