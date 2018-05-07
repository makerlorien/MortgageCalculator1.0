namespace MortgageCalculator1._0
{
    public class Calculator
    {
        /*
         * M = P * ( (r*(1+r)^n) / ((1 + r)^n - 1) )
         * 
         * M is monthly payment
         * P is principal
         * r is monthly interest rate
         * n is number of payments (months)
         */

        public Calculator()
        {
        }

        public decimal CalculateMonthlyPayment(int y, decimal ar, decimal pp, decimal dp)
        {
            decimal M = 0.0M;

            decimal P = pp - dp;

            decimal r = ar / 12;

            int n = y * 12;

            decimal x = 0;

            if (n > 0)
            {
                decimal temp = 1;

                int i = 0;

                while (i < n)
                {
                    i++;

                    temp = temp * (1 + r);
                }

                x = temp;
            }

            decimal z = 0;

            if (n > 0)
            {
                decimal temp = 1;

                int i = 1;

                while (i <= n)
                {
                    temp = temp * (1 + r);
                    i++;
                }

                z = temp;
            }

            if (z == 1)
            {
                M = P / n;
            }
            else
            {
                M = P * ((r * x) / (z - 1));
            }
            return M;
        }
    }
}
