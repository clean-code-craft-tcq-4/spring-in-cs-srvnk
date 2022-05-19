using System.Collections.Generic;

namespace Statistics
{
    public class StatsAlerter
    {
        public double threshold;
        public IAlerter[] alerter;
        public StatsAlerter(double threshold, IAlerter[] alerter)
        {
            this.threshold = threshold;
            this.alerter = alerter;

        }
        

        public void checkAndAlert(List<double> nums)
        {
            double maxValue = nums[0];
            for (int i = 1; i < nums.Count; i++)
            {
                if (maxValue < nums[i])
                {
                    maxValue = nums[i];
                }
            }

            if (maxValue > threshold)
            {
                alerter[0].EmAl();
                alerter[1].LedAl();                
            }
        }
    }
}
