using Blazor.Components.Core.HtmlColors;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blazor.Components.Core.Tests
{
	[TestClass]
	public class RgbTest
	{
		[TestMethod]
		public void Rgb_should_have_correct_toString()
		{
			var rgb = new Rgb(0, 0, 0);
			var rgb2 = new Rgb(255, 255, 255);
			var rgb3 = new Rgb(26, 78, 55);

			Assert.AreEqual("0, 0, 0", rgb.ToString());
			Assert.AreEqual("255, 255, 255", rgb2.ToString());
			Assert.AreEqual("26, 78, 55", rgb3.ToString());
		}
	}
}