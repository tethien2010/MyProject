using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.PGP
{
    class PGPUse
    {
        public void GenerateKey(string username, string password, string startuppath, out string privatekey, out string publickey)
        {
            KeysForPGPEncryptionDecryption.GenerateKey(username, password, startuppath);
            privatekey = File.ReadAllText("PGPPrivateKey.asc");
            publickey = File.ReadAllText("PGPPublicKey.asc");
        }
        public string PGPEncrypt(string password, string fileinfo)
        {
            PgpEncryptionKeys encryptionKeys = new PgpEncryptionKeys("PGPPublicKey.asc", "PGPPrivateKey.asc", password);
            PgpEncrypt encrypter = new PgpEncrypt(encryptionKeys);
            using (Stream outputStream = File.Create("EncryptData.txt"))
            {
                encrypter.EncryptAndSign(outputStream, new FileInfo(fileinfo));

            }
            return File.ReadAllText("EncryptData.txt");
        }
        public string PGPDecrypts(string password, string fileinfo)
        {
            PGPDecrypt.Decrypt("EncryptData.txt", @"PGPPrivateKey.asc", password, "OriginalText.txt");
            return File.ReadAllText("OriginalText.txt");
        }
    }
}
