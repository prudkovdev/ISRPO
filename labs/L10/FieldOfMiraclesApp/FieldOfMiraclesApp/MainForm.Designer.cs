namespace FieldOfMiraclesApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bNewGame = new System.Windows.Forms.Button();
            this.bCheck = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.pWords = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bNewGame
            // 
            this.bNewGame.Location = new System.Drawing.Point(24, 24);
            this.bNewGame.Name = "bNewGame";
            this.bNewGame.Size = new System.Drawing.Size(160, 32);
            this.bNewGame.TabIndex = 0;
            this.bNewGame.Text = "Новая игра";
            this.bNewGame.UseVisualStyleBackColor = true;
            this.bNewGame.Click += new System.EventHandler(this.bNewGame_Click);
            // 
            // bCheck
            // 
            this.bCheck.Location = new System.Drawing.Point(208, 24);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(160, 32);
            this.bCheck.TabIndex = 1;
            this.bCheck.Text = "Проверить";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(392, 24);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(160, 32);
            this.bBack.TabIndex = 2;
            this.bBack.Text = "Отмена";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Собираемое:";
            // 
            // tbWord
            // 
            this.tbWord.Location = new System.Drawing.Point(136, 80);
            this.tbWord.Name = "tbWord";
            this.tbWord.ReadOnly = true;
            this.tbWord.Size = new System.Drawing.Size(160, 22);
            this.tbWord.TabIndex = 4;
            this.tbWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pWords
            // 
            this.pWords.Location = new System.Drawing.Point(24, 120);
            this.pWords.Name = "pWords";
            this.pWords.Size = new System.Drawing.Size(752, 304);
            this.pWords.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pWords);
            this.Controls.Add(this.tbWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.bNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поле Чудес";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bNewGame;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.Panel pWords;
    }
}

