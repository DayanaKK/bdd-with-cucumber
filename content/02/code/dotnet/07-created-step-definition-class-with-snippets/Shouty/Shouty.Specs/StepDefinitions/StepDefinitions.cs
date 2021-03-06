using System;
using TechTalk.SpecFlow;

namespace Shouty.Specs.StepDefinitions
{
    [Binding]
    public class StepDefinitions
    {
        [Given("Lucy is located {int}m from Sean")]
        public void GivenLucyIsLocatedMFromSean(int p0)
        {
            throw new PendingStepException();
        }

        [When("Sean shouts {string}")]
        public void WhenSeanShouts(string p0)
        {
            throw new PendingStepException();
        }

        [Then("Lucy hears Sean's message")]
        public void ThenLucyHearsSeanSMessage()
        {
            throw new PendingStepException();
        }
    }
}
