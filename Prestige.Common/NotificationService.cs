namespace Prestige.Common
{
    public static class NotificationService
    {
        public static string NotifyTalent(string talentName) 
        { 
            var message = "Notifying talent:" + talentName;
            Console.WriteLine(message);

            return message;
        }
    }
}