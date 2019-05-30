using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTest
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private int first = 0;
        private int second = 0;
        private int result = 0;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            first = p0;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            second = p0;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = first + second;
        }

        [When(@"I press mult")]
        public void WhenIPressMult()
        {
            result = first * second;
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, result);
        }
    }
}
