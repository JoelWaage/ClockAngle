using System;
using System.Collections.Generic;

namespace ClockAngleList.Objects
{
  public class Angle
  {
    private int _hours;
    private int _minutes;

    public Angle(int hours, int minutes)
    {
      _hours=hours;
      _minutes=minutes;
    }
    public int GetHours()
    {
      return _hours;
    }
    public int GetMinutes()
    {
      return _minutes;
    }
    public void SetHours(int newhours)
    {
      _hours=newhours;
    }

    public void SetMinutes(int minutes)
    {
      _minutes=minutes;
    }
    public double checkNumber(double num)
    {
      if (num > 180)
    {
      return 360-num;
    }
    else
    {
    return num;
    }

    }
    public double ClockAngle()
    {
      double minAngle=6*this.GetMinutes();
      double hoursAngle=0;
      double result;
      if (this.GetHours() != 0)
      {
        double test =(double) this.GetMinutes()/2;
        hoursAngle=(double)this.GetHours() * 30+test;
      }
      if(minAngle-hoursAngle>=0){
        result=minAngle-hoursAngle;
        return this.checkNumber(result);
      }
      else
      {
          result=hoursAngle-minAngle;
        return  this.checkNumber(result);

      }
    }
  }
}
