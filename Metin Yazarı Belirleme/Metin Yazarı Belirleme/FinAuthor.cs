using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Metin_Yazarı_Belirleme
{
    public class FindAuthor
    {
        txtFile file;
        List<Author> authors;
        public FindAuthor(txtFile file, List<Author> authors)
        {
            this.authors = authors;
            this.file = file;
        }

 
        public Author startFind()
        {
            if (authors.Count < 1)
            {
                MessageBox.Show("Yazar ekleyin.");
                return null;
            }
            else
            {
                int largest = 0;
                Author author = null;
                for (int i = 0; i < authors.Count; i++)
                {
                    int temp = findFUWs(file, authors[i]);
                    if (temp > largest)
                    {
                        largest = temp;
                        author = authors[i];
                    }
                }
                return author;
            }
        }
        protected int findFUWs(txtFile file, Author author)
        {
            if (file == null || author == null)
                return 0;  
            SplitTools splitTools = new SplitTools();
            MoveToStackAuthorWords(author);
            List<string> wordsOfAuthor = splitTools.splitWords( getFrequentlyUsedWords(author));
            List<string> wordsOfFile = splitTools.splitWords(file.showFrequentlyUsedWords());
            if (wordsOfFile.Count == 0)
            {
                MessageBox.Show("Dosya kelimelerini stack içerisine alın.");
                return 0;
            }
            return compareWords(wordsOfAuthor, wordsOfFile);
        }
        protected string getFrequentlyUsedWords(Author a)
        {
            string temp = "";
            for (int i = 0; i < a.files.Count; i++)
                temp += a.files[i].showFrequentlyUsedWords() + "\n";
            return temp;
        }
        protected void MoveToStackAuthorWords(Author a)
        {
            for (int i = 0; i < a.files.Count; i++)
                a.files[i].moveToStackWords();
        }


        protected int compareWords(List<string> list1, List<string> list2)
        {
            int total = 0;
            for (int i = 0; i < list1.Count; i++)
                for (int j = 0; j < list2.Count; j++)
                    if (list1[i] == list2[j])
                        total++;
            return total;
        }
    }
}
