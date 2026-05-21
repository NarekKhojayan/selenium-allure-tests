using Allure.NUnit;
using Allure.NUnit.Attributes;
using WeatherTests.UI.Pages;

namespace WeatherTests.UI.Tests
{
    [TestFixture]
    [AllureSuite("WebAdd/DeleteTests")]
    public class AddDeleteTest : BaseTest
    {
        
        [Test]
        [AllureFeature("Add/Delete test")]
        public void AddDelete()
        {
            AddDeletePage page = new AddDeletePage(driver);
            page.OpenAddRemove();
        }
    }

}
