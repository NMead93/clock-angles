using System;

namespace ClockAngles
{
  public class Clock
  {
    private int _minutes;
    private int _hours;

    public Clock(int minutes, int hours)
    {
      _minutes = minutes;
      _hours = hours;
    }

    public int ConvertMinutes()
    {
      return 6 * _minutes;
    }

    public int ConvertHours()
    {
        int minuteDegree =  6 * _minutes;
        return (30 * _hours) + (int)(30.0 * (minuteDegree / 360.0));
    }

    public int FindDegreesBetween()
    {
        int differenceBetweenDegrees = Math.Abs(ConvertMinutes() - ConvertHours());

        if (differenceBetweenDegrees > 180) {
          return 360 - differenceBetweenDegrees;
        }
        else
        {
          return differenceBetweenDegrees;
        }
    }
  }
}
