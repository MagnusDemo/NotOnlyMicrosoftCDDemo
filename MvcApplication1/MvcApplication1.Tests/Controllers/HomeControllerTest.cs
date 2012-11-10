﻿using System.Web.Mvc;
using MvcApplication1.Controllers;
using NUnit.Framework;

namespace MvcApplication1.Tests.Controllers
{
	[TestFixture]
	public class HomeControllerTest
	{
		[Test]
		public void Index()
		{
			// Arrange
			var controller = new HomeController();

			// Act
			var result = controller.Index() as ViewResult;

			// Assert
			Assert.AreEqual("Modify this template to jump-start your ASP.NET MVC application.", result.ViewBag.Message);
		}
	}
}