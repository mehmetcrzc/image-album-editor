
namespace Final
{
    partial class FotografDuzenlemeFormu
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
            this.backButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.blurButton = new System.Windows.Forms.Button();
            this.brightButton = new System.Windows.Forms.Button();
            this.doygunlukButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rotateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Location = new System.Drawing.Point(12, 560);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(122, 42);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Seçim Ekranına Dön";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(557, 36);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(90, 40);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Fotografi Sil";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // blurButton
            // 
            this.blurButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.blurButton.Location = new System.Drawing.Point(557, 371);
            this.blurButton.Name = "blurButton";
            this.blurButton.Size = new System.Drawing.Size(90, 40);
            this.blurButton.TabIndex = 3;
            this.blurButton.Text = "Blur";
            this.blurButton.UseVisualStyleBackColor = true;
            this.blurButton.Click += new System.EventHandler(this.blurButton_Click);
            // 
            // brightButton
            // 
            this.brightButton.Location = new System.Drawing.Point(557, 199);
            this.brightButton.Name = "brightButton";
            this.brightButton.Size = new System.Drawing.Size(90, 40);
            this.brightButton.TabIndex = 4;
            this.brightButton.Text = "Brightness";
            this.brightButton.UseVisualStyleBackColor = true;
            this.brightButton.Click += new System.EventHandler(this.brightButton_Click);
            // 
            // doygunlukButton
            // 
            this.doygunlukButton.Location = new System.Drawing.Point(557, 289);
            this.doygunlukButton.Name = "doygunlukButton";
            this.doygunlukButton.Size = new System.Drawing.Size(90, 40);
            this.doygunlukButton.TabIndex = 5;
            this.doygunlukButton.Text = "Doygunluk";
            this.doygunlukButton.UseVisualStyleBackColor = true;
            this.doygunlukButton.Click += new System.EventHandler(this.doygunlukButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(106, 451);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(112, 49);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Degişiklikleri Sifirla";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = true;
            this.saveButton.Location = new System.Drawing.Point(350, 451);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 49);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Degisiklikleri Kaydet";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(106, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 326);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // rotateButton
            // 
            this.rotateButton.Location = new System.Drawing.Point(557, 116);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(90, 40);
            this.rotateButton.TabIndex = 11;
            this.rotateButton.Text = "Rotate";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // FotografDuzenlemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 614);
            this.Controls.Add(this.rotateButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.doygunlukButton);
            this.Controls.Add(this.brightButton);
            this.Controls.Add(this.blurButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.backButton);
            this.Name = "FotografDuzenlemeFormu";
            this.Text = "FOTOGRAF DUZENLEME EKRANI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FotografDuzenlemeFormu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button blurButton;
        private System.Windows.Forms.Button brightButton;
        private System.Windows.Forms.Button doygunlukButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button rotateButton;
    }
}