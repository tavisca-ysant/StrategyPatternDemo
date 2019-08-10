using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using StrategyPatternDemo;

namespace StrategyPatternDemoTests
{
    public class CryptographyFactoryTests
    {
        [Fact]
        public void SubstitutionalCipherTest()
        {
            Assert.IsType<SubstitutionalCipher>(CryptographyFactory.GetAlgorithm("substitutional"));
        }

        [Fact]
        public void TranspositionalCipherTest()
        {
            Assert.IsType<TranspositionalCipher>(CryptographyFactory.GetAlgorithm("transpositional"));
        }

        [Fact]
        public void InValidAlgorithmTest()
        {
            Assert.Throws<InValidAlgorithmException>(() => CryptographyFactory.GetAlgorithm("ceaser"));
        }

    }
}
