namespace Calendar //in calendar namespace
{
  public class LeapYear //class called LeapYear
  {
    public bool IsLeapYear(int year) //single method that returns a bool.
    {
      if (year % 400 == 0)
      {
        return true;
      }
      if (year % 100 == 0)
      {
        return false;
      }
      else
      {
        return year % 4 == 0;
      }


      // return false; //returns false as a placeholder, so the application can compile properly, if it returned nothing, we'd receive errors
    }
  }
}
