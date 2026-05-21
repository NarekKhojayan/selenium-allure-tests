using Allure.NUnit;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

[AllureNUnit]
public class BaseTest
{
    protected IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = DriverFactory.GetDriver();
        driver.Manage().Window.Maximize();
    }

    [TearDown]
    public void TearDown()
    {
        
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                ScreenshotHelper.TakeScreenshot(driver);

            driver?.Quit();
            driver?.Dispose();
        
    }
}