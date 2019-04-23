using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar; //imports the MSTest framework for us to use. We installed it into the project by listing it in .csproj, then using the $ dotnet restore command. This line imports the functionality from the project into this specific testing file.

namespace Calendar.Tests // imports the Calendar namespace from the Calendar project for use in our tests.
{
  [TestClass]
  public class LeapYearTest//tells MSTest that the following class contains tests to be run.
  {
    [TestMethod]//tells the compiler that the following code block is an individual test that should be run by MSTest. We haven't written this first test quite yet, though. We've simply left a placeholder comment.//
    public void  IsLeapYear_NumberDivisibleByFour_True()//declared the test method
    {
      LeapYear testLeapYear = new LeapYear();//creating an instance of our LeapYear class
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));//the first assertion. using the Assert class's AreEqual() method. AreEqual() checks whether its two arguments are equal.(whether true and testLeapYear.isLeapYear(2012) are equal, in this expl) First argument (true) is what we expect the result to be and the second (testLeapYear.IsLeapYear)expression to be evaluated.
    }

    [TestMethod]
    public void IsLeapYear_NumberNotDivisibleByFour_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1999));
    }
    [TestMethod]
    public void IsLeapYear_MultiplesOfOneHundred_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
    }
    [TestMethod]
    public void IsLeapYear_MultiplesOfFourHundred_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
    }
  }
}
