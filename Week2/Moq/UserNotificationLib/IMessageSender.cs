namespace UserNotificationLib
{
    public interface IMessageSender
    {
        bool SendMessage(string toAddress, string message);
    }
}

