using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSIM
{
    static class GeneradorDistribuciones
    {
        static Random random = new Random();
        public static int UniformeAB(int a, int b)
        {
            double uniformeAB = a + ((b - a) * random.NextDouble());
            return Convert.ToInt32(uniformeAB);
        }

        public static int UniformeAB(int a, int b, out double rnd)
        {
            rnd= random.NextDouble();
            double uniformeAB = a + ((b - a) * rnd);
            return Convert.ToInt32(uniformeAB);
        }
    }
}
