namespace StrategyPatternDemo
{
    public class SubstitutionalCipher : ICryptography
    {
        private string _key = "jfkgotmyvhspcandxlrwebquiz";
        public string DecryptData(string cipherText)
        {
            char[] cipherTextCharacters = new char[cipherText.Length];

            for (int outerIndex = 0; outerIndex < cipherText.Length; outerIndex++)
            {
                if (cipherText[outerIndex] == ' ')
                {
                    cipherTextCharacters[outerIndex] = ' ';
                }
                else
                {
                    int innerIndex = _key.IndexOf(cipherText[outerIndex]) + 97;
                    cipherTextCharacters[outerIndex] = (char)(innerIndex);
                }
            }

            return new string(cipherTextCharacters);
        }

        public string EncryptData(string plainText)
        {
            char[] plainTextCharacters = new char[plainText.Length];

            for (int outerIndex = 0; outerIndex < plainText.Length; outerIndex++)
            {
                if (plainText[outerIndex] == ' ')
                {
                    plainTextCharacters[outerIndex] = ' ';
                }
                else
                {
                    int innerIndex = plainText[outerIndex] - 97;
                    plainTextCharacters[outerIndex] = _key[innerIndex];
                }
            }

            return new string(plainTextCharacters);
        }
    }
}