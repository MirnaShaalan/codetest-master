using System.Diagnostics;
using System.Linq;
using Frontend.Utilities;
using DataComponent.Repositories.Interfaces;
using DomainModels.Models;
using DomainModels.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Service.Interfaces;
using DomainModels.EF_Models;

namespace Frontend.Controllers
{
	public class HomeController : Controller
	{
		private readonly IUserService userService;

		public HomeController(IUserService userService)
		{
			this.userService = userService;
		}

		public IActionResult Index()
		{
			var users=userService.GetUsers().ToList();

			return View("Users", users);
		}

		[HttpPost]
		public IActionResult CreateUser(UserEntity user)
		{
			userService.InsertUser(user);

			return RedirectToAction("index");
		}


		[HttpPut]
		public IActionResult Update(UserEntity user)
		{
			UserEntity UpdatedUser = userService.UpdateUser(user);

			return new JsonResult(new
			{
				data= UpdatedUser,
				success = true,
				responseText = "User successfully Updated!"
			});
		}



		[HttpPost]
        public IActionResult Delete(Guid id)
        {
			userService.DeleteUser(id);
	
            return new JsonResult(new
            {
                success = true,
                responseText = "User successfully deleted!"
            });

        }


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel
			{
				RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
			});
		}
	}
}