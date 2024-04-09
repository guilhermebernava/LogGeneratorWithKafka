using Confluent.Kafka;
using LogGenerator.Helpers;
using LogGenerator.Interfaces;
using Microsoft.Extensions.Configuration;

namespace LogGenerator;
public class Producer : IProducer
{
    private ProducerConfig _config { get; set; }
    private string _topic {  get; set; }

    public Producer(IConfiguration configuration)
    {
        _config = new ProducerConfig { BootstrapServers = configuration["Kafka"]! };
        _topic = configuration["TopicName"]!;
    }

    public async Task SendAsync(string data)
    {
        using (var p = new ProducerBuilder<string, string>(_config).Build())
        {
            try
            {
                var dr = await p.ProduceAsync(_topic, new Message<string, string> { Key = "LOG" ,Value = data, Timestamp = Timestamp.Default});
                ConsoleHelper.ShowInfo(dr.Status.ToString());
            }
            catch (ProduceException<string, string> e)
            {
                ConsoleHelper.ShowInfo(e.Message,title: "Error", ConsoleColor.Red);
            }
        }
    }
}
