namespace WebApp.Services
{
    public class InfoService : IInfoService
    {
        public string GetMessage()
        {
            return "Сервис успешно подключен через Dependency Injection";
        }
    }
}
