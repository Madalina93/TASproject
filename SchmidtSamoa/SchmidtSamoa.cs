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
        private BigInteger bigInt = new BigInteger("1");

        private BigInteger lcm(BigInteger p, BigInteger q)
        {
            BigInteger gcd = p.Gcd(q);
            return ((p.Multiply(q)).Divide(gcd));
        }

        public SchmidtSamoa(int k)
        {
            p = BigInteger.ProbablePrime(k / 2, new Random()); // k ?
            q = BigInteger.ProbablePrime(k, new Random());  // 
            N = (p.Pow(2).Multiply(q));
            L = lcm(p.Subtract(bigInt), (q.Subtract(bigInt)));
            d = N.ModInverse(L);
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

        
    }
}
