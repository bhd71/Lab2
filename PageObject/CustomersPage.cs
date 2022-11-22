using OpenQA.Selenium;

namespace PageObject
{
    public class CustomersPage : BasePage
    {
        public CustomersPage(IWebDriver webDriver) : base(webDriver) {
        }

        private static string[] inputData = new string[] { "Bohdan", "Bronytskyi", "79052" } ;
      
        public IWebElement GetAddCustomerButton() => driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div/form/button"));
        public IList<IWebElement> GetAllInputs() => driver.FindElements(By.XPath("//input[@class='form-control ng-pristine ng-untouched ng-invalid ng-invalid-required']"));

        public void SendKyesToIWebElements(IList<IWebElement> allInputs)
        {
            for (int i = 0; i < inputData.Length; i++)
            {
                allInputs[i].SendKeys(inputData[i]);
            }
        }
        public  void PressButton(IWebElement button)
        {
            button.Click();
        }
    }
}
