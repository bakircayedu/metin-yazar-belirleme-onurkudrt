using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metin_Yazarı_Belirleme
{
    public partial class FileOperations : Form
    {
        txtFile file;
        List<Author> authors;
        public FileOperations(txtFile file, List<Author> authors)
        {
            InitializeComponent();
            this.file = new txtFile(file.fileName, file.filePath,file.fileSize, file.fileContext);
            this.authors = authors;
        }
        private void FileOperations_Load(object sender, EventArgs e)
        {
            lblSentenceCount.Text =file.sentenceCount.ToString();
            lblWordCount.Text = file.wordCount.ToString();
            lblCharCount.Text = file.charCount.ToString();
            lblFileSize.Text = file.fileSize;
            lblAverageWordCount.Text = (file.wordCount / file.sentenceCount).ToString(); 
            lblAverageWordCount.Visible =lblFileSize.Visible = lblWordCount.Visible
            = lblCharCount.Visible = lblSentenceCount.Visible = true;
        }


        private void readToStack_Click(object sender, EventArgs e)
        {
            file.moveToStackWords();
        }

        private void btnMoveToTree_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFrequentlyWords_Click(object sender, EventArgs e)
        {
           
        }


        private void btnRunSentence_Click(object sender, EventArgs e)
        {
            switch (cbSentenceOptions.Text)
            {
                case "Stack İçerisine Al":
                    file.moveToStackSentences();
                    labelControl("+Cümleler Stack içerisine alındı.");
                    break;
                case "Ağaç İçerisine Al":
                    file.moveToTreeSentences();
                    labelControl("+Cümleler Ağaç içerisine alındı.");
                    break;
                case "Ağacı Görüntüle":
                    labelControl("");
                    addItemsToListView(splitToItems(file.showSentenceTree()) );
                    break;
                case "Stack Görüntüle":
                    labelControl("");
                    addItemsToListView(splitToItems(file.showSentenceStack()) );
                    break;
                default:
                    labelControl("");
                    MessageBox.Show("Geçerli Bir İşlem Seçiniz.");
                    break;
            }
        }

        private void btnRunWord_Click(object sender, EventArgs e)
        {
            switch(cbWordOptions.Text)
            {
                case "Stack İçerisine Al":
                    file.moveToStackWords();
                    labelControl("+Kelimeler Stack içerisine alındı.");
                    break;
                case "Ağaç İçerisine Al":
                    file.moveToTreeWords();
                    labelControl("+Kelimeler Ağaç içerisine alındı.");
                    break;
                case "Ağacı Görüntüle":
                    labelControl("");
                    addItemsToListView( splitToItems(file.showWordTree()));
                    break;
                case "Stack Görüntüle":
                    labelControl("");
                    addItemsToListView(splitToItems(file.showWordStack()));
                    break;
                case "Sık Kullanılan Kelimeler":
                    labelControl("");
                    string text = file.showFrequentlyUsedWords();
                    if (text == null)
                        text = "";
                    if (file.word == null)
                        MessageBox.Show("Bu işlemi kullanmak için önce kelimeleri stack içerisine almalısınız.");
                    else
                        addItemsToListView(splitToItems(text));
                    break;
                default:
                    labelControl("");
                    MessageBox.Show("Geçerli Bir İşlem Seçiniz");
                    break;
            }
        }
        public List<string> splitToItems(string text)
        {
            if (text == null)
                return null;

            string[] items = text.Split('\n');
            List<string> newList = new List<string>();
            for (int i = 0; i < items.Length; i++)
                if (items[i] == "\r" || items[i] == "")
                    continue;
                else newList.Add(items[i]);
            return newList;
        }
        public void addItemsToListView(List<string> list)
        {
            if (list == null)
            {
                MessageBox.Show("Önce geçerli veri yapısına verileri gönderin");
                return;
            }
            listView.Items.Clear();
            for (int i = 0; i < list.Count; i++)
                listView.Items.Add(list[i]);
        }
        public void labelControl(string labelText)
        {
            if (labelText == "")
                lblOperation.Visible = false;
            else
            {
                lblOperation.Text = labelText;
                lblOperation.Visible = true;
            }
        }

        private void btnFindAuthor_Click(object sender, EventArgs e)
        {
            if (file.word == null)
                MessageBox.Show("Bu işlemi kullanabilmek için önce kelimeleri Stack içerisine alın.");
            else
            findAuthorF();
        }
        public void findAuthorF()
        {
            FindAuthor find = new FindAuthor(file,authors);
            Author author = find.startFind();
            if (author == null)
                MessageBox.Show("Eşleşme Yok.");
            else
            {
                string Name = author.Name;
                string Surname = author.Surname;
                MessageBox.Show(Name + " " + Surname);
            }
        }
    }
}
