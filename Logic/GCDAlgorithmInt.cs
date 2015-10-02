using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class GCDAlgorithmInt
    {

        private static double lastExecutionTime;

        public static double LastExecutionTime { get { return lastExecutionTime; } }


        public delegate int GCDparams(params int[] args);
        public delegate int GCD(int x, int y);


        public static GCDparams Euclid = args => GCDTimeDiagnostic(EuclidAlgorithm, args);
        public static GCDparams Binary = args => GCDTimeDiagnostic(BinaryAlgorithm, args);


        private static int GCDTimeDiagnostic(GCD algorithm, params int[] args)
        {
            int result = 0;
            Stopwatch watch = Stopwatch.StartNew();
            result = GCDParams(algorithm, args);
            watch.Stop();
            lastExecutionTime = (double)watch.ElapsedTicks / Stopwatch.Frequency;
            return result;
        }

        private static int GCDParams(GCD algorithm, params int[] args)
        {
            if (args == null)
                throw new ArgumentNullException("args");
            if (args.Length == 0)
                throw new ArgumentException("args is empty");
            int gcd = args[0];
            for (int i = 1; i < args.Length; i++)
            {
                gcd = algorithm(gcd, args[i]);
            }
            return gcd;
        }

        private static int EuclidAlgorithm(int x, int y)
        {
            while (y != 0)
            {
                x = x % y;
                if (x == 0)
                {
                    x = y;
                    break;
                }
                y = y % x;
            }
            return x > 0 ? x : -x;
        }

        public static int BinaryAlgorithm(int x, int y)
        {
            int shift;

            x = Math.Abs(x);
            y = Math.Abs(y);

            /* GCD(0,y) == y; GCD(x,0) == x, GCD(0,0) == 0 */
            if (x == 0) return y;
            if (y == 0) return x;

            /* Let shift := lg K, where K is the greatest power of 2
                  dividing both x and y. */
            for (shift = 0; ((x | y) & 1) == 0; ++shift)
            {
                x >>= 1;
                y >>= 1;
            }

            while ((x & 1) == 0)
                x >>= 1;

            /* From here on, x is always odd. */
            do
            {
                /* remove all factors of 2 in y -- they are not common */
                /*   note: y is not zero, so while will terminate */
                while ((y & 1) == 0)  /* Loop X */
                    y >>= 1;

                /* Now x and y are both odd. Swap if necessary so x <= y,
                   then set y = y - x (which is even). For bignums, the
                   swapping is just pointer movement, and the subtraction
                   can be done in-place. */
                if (x > y)
                {
                    int t = y; y = x; x = t;
                }  // Swap x and y.
                y = y - x;                       // Here y >= x.
            } while (y != 0);

            /* restore common factors of 2 */
            return x << shift;
        }


    }
}
