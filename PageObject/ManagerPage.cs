using OpenQA.Selenium;

namespace PageObject
{
    public class ManagerPage : BasePage
    {
        public ManagerPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        private IWebElement btnCustomers => driver.FindElement(By.XPath("//button[@ng-click='addCust()']"));

        public void ClickCustomers() => btnCustomers.Click();
    }
}
