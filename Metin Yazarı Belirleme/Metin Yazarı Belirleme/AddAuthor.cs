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

    public partial class AddAuthor : Form
    {
        List<txtFile> txtFiles = new List<txtFile>();
        public Author author;
        public AddAuthor()
        {
            InitializeComponent();
        }
        
        private void AddAuthor_Load(object sender, EventArgs e)
        {

        }
        public void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSurname.Text == "")
                MessageBox.Show("Yazar adı veya soyadı boş olamaz");
            else if (txtFiles.Count == 0)
                MessageBox.Show("Yazar için dosya ekleyiniz");
            else
            {
                author = new Author(txtName.Text, txtSurname.Text, txtFiles);
                MessageBox.Show(txtFiles.Count.ToString());
                this.Close();
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            lblFileName.Text =  selectFile();
            lblFileName.Visible = true;
        }

        public string selectFile()
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

                for (int i = 0; i < txtFiles.Count; i++)
                    if (txtFiles[i].fileName == file.FileName)
                        isExist = true;
                string filePath = file.FileName;
                string fileName = file.SafeFileName;
                FileInfo fileInfo = new FileInfo(filePath);
                string fileSize = (Math.Round(((float)fileInfo.Length / 1024), 2)).ToString() + " KB";
                string fileContext = File.ReadAllText(filePath);
                if (!(isExist))
                {
                    txtFile newFile = new txtFile(fileName, filePath, fileSize, fileContext);
                    txtFiles.Add(newFile);
                }
                return fileName;
            }
            else
                MessageBox.Show("Hay aksi! Bir şeyler ters gitti.");
            return null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblFileName.Text == "-")
            {
                MessageBox.Show("Bir dosya seçiniz.");
                return;
            }    
            bool isExist = false;
            for (int i = 0; i < cbFiles.Items.Count; i++)
                if (cbFiles.Items[i].ToString() == lblFileName.Text)
                    isExist = true;
            if(!isExist)
            cbFiles.Items.Add(lblFileName.Text);
            lblFileName.Text = "-";
            lblFileName.Visible = false;
            gbFile.Visible = false;
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            gbFile.Visible = true;
        }

        private void lblFileName_Click(object sender, EventArgs e)
        {

        }
    }
}
