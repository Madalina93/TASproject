using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchmidtSamoa
{
    public class SchmidtSamoa       
    {
        private BigInteger p, q, N, L, d;
        private BigInteger unu = new BigInteger("1");

        //public int lcm(int p, int q)
        //{
        //    int num1, num2;
        //    if (p > q)
        //    {
        //        num1 = p; num2 = q;
        //    }
        //    else
        //    {
        //        num1 = q; num2 = p;
        //    }

        //    for (int i = 1; i < num2; i++)
        //    {
        //        if ((num1 * i) % num2 == 0)
        //        {
        //            return i * num1;
        //        }
        //    }
        //    return num1 * num2;

        //}

        private BigInteger lcm(BigInteger p, BigInteger q)
        {
            BigInteger gcd = p.Gcd(q);
            return ((p.Multiply(q)).Divide(gcd));
        }

        public byte[] Encrypt(byte[] message)
        {
            BigInteger msj = new BigInteger(message);
            BigInteger c = msj.ModPow(N, N);
            return c.ToByteArray();
        }

        public byte[] Decrypt(byte[] chipertext)
        {
            BigInteger c = new BigInteger(chipertext);
            BigInteger m = c.ModPow(d, p.Multiply(q));

            return m.ToByteArray();
        }

        public SchmidtSamoa(int k)
        {
            p = BigInteger.ProbablePrime(k /2, new Random());  //de ce e k/2
            q = BigInteger.ProbablePrime(k /4, new Random());  // de ce e k/4
            N = (p.Pow(2).Multiply(q));
            L = lcm(p.Subtract(unu), (q.Subtract(unu)));
            d = N.ModInverse(L);
        }
    }
}
