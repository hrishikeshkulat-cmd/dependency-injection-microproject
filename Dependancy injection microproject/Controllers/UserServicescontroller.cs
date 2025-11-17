using Dependancy_injection_microproject.services;
using Microsoft.AspNetCore.Mvc;

namespace Dependancy_injection_microproject.Controllers
{
    public class UserServicescontroller : Controller
    {
        private readonly IUserservices _useremailservices;
        private readonly IUserservices _usersmservices;

        public UserServicescontroller(IUserservices userservices,IUserservices Usersmsservices)
        {
            _useremailservices = userservices;
            _usersmservices= Usersmsservices;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string message)
        {
            if(message=="email")
            {
                 _useremailservices.send(message);
            }
            else if( message=="sms")
            {
                _usersmservices.send(message);
            }


         ViewBag.Result = $"Notification sent successfully: {message}";
            return View();
        }
    }
}
