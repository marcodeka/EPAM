using LampTimeConverter.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace BerlinClock.BDD
{
    [Binding]
    public class TheBerlinClockTestSteps
    {
        private ITimeConverter berlinClock = new TimeConverter();
        private String theTime;


        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            theTime = time;
        }

        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {
            Assert.AreEqual(theExpectedBerlinClockOutput, berlinClock.convertTime(theTime));
        }

        [Then(@"the user is presented with an error message about parsing")]
        public void ThenTheUserIsPresentedWithAnErrorMessageAboutParsing()
        {
            try
            {
                berlinClock.convertTime(theTime);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ClockTimeParsingException);
            }
        }

        [Then(@"the user is presented with an error message about time value")]
        public void ThenTheUserIsPresentedWithAnErrorMessageAboutTimeValue()
        {
            try
            {
                berlinClock.convertTime(theTime);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ClockTimeValuesException);
            }
        }
    }
}
