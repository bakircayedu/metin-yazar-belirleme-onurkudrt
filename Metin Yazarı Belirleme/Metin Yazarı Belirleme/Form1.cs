using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        List<txtFile> fileArray;
        List<Author> authorArray;
        int counter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileArray = new List<txtFile>();
            authorArray = new List<Author>();
            this.counter = 0;
        }
        // Dosya seçmek için çalışan fonksiyon
        public string[] selectFile()
        { 
            OpenFileDialog file = new OpenFileDialog()
            {
                FileName = "Dosya Adı",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Okutulacak Dosyayı Seçin",
            };
            if (file.ShowDialog() == DialogResult.OK)
            {
                bool isExist = false;

                for (int i = 0; i < counter; i++)
                    if (fileArray[i].fileName == file.FileName)
                        isExist = true;
                string filePath = file.FileName;
                string fileName = file.SafeFileName;
                FileInfo fileInfo = new FileInfo(filePath);
                string fileSize = ( Math.Round( ((float)fileInfo.Length/1024),2) ).ToString()+" KB";
                string fileContext = File.ReadAllText(filePath);

                if (!(isExist))
                {
                    txtFile newFile = new txtFile(fileName, filePath,fileSize,fileContext);
                    fileArray.Add(newFile);
                    counter++;
                }
                string[] temp = {filePath, fileName};
                return temp;
            }
            else
                MessageBox.Show("Hay aksi! Bir şeyler ters gitti.");
            return null;
        }
        //Dosya eklendiği zaman gerekli işlemleri yerine getirir
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            string[] returnValues = selectFile();
            if (returnValues != null)
            {
                txtFilePath.Text = returnValues[0];
                lblFileName.Text = returnValues[1];
                lblFileName.Visible = true;
                installFileList(returnValues[1]);
            }
        }
        //Dosya listesini her eklemeden sonra gerekiyorsa günceller
        public void installFileList(string name)
        {
            int listLength = fileList.Items.Count;
            bool isExist = true;
            for (int i = 0; i <listLength; i++)
                if (fileList.Items[i].ToString() == name)
                    isExist = false;
            if (isExist)
            {
                fileList.Items.Add(name);
                cbExistFiles.Items.Add(name);
            }
        }
        //Seçilen dosyayı yeni bir formda üzerinde işlem yapılmak üzere açar
        private void btnShowFile_Click(object sender, EventArgs e)
        {

            string selectedFile = cbExistFiles.Text;
            int selectedIndex = -1;
            for (int i = 0; i < cbExistFiles.Items.Count; i++)
                if (cbExistFiles.Items[i].ToString() == selectedFile)
                { 
                    selectedIndex = i;
                    break;
                }

            if (selectedIndex == -1)
                MessageBox.Show("Bir şeyler ters gitti.");
            else
            {
                FileOperations newForm = new FileOperations(fileArray[selectedIndex],authorArray);
                newForm.Show();
            }
        }
        //Yazar Ekle tuşuna basıldığı zaman gerekli fonksiyonu çağıracak ve kayıtlı bir yazar değilse kaydedecektir.
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Author temp = addAuthorFunction();

            if (installAuthorList(temp))
                MessageBox.Show("Yazar Zaten Kayıtlı");
            else
            {
                authorArray.Add(temp);
                cbAuthorList.Items.Add(temp.Name + " " + temp.Surname);
            }
        }
        //Eklenen yazarın var olup olmadığını belirleyen dosya
        private bool installAuthorList(Author author)
        {
            for (int i = 0; i < authorArray.Count; i++)
                if (author.Name + author.Surname == authorArray[i].Name + authorArray[i].Surname)
                    return true;
            return false;
        }
        //Yazar eklemek istediğimiz zaman çalışacak olan fonksiyon
        public Author addAuthorFunction()
        {
            AddAuthor addAuthor = new AddAuthor();
            addAuthor.ShowDialog();
            return addAuthor.author;
        }
    }
}
