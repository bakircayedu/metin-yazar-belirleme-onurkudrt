using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
    public class txtFile
    {

        public int wordCount;
        public int charCount;
        public int sentenceCount;

        public string fileName;
        public string filePath;
        public string fileSize;
        public string fileContext;

        SplitTools split = new SplitTools();

        public Stack sentence = new Stack();
        public Stack[] word;
        public BinarySearchTree sentenceTree = new BinarySearchTree();
        public BinarySearchTree[] wordTree;
        public Heap frequentlyUsedWords;

        public txtFile(string fileName,string filePath,string fileSize,string fileContext)
        {
            this.fileName = fileName;
            this.filePath = filePath;
            this.fileSize = fileSize;
            this.fileContext = fileContext;

            this.wordCount = split.wordCount(fileContext);
            this.charCount = split.charCount(fileContext);
            this.sentenceCount = split.sentenceCount(fileContext);
        }
        //Cümleler İçin Stack işlemleri
        public void moveToStackSentences()
        {
            moveToStackS(fileContext, sentence);
        }
        protected void moveToStackS(string context,Stack stack)
        {
            List<string>  list = split.splitSentences(context);
            for (int i = 0; i < list.Count; i++)
                stack.Push(list[i]);
        }
        public string showSentenceStack()
        {
            if (sentence == null || sentence.Size == 0)
                return "";
           List<Node> list = sentence.showStack();
            string temp = "";
            for (int i = 0; i < list.Count; i++)
                temp += (list.Count-i)+". Cümle\n"+list[i].Data + "\n\n";
            return temp;
        }
        //Cümleler İçin Ağaç İşlemleri
        public void moveToTreeSentences()
        {
            moveToTreeS(fileContext, sentenceTree);
        }
        protected void moveToTreeS(string context,BinarySearchTree tree)
        {
            List<string> list = split.splitSentences(context);
            for (int i = 0; i < list.Count; i++)
                tree.Insert(list[i], ((i + 1) + ". Cümle"));
        }
        //Cümle ağacını göster
        public string showSentenceTree()
        {
            return sentenceTree.writeNodesInOrder();
        }

        // Kelimeler için stack işlemleri
        protected void moveToStackW(string context,Stack stack)
        {
            List<string> list = split.splitWords(context);
            for (int i = 0; i < list.Count; i++)
                stack.Push(list[i]);
        }
        public void moveToStackWords()
        {
            if (sentence.Size == 0)
                moveToStackSentences();

                List<Node> sentenceList = sentence.showStack();
            word = new Stack[sentence.Size];
                for (int i = 0; i < sentenceList.Count; i++)
            {
                    word[i] = new Stack();
                moveToStackW(sentenceList[i].Data.ToString(), word[i]);
            }        
        }
        public string showWordStack()
        {
            if (word == null)
                return null;
            return showWordStack(word);
        }
        protected string showWordStack(Stack[] words)
        {
            string temp = "";
            for(int i=0;i<words.Length;i++)
            {
                temp += (words.Length-i) + ". Cümlenin Kelimeleri" +"\n";
                    List<Node> wordList = words[i].showStack();
                for (int j = 0; j < wordList.Count; j++)
                    temp+= wordList[j].Data + "\n";
                temp += "\n\n";
            }
            return temp;
        }

        //Kelimeler için ağaç işlemleri
        public void moveToTreeWords()
        {
            if (sentenceTree.isEmpty())
                moveToTreeSentences();
            wordTree = new BinarySearchTree[sentenceTree.Size];
            for (int i = 0; i < wordTree.Length; i++)
            {
                if (wordTree[i] == null)
                    wordTree[i] = new BinarySearchTree();
                string context = sentenceTree.searchInfo((i + 1) + ". Cümle");
                if (context == "")
                    continue;
                moveToTreeWords(context, wordTree[i], (i + 1));
            }
        }
        protected void moveToTreeWords(string context, BinarySearchTree tree,int count)
        {
            List<string> wordList = split.splitWords(context);
            for (int i = 0; i < wordList.Count; i++)
             tree.Insert(wordList[i], (i+1) + ". Kelime");
        }
        //Kelime ağacını göster
        public string showWordTree()
        {
            string temp = "";
            if (wordTree == null)
                return null;
            for (int i = 0; i < wordTree.Length; i++)
                temp += (i + 1) + ". Cümlenin Kelimeleri: \n" + wordTree[i].writeNodesInOrder() + "\n\n";
            return temp;
        }

        //Sık kullanılan kelimeler için çalışan fonksiyonlar
        protected List<wordClass> frequentlyUsedWordsF()
        {
            if (word == null)
                return null;
            FrequentlyUsedWords words = new FrequentlyUsedWords(word);
           List<wordClass> wordList =  words.determineFrequentlyUsedWords();
            return wordList;
        }
        public string showFrequentlyUsedWords()
        {
            List<wordClass> wordList = frequentlyUsedWordsF();
            if (wordList == null)
                return null;
                frequentlyUsedWords = new Heap(wordList.Count);
            for(int i=0; i<wordList.Count;i++)
            {
                heapNode temp = new heapNode(wordList[i].data, wordList[i].repetitionNumber);
                frequentlyUsedWords.insert(temp);
            }
            return frequentlyUsedWords.DisplayHeap();
        }
    }
}
