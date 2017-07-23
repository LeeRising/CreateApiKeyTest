using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateApiKey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("id:");
            var id = Console.ReadLine();
            Console.Write("Name:");
            var name = Console.ReadLine();
            var hash = Sha1Hash(DateTime.Now.ToString("dd-MM-yy HH:mm:ss") + id + name);
            Console.WriteLine(hash);
        }
        public static string Sha1Hash(string input)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Join("", hash.Select(b => b.ToString("x2")).ToArray());
        }
    }
}
