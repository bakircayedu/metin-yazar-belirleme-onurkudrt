using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
    public class FrequentlyUsedWords
    {

        List<Node> wordList;
        int totalNumberOfUses;
        public FrequentlyUsedWords(Stack[] words)
        {
            wordList = moveStackArrayToNodeList(words);
        }

        // Dizi halinde tutulan stack yapılarını tek bir liste içerisinde toplamak için
        protected List<Node> moveStackArrayToNodeList(Stack[] stackArray)
        {
            if (stackArray == null)
                return null;
            List<Node> newList = new List<Node>();
            for (int i = 0; i < stackArray.Length; i++)
            {
                int length = stackArray[i].Size;
                List<Node> temp = stackArray[i].showStack();
                for (int j = 0; j < length; j++)
                    newList.Add(temp[j]);
            }
            return newList;
        }

        //Bütün bu belirleme fonksiyonlarını tek çatı altında çağırarak
        //Sonuçları liste halinde döndüren fonksiyon
        public List<wordClass> determineFrequentlyUsedWords()
        {
          return determine( writeRepetitiveWords(wordList) );
        }

        //2 kereden fazla tekrar etmiş kelimeleri
        //Konrol etmek için bir liste içerisinde toplar
        protected List<wordClass> writeRepetitiveWords(List<Node> words)
        {
            int total = 0;
            List<wordClass> newList = new List<wordClass>();
            for(int i=0;i<words.Count;i++)
            { 

                if (isExist(words[i], newList))
                    continue;
                else
                {
                    int repetitionNumber = 1;
                    for (int j = 0; j < words.Count; j++)
                        if (i == j)
                            continue;
                        else if (words[i].Data.ToString() == words[j].Data.ToString())
                            repetitionNumber++;
                    if(repetitionNumber>1)
                    {
                        wordClass temp = new wordClass(words[i].Data, repetitionNumber);
                        newList.Add(temp);
                        total += repetitionNumber;
                    }
                }
            }
            totalNumberOfUses = total;
            return newList;
        }


        protected bool isExist(Node node, List<wordClass> doesItContain)
        {
            for (int i = 0; i < doesItContain.Count; i++)
                    if (doesItContain[i].data.ToString() == node.Data.ToString())
                        return true;
            return false;
        }
        //Tekrarlı kelimelerin toplam tekrar miktarını kelime sayısına bölerek
        //Ortalama tekrar miktarını belirler
        //Eğer ortalamanın üzerinde tekrar sayısına ulaşmış kelime varsa bu kelimeyi
        //Sık kullanılmış kelime olarak belirler ve bu kelimelerden yeni bir liste oluşturur
        protected List<wordClass> determine(List<wordClass> list)
        {
            if (list.Count == 0)
                return null;
            int average =totalNumberOfUses /list.Count;
            List<wordClass> newList = new List<wordClass>();
            for (int i = 0; i < list.Count; i++)
                if (list[i].repetitionNumber >= average)
                    newList.Add(list[i]);
            return newList;
        }
    }
    public class wordClass
    {
        public object data;
        public int repetitionNumber;
        public wordClass(object data,int repetitionNumber)
        {
            this.data = data;
            this.repetitionNumber = repetitionNumber;
        }
    }
}
