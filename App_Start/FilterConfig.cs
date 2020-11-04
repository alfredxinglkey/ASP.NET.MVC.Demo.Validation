using System.Web;
using System.Web.Mvc;

namespace ASP.NET.MVC.Demo.Validation
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
