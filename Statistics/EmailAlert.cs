namespace Statistics
{
    public class EmailAlert: IAlerter
    {
        public bool emailSent = false;

        public void EmAl()
        {
            emailSent = true;
        }

        public void LedAl()
        {
            
        }
    }
}
