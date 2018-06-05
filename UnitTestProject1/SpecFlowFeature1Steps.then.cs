using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    public partial class SpecFlowFeature1Steps
    {
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
