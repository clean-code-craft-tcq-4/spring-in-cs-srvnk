namespace Statistics
{
    public class EmailAlert: IAlerter
    {
        public bool emailAlert = false;

        public void EmAl()
        {
            emailAlert = true;
        }

        public void LedAl()
        {
            
        }
    }
}
