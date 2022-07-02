using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Vehicle_Number_Plate_Detection
{
    internal class Encryption
    {
        public string EncryptPassword(string data)
        {
            SHA1 sha = SHA1.Create();
            byte[] encryptData = sha.ComputeHash(Encoding.Default.GetBytes(data));

            StringBuilder returnValue = new StringBuilder();

            for(int i = 0; i < encryptData.Length; i++)
            {
                returnValue.Append(encryptData[i].ToString());
            }

            return returnValue.ToString();
        }
    }
}
