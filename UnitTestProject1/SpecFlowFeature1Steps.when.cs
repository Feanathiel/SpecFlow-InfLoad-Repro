using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    public partial class SpecFlowFeature1Steps
    {
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
