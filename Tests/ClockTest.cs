using System;
using Xunit;

namespace ClockAngles
{
  public class ClockTest
  {
    [Fact]
    public void ConvertTime_ConvertMinutesToAngles_Degree()
    {
        Clock newClock = new Clock(6, 0);

        Assert.Equal(36, newClock.ConvertMinutes());
    }

    [Fact]
    public void ConvertHours_ConvertHoursToAngles_Degree()
    {
        Clock newClock = new Clock(30, 6);
        Assert.Equal(195, newClock.ConvertHours());
    }

    [Fact]
    public void FindDegreesBetween_ConvertHoursToDifferenceInDegrees_Degree()
    {
      Clock newClock = new Clock(40, 4);
      Assert.Equal(100, newClock.FindDegreesBetween());
    }
  }
}
