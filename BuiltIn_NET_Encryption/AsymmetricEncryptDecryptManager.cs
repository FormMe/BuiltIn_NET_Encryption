using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BuiltIn_NET_Encryption
{
    class AsymmetricEncryptDecryptManager
    {
        private string _publicKey;
        public string publicKey => _publicKey;
        private string _privateKey;
        public string privateKey => _privateKey;
        
        public bool DoOAEPPadding;
         

        public void GenerateKeys(int keySize)
        {
            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                _publicKey = provider.ToXmlString(false);
                _privateKey = provider.ToXmlString(true);
            }
        }

        public void EncryptFile(string inputFile, string outputFile)
        {
            var encryptData = File.ReadAllBytes(inputFile);
            byte[] encryptedData;

            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKey);
                encryptedData = rsa.Encrypt(encryptData, DoOAEPPadding);
            }
            File.WriteAllBytes(outputFile, encryptedData);
        }


        public void DecryptFile(string inputFile, string outputFile)
        {
            var decryptData = File.ReadAllBytes(inputFile);
            byte[] decryptedData;

            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privateKey);
                decryptedData = rsa.Decrypt(decryptData, DoOAEPPadding);
            }
            File.WriteAllBytes(outputFile, decryptedData);
        }
    }

    enum AsymmetricAlgorithmType
    {
        DSA,
        RSA
    }

    class AsymmetricCryptoFactory
    {
        public static AsymmetricAlgorithm Create(SymmetricAlgorithmType type)
        {
            switch (type)
            {
                case SymmetricAlgorithmType.AES:
                    return new DSACryptoServiceProvider();
                case SymmetricAlgorithmType.Rijndael:
                    return new RSACryptoServiceProvider();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
