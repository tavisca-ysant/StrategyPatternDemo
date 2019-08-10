using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo
{
    public class CryptographyFactory
    {
        
        public static ICryptography GetAlgorithm(string algorithmName)
        {
            switch (algorithmName)
            {
                case "transpositional": return new TranspositionalCipher();
                case "substitutional": return new SubstitutionalCipher();
                default:
                    throw new InValidAlgorithmException();
            }
        }

    }
}
