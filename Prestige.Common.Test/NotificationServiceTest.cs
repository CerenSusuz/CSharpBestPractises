namespace Prestige.Common.Test
{
    public class NotificationServiceTest
    {
        [Test]
        public void TestNotifyTalent()
        {
            var expect = "Notifying talent:gerund";

            var actual = NotificationService.NotifyTalent("gerund");

            Assert.That(actual, Is.EqualTo(expect));
        }
    }
}