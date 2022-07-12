using System;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace RabbitMQ.Producer
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var factory = new ConnectionFactory { Uri = new Uri("amqp://guest:13579630@localhost:5672") };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            DirectExchangePublisher.Publish(channel);

        }
    }
}
