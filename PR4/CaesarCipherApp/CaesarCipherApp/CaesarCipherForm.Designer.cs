namespace CaesarCipherApp
{
    partial class CaesarCipherForm
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
            this.labelSourceText = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.labelShift = new System.Windows.Forms.Label();
            this.numericUpDownShift = new System.Windows.Forms.NumericUpDown();
            this.textBoxSourceText = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShift)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSourceText
            // 
            this.labelSourceText.AutoSize = true;
            this.labelSourceText.Location = new System.Drawing.Point(24, 24);
            this.labelSourceText.Name = "labelSourceText";
            this.labelSourceText.Size = new System.Drawing.Size(113, 16);
            this.labelSourceText.TabIndex = 0;
            this.labelSourceText.Text = "Исходный текст:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(24, 144);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(80, 16);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Результат:";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(24, 272);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(44, 16);
            this.labelLanguage.TabIndex = 4;
            this.labelLanguage.Text = "Язык:";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "Русский",
            "Английский"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(88, 272);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(176, 24);
            this.comboBoxLanguage.TabIndex = 5;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(840, 272);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(139, 32);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(688, 272);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(139, 32);
            this.buttonDecrypt.TabIndex = 7;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(536, 272);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(139, 32);
            this.buttonEncrypt.TabIndex = 8;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // labelShift
            // 
            this.labelShift.AutoSize = true;
            this.labelShift.Location = new System.Drawing.Point(296, 272);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(49, 16);
            this.labelShift.TabIndex = 9;
            this.labelShift.Text = "Свдиг:";
            // 
            // numericUpDownShift
            // 
            this.numericUpDownShift.Location = new System.Drawing.Point(368, 272);
            this.numericUpDownShift.Name = "numericUpDownShift";
            this.numericUpDownShift.Size = new System.Drawing.Size(144, 22);
            this.numericUpDownShift.TabIndex = 10;
            this.numericUpDownShift.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // textBoxSourceText
            // 
            this.textBoxSourceText.Location = new System.Drawing.Point(168, 24);
            this.textBoxSourceText.Multiline = true;
            this.textBoxSourceText.Name = "textBoxSourceText";
            this.textBoxSourceText.Size = new System.Drawing.Size(808, 96);
            this.textBoxSourceText.TabIndex = 11;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(168, 144);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(808, 96);
            this.textBoxResult.TabIndex = 12;
            // 
            // CaesarCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 335);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxSourceText);
            this.Controls.Add(this.numericUpDownShift);
            this.Controls.Add(this.labelShift);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelSourceText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CaesarCipherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифр Цезаря";
            this.Load += new System.EventHandler(this.CaesarCipherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSourceText;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label labelShift;
        private System.Windows.Forms.NumericUpDown numericUpDownShift;
        private System.Windows.Forms.TextBox textBoxSourceText;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}