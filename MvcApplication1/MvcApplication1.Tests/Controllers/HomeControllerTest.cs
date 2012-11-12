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
			var controller = new HomeController();

			var result = controller.Index() as ViewResult;

			Assert.AreEqual(null, result.ViewBag.Message);

			//Assert.Fail("Make it #FAIL on purpose!");
		}
	}
}