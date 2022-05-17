using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            try
            {
                float[] retData = new Stats();
                
                if (numbers.Count() == 0)
                {
                    retData[0] = Double.NaN;
                    retData[1] = Double.NaN;
                    retData[2] = Double.NaN; 
                }
                else
                {
                    retData[0] = numbers.Average();
                    retData[1] = numbers.Min();
                    retData[2] = numbers.Max();
                }
                return retData;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in CalculateStatistics. " + ex.Message);
            }                
        }
    }
}
