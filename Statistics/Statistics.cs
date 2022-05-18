using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
        public float average;
        public float min;
        public float max;
    }
    
    public class StatsComputer
    {
        
        public float average;
        public float min;
        public float max;
        
        public Stats CalculateStatistics(List<float> numbers) 
        {
            //Implement statistics here
            //StatsComputer retData = new StatsComputer();    
            Stats ret = new Stats();
                        
            if (numbers.Count == 0)
            {
                average = (float)Double.NaN;
                min = (float)Double.NaN;
                max = (float)Double.NaN; 
            }
            else
            {
                float minValue = numbers[0];
                float maxValue = numbers[0];
                float sum = numbers[0];
                
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
