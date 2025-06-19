public class NotificationTest {
    public static void main(String[] args) {
        // Base notifier: Email
        Notifier emailNotifier = new EmailNotifier();

        // Add SMS functionality
        Notifier smsEmailNotifier = new SMSNotifierDecorator(emailNotifier);

        // Add Slack on top of Email + SMS
        Notifier allChannelNotifier = new SlackNotifierDecorator(smsEmailNotifier);

        // Send the notification
        allChannelNotifier.send("Server is down!");
    }
}

