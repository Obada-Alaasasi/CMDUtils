using System.Text;
using System.Windows;
using TextCopy;

namespace B64 {
    internal class Program {
        static void Main(string[] args) {
            string flag = args[0];
            string output = "";
            if (flag == "-d")
                Decode64(args[1], out output);
            if (flag == "-e")
                Encode64(args[1], out output);

            Console.WriteLine(output);
            ClipboardService.SetText(output);
        }
        static void Decode64(string input, out string output) =>
            output = Encoding.UTF8.GetString(Convert.FromBase64String(input));
        static void Encode64(string input, out string output) =>
            output = Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
    }
}
