using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    [Binding]
    public partial class Test
    {

    }

    [Binding]
    public partial class SpecFlowFeature1Steps
    {
        public SpecFlowFeature1Steps()
        {
            
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"some background")]
        public void SomeBg()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
