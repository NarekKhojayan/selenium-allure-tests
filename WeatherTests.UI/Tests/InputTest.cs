using Allure.NUnit;
using Allure.NUnit.Attributes;
using WebTests.UI.Pages;

namespace WebTests.UI.Tests
{

    [TestFixture]
    [AllureSuite("WebInputTests")]
    public class InputTest : BaseTest
    {

        [Test]
        [AllureFeature("Number Input test")]
        public void NumberInput()
        {
            var page = new InputPage(driver);
            page.NumberInputFunctional();
            Assert.That(driver.Title, Does.Contain("The Internet"));

        }
        [Test]
        [AllureFeature("General Input test")]
        public void GeneralInput()
        {
            var page = new InputPage(driver);
            page.GeneralInputFunctional();
            Assert.That(driver.Title, Does.Contain("The Internet"));

        }
    }
}
