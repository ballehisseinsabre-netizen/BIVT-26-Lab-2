namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;
             int current = 2;
            while ( current <= 3 * n - 1 )
                answer += current;
                current += 3;
            // code here
            // end
            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            for (int i = 1; i <= n; i++)
                answer += 1.0 / i;

            // code here

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            if (n ==0)
                answer = 1;
            else
                answer = 1;
                for (int i = 1; i <= n; i++)
                    answer *= i; 

            // code here

            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;
            answer = 1;
            for (int i = 0; i < b; i++)
                answer *= a;

            // code here

            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;
            int p = 1;
            answer = 1;
            while (p <= L)
                answer +=3;
                p *= answer;

            // code here

            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here

            // end

            return answer;
        }
    }
}
