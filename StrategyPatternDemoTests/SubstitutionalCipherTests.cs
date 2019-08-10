using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using StrategyPatternDemo;

namespace StrategyPatternDemoTests
{
    public class SubstitutionalCipherTests
    {
        private SubstitutionalCipher _substitutionalCipher = new SubstitutionalCipher();
        [Fact]
        public void ValidEncryptionTest()
        {
            string plainText = "the quick brown fox jumps over the lazy dog";
            var cipherText = _substitutionalCipher.EncryptData(plainText);
            var decodedCipherText = _substitutionalCipher.DecryptData(cipherText);
            Assert.Equal(decodedCipherText, plainText);
        }
    }
}
