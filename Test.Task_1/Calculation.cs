using System;

namespace Test.Task_1
{
    public class Calculation
    {
        public int GetAngle(int hours, int minutes)
        {
            int hourArrowAngle = hours * 30;
            int minuteArrowAngle = minutes * 6;

            int angle = Math.Abs(hourArrowAngle - minuteArrowAngle);

            return angle < 180 ? angle : 360 - angle;
        }
    }
}
