
namespace Final
{
    partial class AlbumEklemeFormu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dizinSecButton = new System.Windows.Forms.Button();
            this.albumAdiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.albumKonumuTextBox = new System.Windows.Forms.TextBox();
            this.albumEkleButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.albumTarihiTextBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dizinSecButton
            // 
            this.dizinSecButton.BackColor = System.Drawing.Color.Silver;
            this.dizinSecButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dizinSecButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dizinSecButton.Location = new System.Drawing.Point(111, 101);
            this.dizinSecButton.Name = "dizinSecButton";
            this.dizinSecButton.Size = new System.Drawing.Size(426, 61);
            this.dizinSecButton.TabIndex = 1;
            this.dizinSecButton.Text = "Albümleri kayıt etmek istediğiniz ana dizini seçmek için tıklayınız...";
            this.dizinSecButton.UseVisualStyleBackColor = false;
            this.dizinSecButton.Click += new System.EventHandler(this.dizinSecButton_Click);
            // 
            // albumAdiTextBox
            // 
            this.albumAdiTextBox.Enabled = false;
            this.albumAdiTextBox.Location = new System.Drawing.Point(245, 199);
            this.albumAdiTextBox.Name = "albumAdiTextBox";
            this.albumAdiTextBox.Size = new System.Drawing.Size(193, 20);
            this.albumAdiTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Albüm adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Albüm tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Albüm konumu:";
            // 
            // albumKonumuTextBox
            // 
            this.albumKonumuTextBox.Enabled = false;
            this.albumKonumuTextBox.Location = new System.Drawing.Point(245, 243);
            this.albumKonumuTextBox.Name = "albumKonumuTextBox";
            this.albumKonumuTextBox.Size = new System.Drawing.Size(193, 20);
            this.albumKonumuTextBox.TabIndex = 7;
            // 
            // albumEkleButton
            // 
            this.albumEkleButton.Location = new System.Drawing.Point(288, 336);
            this.albumEkleButton.Name = "albumEkleButton";
            this.albumEkleButton.Size = new System.Drawing.Size(91, 35);
            this.albumEkleButton.TabIndex = 8;
            this.albumEkleButton.Text = "Albüm Ekle";
            this.albumEkleButton.UseVisualStyleBackColor = true;
            this.albumEkleButton.Click += new System.EventHandler(this.albumEkleButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(512, 520);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(129, 52);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Fotoğraf Ekleme Ekranı";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // albumTarihiTextBox
            // 
            this.albumTarihiTextBox.Location = new System.Drawing.Point(245, 283);
            this.albumTarihiTextBox.Name = "albumTarihiTextBox";
            this.albumTarihiTextBox.Size = new System.Drawing.Size(193, 20);
            this.albumTarihiTextBox.TabIndex = 10;
            // 
            // AlbumEklemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 614);
            this.Controls.Add(this.albumTarihiTextBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.albumEkleButton);
            this.Controls.Add(this.albumKonumuTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumAdiTextBox);
            this.Controls.Add(this.dizinSecButton);
            this.Name = "AlbumEklemeFormu";
            this.Text = "ALBUM OLUŞTURMA EKRANI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dizinSecButton;
        private System.Windows.Forms.TextBox albumAdiTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox albumKonumuTextBox;
        private System.Windows.Forms.Button albumEkleButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.DateTimePicker albumTarihiTextBox;
    }
}

