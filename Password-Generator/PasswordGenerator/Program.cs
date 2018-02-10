using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password: ");
            string passwordToConvert = Console.ReadLine();

            string password = Utils.Security.BCrypt.HashPassword(passwordToConvert);

            Console.WriteLine($"Password generated: {password}");
            Clipboard.SetText(password);
        }
    }
}
