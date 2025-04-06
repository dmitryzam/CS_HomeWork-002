using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 002. Используя пример с занятия, написать код, позволяющий пользователю вывести в файл все простые числа
// до введённого пользователем числа.
namespace CS_HomeWork_002
{    
    internal class Program
    {
        static void WriteToFile(string filePath, string content)
        {
            StreamWriter sr = new StreamWriter(filePath, true);
            sr.Write(content);
            sr.Close();
        }
        static bool isSimple(int n) // ф-ия проверки простого числа
        {
            if(n == 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(args[0]);
            int simpleNum = 0;
            string result = string.Empty;
            File.WriteAllText("file002.txt", string.Empty);
            WriteToFile("file002.txt", "Простые числа:\n");
            if(args.Length >= 1)
            {
                for (int i = 2; i <= num; i++)
                {                    
                    if (isSimple(i))
                    {
                        result = $"{i}\t";
                        WriteToFile("file002.txt", result);
                    }
                }
            }
            else
            {
                Console.WriteLine("Программа работает");
            }
        }
    }
}
