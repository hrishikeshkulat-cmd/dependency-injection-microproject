namespace Dependancy_injection_microproject.services
{
    public class UseremailServices:IUserservices
    {
        public void send(string message)
        {
            Console.WriteLine($"your email notification {message}");
        }

    }
    public class UsersmsServices : IUserservices
    {
    
      public void send(string message)
        {
            Console.WriteLine($"your sms notification{message}");   
        }
    }


}
