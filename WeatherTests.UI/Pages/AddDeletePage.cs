using Allure.NUnit.Attributes;
using OpenQA.Selenium;

namespace WeatherTests.UI.Pages
{
   
    
    public class AddDeletePage : BasePage
    {
        #region Prop
        #endregion Prop

        #region Ctor
        public AddDeletePage(IWebDriver driver) : base(driver)
        {
        }
        #endregion Ctor

        #region WebElemets
        private IWebElement AddDelete => driver.FindElement(By.XPath("//a[@href='/add_remove_elements/']"));
        private IWebElement Add => driver.FindElement(By.XPath("//button[text()='Add Element']"));
        private IWebElement Delete => driver.FindElement(By.XPath("//button[text()='Delete']"));

        #endregion WebElemets

        #region testMethods
        [AllureStep("Open Add/Delete Page")]
        public void OpenAddRemove()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            WaitHelper.WaitTime(1000);
            AddDelete.Click();
            Add.Click();
            WaitHelper.WaitTime(500);
            Add.Click();
            WaitHelper.WaitTime(500);
            Add.Click();
            WaitHelper.WaitTime(2000);
            Delete.Click();
            Delete.Click();
            WaitHelper.WaitTime(2000);


        }


        #endregion testMethods

    }
}
