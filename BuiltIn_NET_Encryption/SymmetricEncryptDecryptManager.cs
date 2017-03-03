using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuiltIn_NET_Encryption
{
    class SymmetricEncryptDecryptManager
    {
        public byte[] Key;
        public byte[] IV;
        public SymmetricAlgorithmType type
        {
            set
            {
                Crypto = SymmetricCryptoFactory.Create(value);
                Crypto.IV = IV;
                Crypto.Key = Key;
            }
        }

        private SymmetricAlgorithm Crypto;

        public void EncryptFile(string inputFile, string outputFile)
        {
            using (var fsCrypt = new FileStream(outputFile, FileMode.Create))
            {
                using (var cs = new CryptoStream(fsCrypt,
                       Crypto.CreateEncryptor(Crypto.Key, Crypto.IV),
                       CryptoStreamMode.Write))
                {
                    using (var fsIn = new FileStream(inputFile, FileMode.Open))
                    {
                        var bufferSize = 1024;
                        var bytesRead = 0;
                        var data = new byte[bufferSize];
                        while ((bytesRead = fsIn.Read(data, 0, bufferSize)) != 0)
                            cs.Write(data, 0, bytesRead);

                        fsIn.Close();
                        cs.Close();
                        fsCrypt.Close();
                    }
                }
            }
        }

        public void DecryptFile(string inputFile, string outputFile)
        {
            try
            {
                using (var fsCrypt = new FileStream(inputFile, FileMode.Open))
                {
                    using (var cs = new CryptoStream(fsCrypt,
                            Crypto.CreateDecryptor(Key, IV),
                            CryptoStreamMode.Read))
                    {
                        using (var fsOut = new FileStream(outputFile, FileMode.Create))
                        {
                            var bufferSize = 1024;
                            var bytesRead = 0;
                            var data = new byte[bufferSize];
                            while ((bytesRead = cs.Read(data, 0, bufferSize)) != 0)
                                fsOut.Write(data, 0, bytesRead);

                            fsOut.Close();
                            cs.Close();
                            fsCrypt.Close();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Decryption failed!", "Error");
            }
        }

    }

    enum SymmetricAlgorithmType
    {
        AES,
        Rijndael,
        DES,
        RC2,
        TripleDES
    }

    class SymmetricCryptoFactory
    {
        public static SymmetricAlgorithm Create(SymmetricAlgorithmType type)
        {
            switch (type)
            {
                case SymmetricAlgorithmType.AES:
                    return new AesCryptoServiceProvider();
                case SymmetricAlgorithmType.Rijndael:
                    return new RijndaelManaged();
                case SymmetricAlgorithmType.DES:
                    return new DESCryptoServiceProvider();
                case SymmetricAlgorithmType.RC2:
                    return new RC2CryptoServiceProvider();
                case SymmetricAlgorithmType.TripleDES:
                    return new TripleDESCryptoServiceProvider();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
