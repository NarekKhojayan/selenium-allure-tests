using Allure.NUnit.Attributes;
using WeatherTests.UI.Pages;

namespace WeatherTests.UI.Tests
{
    [TestFixture]
    [AllureSuite("WebCheckboxTests")]
    public class CheckboxTest : BaseTest
    {

        [Test]
        [AllureFeature("Checkbox test")]
        public void AddDelete()
        {
            var page = new CheckboxePage(driver);
            page.CheckboxFunctional();
            Assert.That(driver.Title, Does.Contain("The Internet"));

        }
    }
}
