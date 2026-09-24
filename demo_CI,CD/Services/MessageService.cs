namespace demo_CI_CD.Services
{
    public class MessageService : IMessageService
    {
        public string GetWelcomeMessage()
        {
            return "Chao mung ban den voi ung dung ASP.NET Core MVC (CI/CD Demo)!";
        }
    }
}
