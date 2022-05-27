
namespace Metin_Yazarı_Belirleme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.fileList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbExistFiles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowFile = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.cbAuthorList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(11, 57);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 26);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Dosya Seç";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(11, 31);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(305, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(9, 13);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(102, 13);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "Seçilen Dosya Yolu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dosya Adı:";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(173, 64);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(10, 13);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.Text = "-";
            this.lblFileName.Visible = false;
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(14, 168);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(278, 186);
            this.fileList.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Var Olan Dosyalar";
            // 
            // cbExistFiles
            // 
            this.cbExistFiles.FormattingEnabled = true;
            this.cbExistFiles.Location = new System.Drawing.Point(13, 376);
            this.cbExistFiles.Name = "cbExistFiles";
            this.cbExistFiles.Size = new System.Drawing.Size(154, 21);
            this.cbExistFiles.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "İşlem Yapılacak Dosya";
            // 
            // btnShowFile
            // 
            this.btnShowFile.Location = new System.Drawing.Point(171, 376);
            this.btnShowFile.Name = "btnShowFile";
            this.btnShowFile.Size = new System.Drawing.Size(70, 23);
            this.btnShowFile.TabIndex = 10;
            this.btnShowFile.Text = "Görüntüle";
            this.btnShowFile.UseVisualStyleBackColor = true;
            this.btnShowFile.Click += new System.EventHandler(this.btnShowFile_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(140, 113);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnAddAuthor.TabIndex = 11;
            this.btnAddAuthor.Text = "Yazar Ekle";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // cbAuthorList
            // 
            this.cbAuthorList.FormattingEnabled = true;
            this.cbAuthorList.Location = new System.Drawing.Point(13, 115);
            this.cbAuthorList.Name = "cbAuthorList";
            this.cbAuthorList.Size = new System.Drawing.Size(121, 21);
            this.cbAuthorList.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Yazar Listesi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(330, 421);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAuthorList);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.btnShowFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbExistFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSelectFile);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Metin Yazarı Belirleme Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbExistFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowFile;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.ComboBox cbAuthorList;
        private System.Windows.Forms.Label label3;
    }
}

