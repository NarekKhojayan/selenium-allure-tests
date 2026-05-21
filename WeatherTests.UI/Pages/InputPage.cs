using Allure.NUnit;
using Allure.NUnit.Attributes;
using OpenQA.Selenium;


namespace WebTests.UI.Pages
{
    public class InputPage : BasePage
    {
        public InputPage(IWebDriver driver) : base(driver)
        {
        }

        #region WebElemets
        private IWebElement InputNumber =>
        driver.FindElement(By.XPath("//a[text()='Inputs']"));
        private IWebElement InputGeneral =>
        driver.FindElement(By.XPath("//a[text()='Key Presses']"));
        private IWebElement NumberInput =>
        driver.FindElement(By.CssSelector("input[type='number']"));
        private IWebElement GeneralInput =>
        driver.FindElement(By.CssSelector("input[type='Text']"));

        #endregion WebElemets
        #region testMethods
        [AllureStep("Numeber Input Page")]
        public void NumberInputFunctional()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            InputNumber.Click();
            WaitHelper.WaitTime(1000);
            NumberInput.SendKeys("12345");
            WaitHelper.WaitTime(1000);
            NumberInput.Clear();
            WaitHelper.WaitTime(1000);
            NumberInput.SendKeys("0000000000");
            WaitHelper.WaitTime(1000);
        }
        [AllureStep("Numeber Input Page")]
        public void GeneralInputFunctional()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            InputGeneral.Click();
            WaitHelper.WaitTime(1000);
            GeneralInput.SendKeys("S");
            WaitHelper.WaitTime(1000);
            GeneralInput.Clear();
            WaitHelper.WaitTime(1000);
            GeneralInput.SendKeys("A");
            WaitHelper.WaitTime(500);
            GeneralInput.SendKeys("t");
            WaitHelper.WaitTime(500);
            GeneralInput.SendKeys("2");
            WaitHelper.WaitTime(1000);

        }


        #endregion testMethods
    }
}
