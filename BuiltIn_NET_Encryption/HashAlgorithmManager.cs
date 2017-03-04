using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BuiltIn_NET_Encryption
{
    class HashAlgorithmManager
    {
        HashAlgorithm hashFunction;
        HashAlgorithmType _type;

        public HashAlgorithmType type
        {
            get { return _type; }
            set
            {
                _type = value;
                hashFunction = HashAlgorithmFactoty.Create(_type);
            }
        }

        public byte[] Computehash(byte[] mes)
        {
            return hashFunction.ComputeHash(mes); 
        }
    }

    enum HashAlgorithmType
    {
        MD5,
        SHA1,
        SHA256,
        SHA384,
        SHA512,
        RIPEMD160
    }

    static class HashAlgorithmFactoty
    {
        public static HashAlgorithm Create(HashAlgorithmType type)
        {
            switch (type)
            {
                case HashAlgorithmType.MD5:
                   return new MD5CryptoServiceProvider();
                case HashAlgorithmType.SHA1:
                    return new SHA1Managed();
                case HashAlgorithmType.SHA256:
                    return new SHA256Managed();
                case HashAlgorithmType.SHA384:
                    return new SHA384Managed();
                case HashAlgorithmType.SHA512:
                    return new SHA512Managed();
                case HashAlgorithmType.RIPEMD160:
                    return new RIPEMD160Managed();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
