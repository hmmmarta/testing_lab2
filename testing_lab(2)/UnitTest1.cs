using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

[Binding]
public class BankManagerSteps
{
    private IWebDriver driver;
    private BankingPage bankingPage;

    [Given(@"I navigate to the bank application")]
    public void GivenINavigateToTheBankApplication()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/");
        driver.Manage().Window.Maximize();
        bankingPage = new BankingPage(driver);
        Thread.Sleep(500);
    }


    [When(@"I login as a bank manager")]
    public void WhenILoginAsABankManager()
    {
        bankingPage.ClickLoginButton();
        Thread.Sleep(500);
    }

    [When(@"I view the customers list")]
    public void WhenIViewTheCustomersList()
    {
        bankingPage.ClickCustomersButton();
        Thread.Sleep(500);
    }

    [Then(@"the customers should be sorted by first name")]
    public void ThenTheCustomersShouldBeSortedByFirstName()
    {
        bankingPage.ClickFirstNameLink();
        bankingPage.ClickFirstNameLink();
        Thread.Sleep(500);
        List<IWebElement> firstNameElements = driver.FindElements(By.XPath("//tbody/tr/td[1]")).ToList();
        List<string> actualFirstNames = firstNameElements.Select(e => e.Text).ToList();
        Thread.Sleep(500);

        List<string> sortedFirstNames = new List<string>(actualFirstNames);
        sortedFirstNames.Sort();
        Thread.Sleep(500);

        CollectionAssert.AreEqual(sortedFirstNames, actualFirstNames);
        driver.Quit();
    }
}

