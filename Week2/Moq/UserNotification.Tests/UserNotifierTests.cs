using NUnit.Framework;

using Moq;
using UserNotificationLib;

namespace UserNotification.Tests
{
    [TestFixture]
    public class UserNotifierTests
    {
        private UserNotifier _userNotifier;
        private Mock<IMessageSender> _mockMessageSender;

        [OneTimeSetUp]
        public void Setup()
        {
            _mockMessageSender = new Mock<IMessageSender>();

            _mockMessageSender
                .Setup(x => x.SendMessage(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            _userNotifier = new UserNotifier(_mockMessageSender.Object);
        }

        [Test]
        public void NotifyUser_WhenCalled_ReturnsTrue()
        {
            var result = _userNotifier.NotifyUser();

            Assert.That(result, Is.True);
        }
    }
}

