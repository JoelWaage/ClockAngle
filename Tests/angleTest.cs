using Xunit;
using System;
namespace ClockAngleList.Objects
{
  public class ClockAngleTest
  {
    [Fact]
    public void AngleTest_TopOfHour_angle()
    {
      Angle newAngle = new Angle(4,0);
      Assert.Equal(120, newAngle.ClockAngle());
    }
    [Fact]
    public void AngleTest_MinuteTest_angle()
    {
      Angle newAngle = new Angle(0,30);
      Assert.Equal(180, newAngle.ClockAngle());
    }
    [Fact]
    public void AngleTest_HoursAndMinuteTest_angle()
    {
      Angle newAngle = new Angle(3,48);
      Assert.Equal(174, newAngle.ClockAngle());
    }
    [Fact]
    public void AngleTest_Other_angle()
    {
      Angle newAngle = new Angle(6,17);
      Console.WriteLine(newAngle.ClockAngle());
      Assert.Equal(86.5, newAngle.ClockAngle());
    }
  }
}
