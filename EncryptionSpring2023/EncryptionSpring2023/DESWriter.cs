using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace EncryptionSpring2023
{
    public class DESWriter : FileWriter
    {

        private const string key = "12345678";
        public DESWriter(string aPath)
        {
            this.path = aPath;
        }

        // this is override because we are changing the oringal decrypt file method in the super class
        protected override void DecryptFile()
        {
            if (File.Exists(path))
            {
                using (FileStream fs = File.Open(path, FileMode.OpenOrCreate))
                {
                    DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                    DES.Key = ASCIIEncoding.ASCII.GetBytes(key);
                    DES.IV = ASCIIEncoding.ASCII.GetBytes(key);
                    ICryptoTransform desDecrypt = DES.CreateDecryptor();
                    CryptoStream cryptoStreamDecr = new CryptoStream(fs, desDecrypt, CryptoStreamMode.Read);
                    StreamWriter fsDecrypted = new StreamWriter(path);
                    fsDecrypted.Write(new StreamReader(cryptoStreamDecr).ReadToEnd());
                    fsDecrypted.Flush();
                    fsDecrypted.Close();

                }
            }

        }
        // why didnt we write override?
        protected override void AppendFile(string data)
        {
            using (FileStream fs = File.Open(path, FileMode.Append))
            {
                using (TextWriter tw = new StreamWriter(fs))
                {
                    tw.Write(data);
                }
            }
        }

        // void, string and int are options of what type we want to return, when its void, we wont return anything
        protected override void EncryptFile()
        {
            if (File.Exists(path))
            {
                using (FileStream fs = File.Open(path, FileMode.Open))
                {

                    FileStream fsEncrypted = new FileStream(path, FileMode.Create, FileAccess.Write);


                    DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                    DES.Key = ASCIIEncoding.ASCII.GetBytes(key);
                    DES.IV = ASCIIEncoding.ASCII.GetBytes(key);
                    ICryptoTransform desDecrypt = DES.CreateEncryptor();

                    CryptoStream cryptoStreamEncrypt = new CryptoStream(fs, desDecrypt, CryptoStreamMode.Write);


                    byte[] byteArrayInput = new byte[fs.Length];

                    cryptoStreamEncrypt.Write(byteArrayInput, 0, byteArrayInput.Length);
                    cryptoStreamEncrypt.Close();
                    fs.Close();
                    fsEncrypted.Close();




                }
            }

        }



    }


        // The AppendFile does not need to be overriden 

    
}
