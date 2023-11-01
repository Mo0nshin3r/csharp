// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

try
{
    using (FileStream fileStream = new("TestData.txt", FileMode.OpenOrCreate))
    {
        using (Aes aes = Aes.Create())
        {
            byte[] key =
            {
                0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
            };
            aes.Key = key;

            byte[] iv = aes.IV;
            fileStream.Write(iv, 0, iv.Length);

            using (CryptoStream cryptoStream = new(
                fileStream,
                aes.CreateEncryptor(),
                CryptoStreamMode.Write))
            {
                
                Console.WriteLine("enter something to encrypt: ");
                string entry = Console.ReadLine();
                using (StreamWriter encryptWriter = new(cryptoStream))
                {
                    encryptWriter.WriteLine(entry);
                }


             
            }
        }
    }

    Console.WriteLine("The file was encrypted.");
}
catch (Exception ex)
{
    Console.WriteLine($"The encryption failed. {ex}");
}




try
{
    using (FileStream fileStream = new("TestData.txt", FileMode.Open))
    {
        using (Aes aes = Aes.Create())
        {
            byte[] key =
            {
                0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
            };
            aes.Key = key;

            byte[] iv = new byte[16];
            fileStream.Read(iv, 0, iv.Length);
            aes.IV = iv;

            using (CryptoStream cryptoStream = new(
                fileStream,
                aes.CreateDecryptor(),
                CryptoStreamMode.Read))
            {
                using (StreamReader decryptReader = new(cryptoStream))
                {
                    string decryptedText = decryptReader.ReadLine();
                    Console.WriteLine("Decrypted Text: " + decryptedText);
                }
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"The decryption failed. {ex}");
}

