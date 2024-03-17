namespace FactoryMethod;

internal interface MessageDispatcherFactory
{
    public MessageDispatcher CreateMessageDispatcher();
}

public class SmsDispatcherFactory : MessageDispatcherFactory
{
    public MessageDispatcher CreateMessageDispatcher()
    {
        return new SmsDispatcher();
    }
}
public class EmailDispatcherFactory : MessageDispatcherFactory
{
    public MessageDispatcher CreateMessageDispatcher()
    {
        return new EmailDispatcher();
    }
}
