using NUnit.Framework;
using OpenQA.Selenium;
using PageObject;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class CustomersPageSteps : BaseSteps
    {
        private CustomersPage customersPage;
       

        [When(@"insert data into inputs and press button")]
        public void WhenClickOnTheDeleteButton()
        {

            customersPage = new CustomersPage(driver);

            var inputs = customersPage.GetAllInputs();
            var addCustomerButton = customersPage.GetAddCustomerButton();

            customersPage.SendKyesToIWebElements((IList<IWebElement>)inputs);

            customersPage.PressButton((IWebElement)addCustomerButton);
 
        }
        
        [Then(@"webpage shoudld contain alert")]
        public void ThenTheResultShouldBeAListWithoutOneCustomer()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            IAlert simpleAlert = driver.SwitchTo().Alert();
            Assert.NotNull(simpleAlert);
            simpleAlert.Accept();
        }

    }
}
