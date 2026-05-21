using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public static class DriverFactory
{
    public static IWebDriver GetDriver()
    {
        var options = new ChromeOptions();
        options.AddArgument("--no-sandbox");
        options.AddArgument("--disable-dev-shm-usage");
        return new ChromeDriver(options);
    }
}