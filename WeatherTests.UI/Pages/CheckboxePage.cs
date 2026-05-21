using Allure.NUnit;
using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherTests.UI.Pages
{
    public class CheckboxePage : BasePage
    {
        #region Ctor
        public CheckboxePage(IWebDriver driver) : base(driver)
        {
        }
        #endregion Ctor
        #region WebElemets
        private IWebElement CheckboxesLink =>
        driver.FindElement(By.XPath("//a[text()='Checkboxes']"));
        private IList<IWebElement> Checkboxes =>
        driver.FindElements(By.CssSelector("#checkboxes input[type='checkbox']"));

        #endregion WebElemets
        #region testMethods
        [AllureStep("Open Add/Delete Page")]
        public void CheckboxFunctional()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            CheckboxesLink.Click();
            WaitHelper.WaitTime(1000);
            Checkboxes[0].Click();
            WaitHelper.WaitTime(1000);
            Checkboxes[1].Click();
            WaitHelper.WaitTime(1000);
            Checkboxes[0].Click();
            WaitHelper.WaitTime(1000);

        }


        #endregion testMethods
    }
}
