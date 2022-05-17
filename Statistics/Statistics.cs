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
                Stats retData = new Stats();
                
                if (numbers.Count() == 0)
                {
                    retData.average = Double.NaN;
                    retData.min = Double.NaN;
                    retData.max = Double.NaN; 
                }
                else
                {
                    retData.average = numbers.Average();
                    retData.min = numbers.Min();
                    retData.max = numbers.Max();
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
