namespace ProjectEuler
{
    public class MultiplesOf3And5
    {
        public int Sum_Of_Multiples(int exclusiveUpper)
        {
            int sum = 0;
            for (int i = 0; i < exclusiveUpper; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}