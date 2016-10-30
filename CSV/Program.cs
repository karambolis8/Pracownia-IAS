using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(File.OpenRead(@"C:\Users\Adam\Documents\studia\UE\IAS\baza bmw.csv"));
            var writer = new StreamWriter(@"C:\Users\Adam\Documents\studia\UE\IAS\baza_bmw.sql", false, Encoding.UTF8);
            var sb = new StringBuilder();

            while(!reader.EndOfStream)
            {
                var values = reader.ReadLine().Split(';');
                sb.Clear();
                sb.Append(string.Format("(\"{0}\", \"{1}\", \"{2}\", '{3}', {4}, {5}, '{6}', {7}, \"{8}\"),", values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8]));
                writer.WriteLine(sb.ToString());
            }

            reader.Close();
            writer.Close();
        }
    }
}
