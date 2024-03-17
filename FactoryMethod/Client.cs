namespace FactoryMethod;

internal class Client
{
	private readonly MessageDispatcher messageDispatcher;

	public Client(MessageDispatcherFactory dispatcherFactory)
	{
		this.messageDispatcher = dispatcherFactory.CreateMessageDispatcher();
	}

	public void SendMessage(string message)
	{
		messageDispatcher.Send(message);
	}
}
