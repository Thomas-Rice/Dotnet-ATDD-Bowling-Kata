using ATDD_BowlingAPP.Models;
using ATDD_BowlingAPP.ScoreCalculators;
using Shouldly;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ATDD_BowlingAPP_Specs
{
    [Binding]
    public class BowlAGameSteps
    {
        private ScoreCard _scoreCard;
        private int _result;
        private readonly ScoreCalculator _scoreCalculator;

        public BowlAGameSteps()
        {
            _scoreCalculator = new ScoreCalculator();
        }

        [Given(@"I have the following score:")]
        public void GivenIHaveTheFollowingScore(Table table)
        {
            _scoreCard = table.CreateInstance<ScoreCard>();
        }
        
        [When(@"I request a final score")]
        public void WhenIRequestAFinalScore()
        {
            _result = _scoreCalculator.CalculateOverallGameScore(_scoreCard.Card);
        }
        
        [Then(@"the result should be:")]
        public void ThenTheResultShouldBe(Table table)
        {
            var expectedResult = table.CreateInstance<Score>();
            _result.ShouldBe(expectedResult.FinalScore);
        }
    }
}
