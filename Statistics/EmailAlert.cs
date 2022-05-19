namespace Statistics
{
    public class EmailAlert: IAlerter
    {
        public bool emailSent = false;

        public void EmailAlrt()
        {
            emailSent = true;
        }

        public void LedAlrt()
        {
            
        }
    }
}
