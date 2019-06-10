using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace task11__836_
{
    class Program
    {
        //зашифровать введенный текст
        static string Encrypt(string input,char[]original,char[]cipher)
        {
            char[] inputChars = input.ToCharArray();

            for (int i = 0; i < inputChars.Length; i++)
            {
                for (int j = 0; j < original.Length; j++)
                {
                    if (inputChars[i] == original[j])
                    {
                        //замена исходного символа на шифр
                        inputChars[i] = cipher[j];
                    }
                }
            }
            return  new string(inputChars);
        }

        //расшифровать введенный текст
        static string Decrypt(string input, char[] original, char[] cipher)
        {
            char[] inputChars = input.ToCharArray();
            for (int i = 0; i < inputChars.Length; i++)
            {
                for (int j = 0; j < original.Length; j++)
                {
                    if (inputChars[i] == cipher[j])
                    {
                        //замена шифра на исходный символ
                        inputChars[i] = original[j];
                    }
                }
            }
            return  new string(inputChars);
        }
        static void Main(string[] args)
        {
            //программа зашифровывает и расшифровывает введенный текст

            string eng = "abcdefghijklmnopqrstuvwxyz";
            string rus = "абвгдеёжзийклмнопрстуфхцчш";
            char[] engLetters = eng.ToCharArray();//символы исходного алфавита
            char[] rusLetters = rus.ToCharArray();//символы шифровального алфавита

            Console.WriteLine("Исходный сивол-его шифр");
            //печать таблицы соответствий символов
            for(int i = 0; i < engLetters.Length; i++)
                Console.Write(engLetters[i] + " - " + rusLetters[i] + "\t\t\t");
            Console.WriteLine();

            Console.WriteLine("Программа заменяет английские строчные буквы на соответствующие русские строчные буквы(с а до ш) и наоборот");
            Console.WriteLine("Введите текст (на английском языке)");
            //ввод текста
            string input = Console.ReadLine();
            
            //зашифровать введенный текст
            string output = Encrypt(input, engLetters, rusLetters);
            //если текст на русском, то его невозможно зашифровать
            if (input.Equals(output)) Console.WriteLine("Введенный текст был на русском языке, поэтому он уже зашифрован");
            else
            {
                Console.WriteLine("Текст после шифрования:");
                Console.WriteLine(output);
            }
            //расшифровать введенный текст
            output = Decrypt(output, engLetters, rusLetters);
            Console.WriteLine("Текст после расшифровки:");
            Console.WriteLine(output);
        }
    }
}
