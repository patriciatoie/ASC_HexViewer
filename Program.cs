using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HexViewer1
{
    internal class Program
    {
       
          static void Main(string[] args)
          {
                Console.WriteLine("Program C# care functioneza ca un viewer hexazecimal pentru continutul unui fisier.");

                Console.WriteLine("Introduceti adresa fisierului:");

                //string path = @"c:\Users\patit\OneDrive\Desktop\Interactiuni.txt"; 
                string path = Console.ReadLine();
                int index = 0;
                byte[] b = new byte[16]; //trebuie sa fie hexazecimal
                int readLen;
                FileStream fs = new FileStream(path, FileMode.Open);
                while ((readLen = fs.Read(b, 0, 16)) > 0)
                {
                    string hex = BitConverter.ToString(b); //converteste valoarea numerica a elementelor vectorului b reprezentata ca biti in perechi de hexazecimale stringuri
                    string text = null;
                    for (int i = 0; i < readLen; i++)
                    {
                        if (b[i] < ' ')
                            text += ".";
                        else
                            text += ((char)b[i]).ToString();
                    }
                  Console.WriteLine($"{index:X8}: {hex} | {text}");
                  index++;
                }
          }
    }
}
