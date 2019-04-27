using System;
using System.IO;
using System.Text.RegularExpressions;

namespace iDontKnow
{
    public class ReadFile
    {
        public virtual void ReadAndWrite(string x, string y)
        {
            using (StreamReader sr = new StreamReader("Users.txt"))
            {
                string line;
                string pattern = @"\t+";
                Regex rgx = new Regex(pattern);
                while ((line = sr.ReadLine()) != null)
                {
                   string[] result = rgx.Split(line);
                    Console.WriteLine("{0}", result[1]);
                }
            }
        }
    }
}
