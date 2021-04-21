namespace Day19
{
    public class Calculator : IAdvancedArithmetic
        {
            private int _temp = 0;
            private int _temp2 = 0;
            private int _i = 1;

            // recursive version
            public int divisorSum(int n)
            {
                if (n == _i)
                {
                    _temp += n;
                    return _temp;
                } 
                else if (n % _i == 0)
                {
                    _temp += _i;
                }

                _i++;
                return divisorSum(n);
            }
        

            // version with loop
            public int DivisorSumLoop(int n)
            {
                for (var i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                        _temp2 += i;
                }

                return _temp2;
            }
        }
}
