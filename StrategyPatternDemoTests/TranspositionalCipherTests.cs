using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using StrategyPatternDemo;

namespace StrategyPatternDemoTests
{
    
    public class TranspositionalCipherTests
    {
        private TranspositionalCipher _transpositionalCipher = new TranspositionalCipher();
        [Fact]
        public void ValidEncryptionTest()
        {
            string plainText = "The quick brown fox jumps over the lazy dog";
            var cipherText = _transpositionalCipher.EncryptData(plainText);
            var decodedPlainText = _transpositionalCipher.DecryptData(cipherText);
            Assert.Equal(decodedPlainText.Trim(), plainText);
        }

       


    }
}
