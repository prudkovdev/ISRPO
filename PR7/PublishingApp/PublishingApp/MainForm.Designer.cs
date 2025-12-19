namespace PublishingApp
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
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.groupBoxBook = new System.Windows.Forms.GroupBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxReleaseYear = new System.Windows.Forms.TextBox();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelPublicationYear = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.groupBoxBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(16, 8);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(768, 256);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellClick);
            // 
            // groupBoxBook
            // 
            this.groupBoxBook.Controls.Add(this.textBoxAuthor);
            this.groupBoxBook.Controls.Add(this.textBoxReleaseYear);
            this.groupBoxBook.Controls.Add(this.textBoxBookName);
            this.groupBoxBook.Controls.Add(this.labelAuthor);
            this.groupBoxBook.Controls.Add(this.labelPublicationYear);
            this.groupBoxBook.Controls.Add(this.labelBookName);
            this.groupBoxBook.Location = new System.Drawing.Point(16, 272);
            this.groupBoxBook.Name = "groupBoxBook";
            this.groupBoxBook.Size = new System.Drawing.Size(768, 112);
            this.groupBoxBook.TabIndex = 1;
            this.groupBoxBook.TabStop = false;
            this.groupBoxBook.Text = "Информация о книге";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(496, 32);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.ReadOnly = true;
            this.textBoxAuthor.Size = new System.Drawing.Size(256, 22);
            this.textBoxAuthor.TabIndex = 5;
            // 
            // textBoxReleaseYear
            // 
            this.textBoxReleaseYear.Location = new System.Drawing.Point(152, 64);
            this.textBoxReleaseYear.Name = "textBoxReleaseYear";
            this.textBoxReleaseYear.ReadOnly = true;
            this.textBoxReleaseYear.Size = new System.Drawing.Size(128, 22);
            this.textBoxReleaseYear.TabIndex = 4;
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(152, 32);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.ReadOnly = true;
            this.textBoxBookName.Size = new System.Drawing.Size(256, 22);
            this.textBoxBookName.TabIndex = 3;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(424, 32);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(50, 16);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Автор:";
            // 
            // labelPublicationYear
            // 
            this.labelPublicationYear.AutoSize = true;
            this.labelPublicationYear.Location = new System.Drawing.Point(16, 64);
            this.labelPublicationYear.Name = "labelPublicationYear";
            this.labelPublicationYear.Size = new System.Drawing.Size(91, 16);
            this.labelPublicationYear.TabIndex = 1;
            this.labelPublicationYear.Text = "Год издания:";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(16, 32);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(116, 16);
            this.labelBookName.TabIndex = 0;
            this.labelBookName.Text = "Название книги:";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(16, 400);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(200, 32);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "Сделать предзаказ";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(656, 400);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(128, 32);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(798, 449);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.groupBoxBook);
            this.Controls.Add(this.dataGridViewBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предзаказ книг | Издательство";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.groupBoxBook.ResumeLayout(false);
            this.groupBoxBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.GroupBox groupBoxBook;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelPublicationYear;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxReleaseYear;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonExit;
    }
}

