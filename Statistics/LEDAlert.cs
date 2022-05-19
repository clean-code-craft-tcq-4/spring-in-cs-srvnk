namespace Statistics
{
    public class LEDAlert: IAlerter
    {
        public bool ledGlows = false;

        public void EmailAlrt()
        {
            
        }

        public void LedAlrt()
        {
            ledGlows = true;
        }
    }
}
