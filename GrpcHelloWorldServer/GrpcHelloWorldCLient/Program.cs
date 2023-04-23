﻿using Grpc.Net.Client;
using GrpcHelloWorldClient.Protos;
using System;
using System.Threading.Tasks;

namespace GrpcHelloWorldCLient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new HelloService.HelloServiceClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "GreeterClient" });
            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
