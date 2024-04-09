namespace LogGenerator.Interfaces;
public interface IProducer
{
    Task SendAsync(string data);
}
