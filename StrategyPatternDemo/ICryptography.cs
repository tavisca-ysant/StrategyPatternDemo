using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo
{
    public interface ICryptography
    {
        string EncryptData(string plainText);

        string DecryptData(string cipherText);
    }
}
