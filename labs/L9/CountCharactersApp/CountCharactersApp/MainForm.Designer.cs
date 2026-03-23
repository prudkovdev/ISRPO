namespace CountCharactersApp
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
            this.bOpen = new System.Windows.Forms.Button();
            this.bCount = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.lInfo1 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.lInfo2 = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(16, 16);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(128, 32);
            this.bOpen.TabIndex = 0;
            this.bOpen.Text = "Открыть";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // bCount
            // 
            this.bCount.Location = new System.Drawing.Point(160, 16);
            this.bCount.Name = "bCount";
            this.bCount.Size = new System.Drawing.Size(128, 32);
            this.bCount.TabIndex = 1;
            this.bCount.Text = "Подсчитать";
            this.bCount.UseVisualStyleBackColor = true;
            this.bCount.Click += new System.EventHandler(this.bCount_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(304, 16);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(128, 32);
            this.bSave.TabIndex = 2;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(448, 16);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(128, 32);
            this.bClear.TabIndex = 3;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(592, 16);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(128, 32);
            this.bExit.TabIndex = 4;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // lInfo1
            // 
            this.lInfo1.AutoSize = true;
            this.lInfo1.Location = new System.Drawing.Point(16, 64);
            this.lInfo1.Name = "lInfo1";
            this.lInfo1.Size = new System.Drawing.Size(300, 16);
            this.lInfo1.TabIndex = 5;
            this.lInfo1.Text = "Введите текст или выберите файл с текстом";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(16, 88);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(704, 22);
            this.tbPath.TabIndex = 6;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(16, 128);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbContent.Size = new System.Drawing.Size(704, 232);
            this.tbContent.TabIndex = 7;
            // 
            // lInfo2
            // 
            this.lInfo2.AutoSize = true;
            this.lInfo2.Location = new System.Drawing.Point(16, 376);
            this.lInfo2.Name = "lInfo2";
            this.lInfo2.Size = new System.Drawing.Size(210, 16);
            this.lInfo2.TabIndex = 8;
            this.lInfo2.Text = "Количество символов в тексте";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(16, 400);
            this.tbCount.Name = "tbCount";
            this.tbCount.ReadOnly = true;
            this.tbCount.Size = new System.Drawing.Size(352, 22);
            this.tbCount.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.lInfo2);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lInfo1);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bCount);
            this.Controls.Add(this.bOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подсчёт символов в тексте";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Button bCount;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label lInfo1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label lInfo2;
        private System.Windows.Forms.TextBox tbCount;
    }
}

