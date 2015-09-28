﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class GCDAlgorithmInt
    {


        public static int Euclid(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);

            if (x == y) return x;
            if (x == 0) return y;
            if (y == 0) return x;

            if (x < y)
                return Euclid(x, y % x);

            return Euclid(x % y, y);
        }

        public static int Euclid(int x, int y, out long time)
        {
            int result;
            Stopwatch timer = Stopwatch.StartNew();

            result = Euclid(x, y);

            timer.Stop();
            time = timer.ElapsedTicks;

            return result;
        }

        public static int Euclid(params int[] list)
        {

            switch (list.Length)
            {
                case 0:
                    throw new ArgumentException("list is empty");
                case 1:
                    return list[0];
                case 2:
                    return Euclid(list[0], list[1]);
                default:
                    break;
            }

            return Euclid( Euclid( list.Take(2).ToArray() ), Euclid( list.Skip(2).ToArray() ) );
        }



        public static int Binary(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);

            if (x == y) return x;
            if (x == 0) return y;
            if (y == 0) return x;

            if (x % 2 == 0)
            {
                if (y % 2 == 0)
                    return 2 * Binary(x / 2, y / 2);
                else
                    return Binary(x / 2, y);
            }

            if (y % 2 == 0)
                return Binary(x, y / 2);

            if (x > y)
                return Binary((x - y) / 2, y);

            return Binary(x, (y - x) / 2);
        }

        public static int Binary(int x, int y, out long time)
        {
            int result;
            Stopwatch timer = Stopwatch.StartNew();

            result = Binary(x, y);

            timer.Stop();
            time = timer.ElapsedTicks;

            return result;
        }

        public static int Binary(params int[] list)
        {
            switch (list.Length)
            {
                case 0:
                    throw new ArgumentException("list is empty");
                case 1:
                    return list[0];
                case 2:
                    return Binary(list[0], list[1]);
                default:
                    break;
            }

            return Binary(Binary(list.Take(2).ToArray()), Binary(list.Skip(2).ToArray()));
        }

    }
}
