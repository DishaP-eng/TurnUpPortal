using TechTalk.SpecFlow;

namespace TurnUpPortal;

[Binding]
public class TMPage
{
    [Given(@"I logged in to TurnUp portal successfully")]
    public void GivenILoggedInToTurnUpPortalSuccessfully()
    {
        ScenarioContext.StepIsPending();
    }
}