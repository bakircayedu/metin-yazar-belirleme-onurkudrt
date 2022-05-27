using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
    public class SplitTools
    {
        public char[] splitSentenceChars = { '!', '.', ':', ';', '?', '\n' };
        public char[] splitWordChars = { ' ', ',','\n','.' };
        //Kelime sayısı
        public int wordCount(string text)
        {
            int counter = 0;
            string[] splitText = text.Split(splitWordChars);
            for (int i = 0; i < splitText.Length; i++)
                if (splitText[i] == "\r" || splitText[i] == "")
                    continue;
                else
                    counter++;
            return counter;
        }
        //Cümle sayısı
        public int sentenceCount(string text)
        {
            int counter = 0;
            string[] splitText = text.Split(splitSentenceChars);
            for (int i = 0; i < splitText.Length; i++)
                if (splitText[i] == "\r" || splitText[i] == "\n")
                    continue;
                else
                    counter++;
            return counter;
        }
        public int charCount(string text)
        {
            return text.Length;
        }
        public List<string> splitSentences(string text)
        {
           string[] array = text.Split(splitSentenceChars);
            List<string> newList = new List<string>();
            for (int i = 0; i < array.Length; i++)
                if (array[i] == "\r" || array[i] == "" || array[i] == " "|| array[i] == "\n")
                    continue;
                else
                    newList.Add(array[i]);
            return newList;
        }
        public List<string> splitWords(string text)
        {
            string[] array = text.Split(splitWordChars);
            List<string> newList = new List<string>();
            for (int i = 0;i<array.Length;i++)
            {
                if (array[i] == "\r" || array[i] == "" || array[i] == " " || array[i] == "\n")
                    continue;
                else
                    newList.Add(array[i]);
            }
            return newList;
        }
    }
}
