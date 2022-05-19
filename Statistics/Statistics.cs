using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
        public double average;
        public double min;
        public double max;
    }
    
    public class StatsComputer
    {
        
        public double average;
        public double min;
        public double max;
        
        public Stats CalculateStatistics(List<double> numbers) 
        {
            //Implement statistics here
            //StatsComputer retData = new StatsComputer();    
            Stats ret = new Stats();
                        
            if (numbers.Count == 0)
            {
                average = Double.NaN;
                min = Double.NaN;
                max = Double.NaN; 
            }
            else
            {
                double minValue = numbers[0];
                double maxValue = numbers[0];
                double sum = numbers[0];
                
                for (int i=1; i<numbers.Count; i++)
                {
                    if(minValue > numbers[i])
                    {
                        minValue = numbers[i];
                    }
                    
                    if(maxValue < numbers[i])
                    {
                        maxValue = numbers[i];
                    }
                    
                    sum = sum + numbers[i];                    
                }              
                
                average = sum/numbers.Count;
                min = minValue;
                max = maxValue;
            }
            
            ret.average = average;
            ret.min = min;
            ret.max = max;
            
            return ret;
        }
    }
}
