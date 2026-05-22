🧪 Selenium Allure Tests
UI test automation project built with C#, Selenium, NUnit, and Allure. Tests run automatically on every push via GitHub Actions CI/CD pipeline, and the Allure report is delivered by email.

🛠️ Tech Stack
ToolPurposeC# / .NET 8Programming languageSelenium WebDriverBrowser automationNUnitTest frameworkAllureTest reportingGitHub ActionsCI/CD pipelineChromeDriverChrome browser driver

📁 Project Structure
selenium-allure-tests/
├── .github/
│   └── workflows/
│       └── run-tests.yml    # CI/CD pipeline
├── WeatherTests.UI/
│   ├── Core/
│   │   ├── BaseTest.cs      # Base test setup & teardown
│   │   ├── BasePage.cs      # Base page with shared elements
│   │   └── DriverFactory.cs # ChromeDriver configuration
│   ├── Pages/
│   │   └── AddDeletePage.cs # Page Object for Add/Delete page
│   ├── Tests/
│   │   └── AddDeleteTest.cs # Test cases
│   └── Helpers/
│       ├── WaitHelper.cs    # Explicit waits
│       └── ScreenshotHelper.cs # Screenshot on failure
└── allureConfig.json        # Allure configuration

⚙️ CI/CD Pipeline
Every push to master automatically triggers the pipeline:
Push to GitHub
      ↓
GitHub Actions starts
      ↓
.NET restore & build
      ↓
Run Selenium tests (Headless Chrome)
      ↓
Generate Allure report
      ↓
Send HTML report by email

🚀 Run Locally

Clone the repository

bashgit clone https://github.com/NarekKhojayan/selenium-allure-tests.git

Restore dependencies

bashdotnet restore

Run tests

bashdotnet test

Generate Allure report

bashallure generate allure-results --clean -o allure-report
allure open allure-report
