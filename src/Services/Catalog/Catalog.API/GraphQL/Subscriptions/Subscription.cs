namespace Catalog.API.GraphQL.Subscriptions;

public class Subscription
{
    [Subscribe]
    public string OnMessageReceived([EventMessage] string message) => message;
}