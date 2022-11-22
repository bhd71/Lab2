using PageObject;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class ManagerPageSteps : BaseSteps
    {
        private ManagerPage managerPage;

        [Given(@"click on the add customer button")]
        public void GivenClickOnTheCustomersButton()
        {
            managerPage = new ManagerPage(driver);
            managerPage.ClickCustomers();
        }

    }
}
