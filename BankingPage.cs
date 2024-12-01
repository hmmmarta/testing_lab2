using OpenQA.Selenium;

public class BankingPage
{
    private IWebDriver driver;

    public BankingPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public IWebElement LoginButton => driver.FindElement(By.CssSelector(".center:nth-child(3) > .btn"));
    public IWebElement CustomersButton => driver.FindElement(By.CssSelector(".btn-lg:nth-child(3)"));
    public IWebElement FirstNameLink => driver.FindElement(By.LinkText("First Name"));

    public void ClickLoginButton()
    {
        LoginButton.Click();
    }

    public void ClickCustomersButton()
    {
        CustomersButton.Click();
    }

    public void ClickFirstNameLink()
    {
        FirstNameLink.Click();
    }
}
