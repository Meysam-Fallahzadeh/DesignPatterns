namespace FactoryMethod;

public interface MessageDispatcher
{
    public void Send(string message);
}

public class SmsDispatcher : MessageDispatcher
{
    public void Send(string message)
    {
        Console.WriteLine($"Mobile Number 09********* : {message}");
    }
}
public class EmailDispatcher : MessageDispatcher
{
    public void Send(string message)
    {
        Console.WriteLine($"Emaile *@*.com {message}");
    }
}