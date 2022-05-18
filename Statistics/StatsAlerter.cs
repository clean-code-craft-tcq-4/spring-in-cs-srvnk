using System.Collections.Generic;

namespace Statistics
{
    public class StatsAlerter
    {
        public float threshold;
        public IAlerter[] alerter;
        public StatsAlerter(float threshold, IAlerter[] alerter)
        {
           this.threshold = threshold;
           this.alerter = alerter;
        }

        public void checkAndAlert(List<float> nums)
        {
            float maxValue = nums[0];
            for (int i = 1; i < nums.Count; i++)
            {
                if (maxValue < nums[i])
                {
                    maxValue = nums[i];
                }
            }

            if (maxValue > threshold)
            {
                alerter[0].alerter.GetType().GetProperty("emailSent").SetValue(true, true);
                alerter[1].alerter.GetType().GetProperty("ledGlows").SetValue(true, true);
            }
        }
    }
}
