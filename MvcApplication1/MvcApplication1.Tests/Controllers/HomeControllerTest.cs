using System.Web.Mvc;
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
			Assert.AreEqual(null, result.ViewBag.Message);
		}
	}
}