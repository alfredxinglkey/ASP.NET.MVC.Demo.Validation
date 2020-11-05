using ASP.NET.MVC.Demo.Validation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET.MVC.Demo.Validation.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult OneNX()
		{
			return View();
		}

		[HttpPost]
		public ActionResult OneNX(Student stu)
		{
			return View();
		}

		public ActionResult HC()
		{
			return View();
		}
		[HttpPost]
		public JsonResult HCX()
		{
			var a = Request;
			var name = Request["Name"];
			var wife = Request["Wife"];
			var result = new { Stutas = "OK" };
			return Json(result);
		}
	}
}