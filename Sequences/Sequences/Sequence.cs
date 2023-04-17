using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Sequences
{
    public class Sequence
    {
        public IEnumerable<BigInteger> Fibonacci()
        {
            BigInteger a = 1, b = 1;
            
            yield return a;
            yield return b;

            BigInteger c;

            do
            {
                c = a + b;
                yield return c;
                a = b;
                b = c;
            }while(true);
        }

        public IEnumerable<BigInteger> Factorial()
        {
            BigInteger n = 1, f = 1;

            while(true)
            {
                f *= n;
                yield return f;
                n++;
            }         
        }
    }
}
