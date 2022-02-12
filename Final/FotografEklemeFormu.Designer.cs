
namespace Final
{
    partial class FotografEklemeFormu
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
            this.fotografEkleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fotografAdiTextBox = new System.Windows.Forms.TextBox();
            this.fotografKonumuTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fotografSecButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.fotografTarihiTextBox = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fotografEkleButton
            // 
            this.fotografEkleButton.Location = new System.Drawing.Point(296, 527);
            this.fotografEkleButton.Name = "fotografEkleButton";
            this.fotografEkleButton.Size = new System.Drawing.Size(92, 49);
            this.fotografEkleButton.TabIndex = 0;
            this.fotografEkleButton.Text = "Fotograf Ekle";
            this.fotografEkleButton.UseVisualStyleBackColor = true;
            this.fotografEkleButton.Click += new System.EventHandler(this.fotografEkleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fotograf Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fotograf Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fotograf Konumu:";
            // 
            // fotografAdiTextBox
            // 
            this.fotografAdiTextBox.Location = new System.Drawing.Point(273, 47);
            this.fotografAdiTextBox.Name = "fotografAdiTextBox";
            this.fotografAdiTextBox.Size = new System.Drawing.Size(177, 20);
            this.fotografAdiTextBox.TabIndex = 4;
            // 
            // fotografKonumuTextBox
            // 
            this.fotografKonumuTextBox.Location = new System.Drawing.Point(273, 91);
            this.fotografKonumuTextBox.Name = "fotografKonumuTextBox";
            this.fotografKonumuTextBox.Size = new System.Drawing.Size(177, 20);
            this.fotografKonumuTextBox.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(273, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kayıt Edilecek Albüm:";
            // 
            // fotografSecButton
            // 
            this.fotografSecButton.Location = new System.Drawing.Point(495, 62);
            this.fotografSecButton.Name = "fotografSecButton";
            this.fotografSecButton.Size = new System.Drawing.Size(77, 38);
            this.fotografSecButton.TabIndex = 9;
            this.fotografSecButton.Text = "Fotograf Sec";
            this.fotografSecButton.UseVisualStyleBackColor = true;
            this.fotografSecButton.Click += new System.EventHandler(this.fotografSecButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(156, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 339);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(579, 545);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(96, 44);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "Islem Ekranı";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // fotografTarihiTextBox
            // 
            this.fotografTarihiTextBox.Location = new System.Drawing.Point(273, 131);
            this.fotografTarihiTextBox.Name = "fotografTarihiTextBox";
            this.fotografTarihiTextBox.Size = new System.Drawing.Size(174, 20);
            this.fotografTarihiTextBox.TabIndex = 12;
            // 
            // FotografEklemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 614);
            this.Controls.Add(this.fotografTarihiTextBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fotografSecButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fotografKonumuTextBox);
            this.Controls.Add(this.fotografAdiTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fotografEkleButton);
            this.Name = "FotografEklemeFormu";
            this.Text = "FOTOGRAF EKLEME EKRANI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FotografEklemeFormu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fotografEkleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fotografAdiTextBox;
        private System.Windows.Forms.TextBox fotografKonumuTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button fotografSecButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.DateTimePicker fotografTarihiTextBox;
    }
}