namespace UserNotificationLib
{
    public class UserNotifier
    {
        private readonly IMessageSender _messageSender;

        // ✅ Constructor injection
        public UserNotifier(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public bool NotifyUser()
        {
            // ✅ Call dependency method
            _messageSender.SendMessage("customer1@xyz.com", "Your transaction was successful!");

            return true; // ✅ Hamisha bool return karo kyunki aap test mein assert karoge
        }
    }
}

