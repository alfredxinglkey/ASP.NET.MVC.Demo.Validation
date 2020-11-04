using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET.MVC.Demo.Validation.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public GenderEnum Gender { get; set; }
		public int Status { get; set; }
	}
}