
namespace Metin_Yazarı_Belirleme
{
    partial class FileOperations
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAverageWordCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblSentenceCount = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblWC = new System.Windows.Forms.Label();
            this.lblSC = new System.Windows.Forms.Label();
            this.lblFS = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbSentenceOptions = new System.Windows.Forms.ComboBox();
            this.cbWordOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRunSentence = new System.Windows.Forms.Button();
            this.btnRunWord = new System.Windows.Forms.Button();
            this.lblOperation = new System.Windows.Forms.Label();
            this.btnFindAuthor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAverageWordCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCharCount);
            this.groupBox1.Controls.Add(this.lblWordCount);
            this.groupBox1.Controls.Add(this.lblSentenceCount);
            this.groupBox1.Controls.Add(this.lblFileSize);
            this.groupBox1.Controls.Add(this.lblCC);
            this.groupBox1.Controls.Add(this.lblWC);
            this.groupBox1.Controls.Add(this.lblSC);
            this.groupBox1.Controls.Add(this.lblFS);
            this.groupBox1.Location = new System.Drawing.Point(330, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 167);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dosya Hakkında";
            // 
            // lblAverageWordCount
            // 
            this.lblAverageWordCount.AutoSize = true;
            this.lblAverageWordCount.Location = new System.Drawing.Point(110, 126);
            this.lblAverageWordCount.Name = "lblAverageWordCount";
            this.lblAverageWordCount.Size = new System.Drawing.Size(10, 13);
            this.lblAverageWordCount.TabIndex = 11;
            this.lblAverageWordCount.Text = "-";
            this.lblAverageWordCount.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 126);
            this.label3.MaximumSize = new System.Drawing.Size(100, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ortalama Kelime Sayısı:";
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Location = new System.Drawing.Point(110, 102);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(10, 13);
            this.lblCharCount.TabIndex = 9;
            this.lblCharCount.Text = "-";
            this.lblCharCount.Visible = false;
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Location = new System.Drawing.Point(110, 80);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(10, 13);
            this.lblWordCount.TabIndex = 8;
            this.lblWordCount.Text = "-";
            this.lblWordCount.Visible = false;
            // 
            // lblSentenceCount
            // 
            this.lblSentenceCount.AutoSize = true;
            this.lblSentenceCount.Location = new System.Drawing.Point(110, 58);
            this.lblSentenceCount.Name = "lblSentenceCount";
            this.lblSentenceCount.Size = new System.Drawing.Size(10, 13);
            this.lblSentenceCount.TabIndex = 7;
            this.lblSentenceCount.Text = "-";
            this.lblSentenceCount.Visible = false;
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(110, 32);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(10, 13);
            this.lblFileSize.TabIndex = 6;
            this.lblFileSize.Text = "-";
            this.lblFileSize.Visible = false;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(11, 102);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(80, 13);
            this.lblCC.TabIndex = 3;
            this.lblCC.Text = "Karakter Sayısı:";
            // 
            // lblWC
            // 
            this.lblWC.AutoSize = true;
            this.lblWC.Location = new System.Drawing.Point(11, 80);
            this.lblWC.Name = "lblWC";
            this.lblWC.Size = new System.Drawing.Size(71, 13);
            this.lblWC.TabIndex = 2;
            this.lblWC.Text = "Kelime Sayısı:";
            // 
            // lblSC
            // 
            this.lblSC.AutoSize = true;
            this.lblSC.Location = new System.Drawing.Point(12, 58);
            this.lblSC.Name = "lblSC";
            this.lblSC.Size = new System.Drawing.Size(69, 13);
            this.lblSC.TabIndex = 1;
            this.lblSC.Text = "Cümle Sayısı:";
            // 
            // lblFS
            // 
            this.lblFS.AutoSize = true;
            this.lblFS.Location = new System.Drawing.Point(12, 32);
            this.lblFS.Name = "lblFS";
            this.lblFS.Size = new System.Drawing.Size(76, 13);
            this.lblFS.TabIndex = 0;
            this.lblFS.Text = "Dosya Boyutu:";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader});
            this.listView.HideSelection = false;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView.Location = new System.Drawing.Point(12, 194);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(516, 382);
            this.listView.TabIndex = 10;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "Sonuçlar";
            this.columnHeader.Width = 512;
            // 
            // cbSentenceOptions
            // 
            this.cbSentenceOptions.FormattingEnabled = true;
            this.cbSentenceOptions.Items.AddRange(new object[] {
            "Stack İçerisine Al",
            "Stack Görüntüle",
            "Ağaç İçerisine Al",
            "Ağacı Görüntüle"});
            this.cbSentenceOptions.Location = new System.Drawing.Point(12, 36);
            this.cbSentenceOptions.Name = "cbSentenceOptions";
            this.cbSentenceOptions.Size = new System.Drawing.Size(138, 21);
            this.cbSentenceOptions.TabIndex = 12;
            // 
            // cbWordOptions
            // 
            this.cbWordOptions.FormattingEnabled = true;
            this.cbWordOptions.Items.AddRange(new object[] {
            "Stack İçerisine Al",
            "Stack Görüntüle",
            "Ağaç İçerisine Al",
            "Ağacı Görüntüle",
            "Sık Kullanılan Kelimeler"});
            this.cbWordOptions.Location = new System.Drawing.Point(12, 84);
            this.cbWordOptions.Name = "cbWordOptions";
            this.cbWordOptions.Size = new System.Drawing.Size(138, 21);
            this.cbWordOptions.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cümleler Üzerinde İşlem Yap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kelimeler Üzerinde İşlem Yap";
            // 
            // btnRunSentence
            // 
            this.btnRunSentence.Location = new System.Drawing.Point(158, 36);
            this.btnRunSentence.Name = "btnRunSentence";
            this.btnRunSentence.Size = new System.Drawing.Size(75, 23);
            this.btnRunSentence.TabIndex = 16;
            this.btnRunSentence.Text = "Çalıştır";
            this.btnRunSentence.UseVisualStyleBackColor = true;
            this.btnRunSentence.Click += new System.EventHandler(this.btnRunSentence_Click);
            // 
            // btnRunWord
            // 
            this.btnRunWord.Location = new System.Drawing.Point(158, 82);
            this.btnRunWord.Name = "btnRunWord";
            this.btnRunWord.Size = new System.Drawing.Size(75, 23);
            this.btnRunWord.TabIndex = 17;
            this.btnRunWord.Text = "Çalıştır";
            this.btnRunWord.UseVisualStyleBackColor = true;
            this.btnRunWord.Click += new System.EventHandler(this.btnRunWord_Click);
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(12, 161);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(35, 13);
            this.lblOperation.TabIndex = 18;
            this.lblOperation.Text = "label4";
            this.lblOperation.Visible = false;
            // 
            // btnFindAuthor
            // 
            this.btnFindAuthor.Location = new System.Drawing.Point(158, 115);
            this.btnFindAuthor.Name = "btnFindAuthor";
            this.btnFindAuthor.Size = new System.Drawing.Size(75, 31);
            this.btnFindAuthor.TabIndex = 21;
            this.btnFindAuthor.Text = "Yazar Bul";
            this.btnFindAuthor.UseVisualStyleBackColor = true;
            this.btnFindAuthor.Click += new System.EventHandler(this.btnFindAuthor_Click);
            // 
            // FileOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 588);
            this.Controls.Add(this.btnFindAuthor);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.btnRunWord);
            this.Controls.Add(this.btnRunSentence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbWordOptions);
            this.Controls.Add(this.cbSentenceOptions);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.groupBox1);
            this.Name = "FileOperations";
            this.Text = "FileOperations";
            this.Load += new System.EventHandler(this.FileOperations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblSentenceCount;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblWC;
        private System.Windows.Forms.Label lblSC;
        private System.Windows.Forms.Label lblFS;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.ComboBox cbSentenceOptions;
        private System.Windows.Forms.ComboBox cbWordOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRunSentence;
        private System.Windows.Forms.Button btnRunWord;
        private System.Windows.Forms.Label lblAverageWordCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Button btnFindAuthor;
    }
}