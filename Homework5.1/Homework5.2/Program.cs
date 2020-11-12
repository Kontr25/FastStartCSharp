using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Homework5._2
{
    static class message
    {
        public static string CheckWords(string text, int wordsLength, params char[] separator)
        {
            string[] words = text.Split(separator);
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                if (word.Length <= wordsLength)
                {
                    result = result + word + " ";
                }
            }
            return result;
        }
        public static string DeleteWords(string text, string Symbol, params char[] separator)
        {
            string[] words = text.Split(separator);
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if ($"{word[word.Length - 1]}" != Symbol)
                {
                    result = result + word + " ";
                }
            }
            return result;

        }
        public static string LongMessage(string text, params char[] separator)
        {
            string[] words = text.Split(separator);
            string result = "";
            int max = 0;
            int index = 0;

            for (int i = 0; i < words.Length; i++)
            {
                
                if (words[i].Length > max)
                {
                    max = words[i].Length;
                    index = i;
                }
                
            }
            result = $"{words[index]}";
            return result;
        }
        public static StringBuilder LongMessageText(string text, params char[] separator)
        {
            string[] words = text.Split(separator);
            int max = words[0].Length;
            StringBuilder result = new StringBuilder();
            foreach (var word in words) if (word.Length > max) max = word.Length;
            foreach (var word in words) if (word.Length == max) result.Append($"{word} ");
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите любое предложение:");
            String text = Console.ReadLine();
            Console.WriteLine("Вывести только те слова сообщения, которые содержат не более скольки букв?");
            int userAnswer = Convert.ToInt32(Console.ReadLine());
            String b = message.CheckWords(text, userAnswer, ' ');
            Console.WriteLine("Слова в которых не более " + userAnswer + " букв: " + b);
            Console.Write("Введите буквку, на которую кончается слово, и это слово будет удалено: ");
            String Symbol = Console.ReadLine();
            String g = message.DeleteWords(text, Symbol, ' ');
            Console.WriteLine("Получившийся текст после удаления слов: " + g);
            Console.WriteLine($"Самое длинное слово: {message.LongMessage(text, ' ')}");
            Console.WriteLine($"Получившийся текст из саммых длинных слов: {message.LongMessageText(text, ' ')}");
            Console.ReadLine();
        }
    }
}

