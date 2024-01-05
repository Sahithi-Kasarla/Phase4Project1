using Assignment1;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly Arithmetic arithmetic;
        private int result;
        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.arithmetic = new Arithmetic();
        }
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            arithmetic.num1= p0;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            arithmetic.num2 = p0;
        }

        [When(@"the two numbers are Subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            result = arithmetic.Sub();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            result.Should().Be(result);
        }

        [When(@"the two numbers Multiply")]
        public void WhenTheTwoNumbersMultiply()
        {
            result = arithmetic.Multi();
        }

        [Then(@"the result is multiplication (.*)")]
        public void ThenTheResultIsMultiplication(int p0)
        {
            result.Should().Be(result);
        }

        [When(@"the two numbers Divided")]
        public void WhenTheTwoNumbersDivided()
        {
            result = arithmetic.Div();
        }

        [Then(@"the result is division (.*)")]
        public void ThenTheResultIsDivision(int p0)
        {
            result.Should().Be(result);
        }
    }
}
