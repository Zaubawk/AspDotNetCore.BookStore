using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zau.BookStore.Models;
using Zau.BookStore.Repository;
using Zau.BookStore.Service;

namespace Zau.BookStore.Controllers
{
    [Route("[Controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly NewBookAlertConfig _newBookAlertConfiguration;
        private readonly NewBookAlertConfig _thirdPartyBookConfiguration;
        private readonly IMessageRepository _messageRepository;
        private readonly IUserService _userService;

        public HomeController(IOptionsSnapshot<NewBookAlertConfig> newBookAlertConfiguration, IMessageRepository messageRepository,
            IUserService userService)
        {
            _newBookAlertConfiguration = newBookAlertConfiguration.Get("InternalBook");
            _thirdPartyBookConfiguration = newBookAlertConfiguration.Get("ThirdPartyBook");
            _messageRepository = messageRepository;
            _userService = userService;
        }

        [Route("~/")]
        public ViewResult Index()
        {
            var userId = _userService.GetUserId();
            var isLoggedIn = _userService.IsAuthenticated();
            bool isDisplay = _newBookAlertConfiguration.DisplayNewBookAlert;
            bool isDisplay1 = _thirdPartyBookConfiguration.DisplayNewBookAlert;

            //var value = _messageRepository.GetName();

            //var newBook = configuration.GetSection("NewBookAlert");
            //var result = newBook.GetValue<Boolean>("DisplayNewBookAlert");
            //var bookName = newBook.GetValue<string>("BookName");

            //var result = configuration["AppName"];
            //var key1 = configuration["infoObj:key1"];
            //var key2 = configuration["infoObj:key2"];
            //var key3 = configuration["infoObj:key3:key3obj1"];
            return View();
        
        }

        //[Route("about-us/{name:alpha:minlength(5):regex()}")]
        public ViewResult AboutUs()
        {
            return View();
        }

      
        public ViewResult ContactUs()
        {
            return View();
        }

    }
}
