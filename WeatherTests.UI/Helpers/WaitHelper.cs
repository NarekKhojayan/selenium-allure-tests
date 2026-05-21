using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

public static class WaitHelper
{
    public static void WaitForElement(IWebDriver driver, By locator)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(d => d.FindElement(locator).Displayed);
    }
    public static void WaitTime(int seconds)
    {
            Thread.Sleep(seconds);
    }
}