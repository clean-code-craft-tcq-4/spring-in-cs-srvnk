namespace Statistics
{
    public class LEDAlert: IAlerter
    {
        public bool ledGlows = false;

        public void EmAl()
        {
            
        }

        public void LedAl()
        {
            ledGlows = true;
        }
    }
}
