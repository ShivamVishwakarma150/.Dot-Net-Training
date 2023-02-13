namespace Prime.Services
{
    public class PrimeServices
    {
        public bool IsPrime (int num)
        {
            if (num < 2)
            {
                return false;
            }
            else if(num > 2)
            {
                for(int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            throw new NotImplementedException ("Please create a test first");
        }
    }
}