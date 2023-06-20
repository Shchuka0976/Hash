using System.IO;
using System.Security.Cryptography;

namespace Hash
{
    internal class Program
    {
        private static string ComputeMD5Checksum(string path)
        {
            using (FileStream fs = System.IO.File.OpenRead(path))
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] fileData = new byte[fs.Length];
                fs.Read(fileData, 0, (int)fs.Length);
                byte[] checkSum = md5.ComputeHash(fileData);
                string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                return result;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь до файла");
            string path = Console.ReadLine();
            string Hash_file = ComputeMD5Checksum(path);
            Console.WriteLine(Hash_file);
            Console.ReadKey();


            



        }
    }
}