namespace TestNotify
{
    public interface ITypedHubClient
    {
        Task BroadcastMessage(Message message);
    }
}
