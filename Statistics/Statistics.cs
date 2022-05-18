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
        
        public Stats CalculateStatistics(List<float> numbers) 
        {
            //Implement statistics here
            StatsComputer retData = new StatsComputer();    
            Stats ret = new Stats();
                        
            if (numbers.Count == 0)
            {
                retData.average = (float)Double.NaN;
                retData.min = (float)Double.NaN;
                retData.max = (float)Double.NaN; 
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
                
                retData.average = sum/numbers.Count;
                retData.min = minValue;
                retData.max = maxValue;
            }
            
            ret.average = retData.average;
            ret.min = retData.min;
            ret.max = retData.max;
            
            return ret;
        }
    }
}
