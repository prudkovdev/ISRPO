namespace PublishingApp
{
    partial class OrderForm
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
            this.groupBoxBook = new System.Windows.Forms.GroupBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.textBoxCustomerPhone = new System.Windows.Forms.TextBox();
            this.textBoxCustomerAddress = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomerPhone = new System.Windows.Forms.Label();
            this.labelCustomerAddress = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.groupBoxOffice = new System.Windows.Forms.GroupBox();
            this.comboBoxOffice = new System.Windows.Forms.ComboBox();
            this.labelOffice = new System.Windows.Forms.Label();
            this.groupBoxOrderDetails = new System.Windows.Forms.GroupBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxBook.SuspendLayout();
            this.groupBoxCustomer.SuspendLayout();
            this.groupBoxOffice.SuspendLayout();
            this.groupBoxOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBook
            // 
            this.groupBoxBook.Controls.Add(this.labelAuthor);
            this.groupBoxBook.Controls.Add(this.labelBookName);
            this.groupBoxBook.Location = new System.Drawing.Point(16, 16);
            this.groupBoxBook.Name = "groupBoxBook";
            this.groupBoxBook.Size = new System.Drawing.Size(616, 104);
            this.groupBoxBook.TabIndex = 0;
            this.groupBoxBook.TabStop = false;
            this.groupBoxBook.Text = "Выбранная книга";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(16, 64);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(53, 16);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Автор: ";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(16, 32);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(79, 16);
            this.labelBookName.TabIndex = 0;
            this.labelBookName.Text = "Название: ";
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerPhone);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerAddress);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerName);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerPhone);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerAddress);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerName);
            this.groupBoxCustomer.Location = new System.Drawing.Point(16, 128);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(616, 136);
            this.groupBoxCustomer.TabIndex = 1;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Данные клиента";
            // 
            // textBoxCustomerPhone
            // 
            this.textBoxCustomerPhone.Location = new System.Drawing.Point(128, 96);
            this.textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            this.textBoxCustomerPhone.Size = new System.Drawing.Size(256, 22);
            this.textBoxCustomerPhone.TabIndex = 7;
            // 
            // textBoxCustomerAddress
            // 
            this.textBoxCustomerAddress.Location = new System.Drawing.Point(128, 64);
            this.textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            this.textBoxCustomerAddress.Size = new System.Drawing.Size(400, 22);
            this.textBoxCustomerAddress.TabIndex = 6;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(128, 32);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(400, 22);
            this.textBoxCustomerName.TabIndex = 5;
            // 
            // labelCustomerPhone
            // 
            this.labelCustomerPhone.AutoSize = true;
            this.labelCustomerPhone.Location = new System.Drawing.Point(16, 96);
            this.labelCustomerPhone.Name = "labelCustomerPhone";
            this.labelCustomerPhone.Size = new System.Drawing.Size(70, 16);
            this.labelCustomerPhone.TabIndex = 4;
            this.labelCustomerPhone.Text = "Телефон:";
            // 
            // labelCustomerAddress
            // 
            this.labelCustomerAddress.AutoSize = true;
            this.labelCustomerAddress.Location = new System.Drawing.Point(16, 64);
            this.labelCustomerAddress.Name = "labelCustomerAddress";
            this.labelCustomerAddress.Size = new System.Drawing.Size(50, 16);
            this.labelCustomerAddress.TabIndex = 3;
            this.labelCustomerAddress.Text = "Адрес:";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(16, 32);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(41, 16);
            this.labelCustomerName.TabIndex = 2;
            this.labelCustomerName.Text = "ФИО:";
            // 
            // groupBoxOffice
            // 
            this.groupBoxOffice.Controls.Add(this.comboBoxOffice);
            this.groupBoxOffice.Controls.Add(this.labelOffice);
            this.groupBoxOffice.Location = new System.Drawing.Point(16, 272);
            this.groupBoxOffice.Name = "groupBoxOffice";
            this.groupBoxOffice.Size = new System.Drawing.Size(616, 72);
            this.groupBoxOffice.TabIndex = 8;
            this.groupBoxOffice.TabStop = false;
            this.groupBoxOffice.Text = "Выбор офиса получения";
            // 
            // comboBoxOffice
            // 
            this.comboBoxOffice.FormattingEnabled = true;
            this.comboBoxOffice.Location = new System.Drawing.Point(128, 32);
            this.comboBoxOffice.Name = "comboBoxOffice";
            this.comboBoxOffice.Size = new System.Drawing.Size(400, 24);
            this.comboBoxOffice.TabIndex = 3;
            // 
            // labelOffice
            // 
            this.labelOffice.AutoSize = true;
            this.labelOffice.Location = new System.Drawing.Point(16, 32);
            this.labelOffice.Name = "labelOffice";
            this.labelOffice.Size = new System.Drawing.Size(46, 16);
            this.labelOffice.TabIndex = 2;
            this.labelOffice.Text = "Офис:";
            // 
            // groupBoxOrderDetails
            // 
            this.groupBoxOrderDetails.Controls.Add(this.labelTotal);
            this.groupBoxOrderDetails.Controls.Add(this.numericUpDownQuantity);
            this.groupBoxOrderDetails.Controls.Add(this.labelQuantity);
            this.groupBoxOrderDetails.Location = new System.Drawing.Point(16, 352);
            this.groupBoxOrderDetails.Name = "groupBoxOrderDetails";
            this.groupBoxOrderDetails.Size = new System.Drawing.Size(616, 72);
            this.groupBoxOrderDetails.TabIndex = 9;
            this.groupBoxOrderDetails.TabStop = false;
            this.groupBoxOrderDetails.Text = "Детали заказа";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(280, 32);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotal.Size = new System.Drawing.Size(89, 16);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "Итого: 0 руб.";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(128, 32);
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownQuantity.TabIndex = 10;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDownQuantity_ValueChanged);
            this.numericUpDownQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownQuantity_KeyUp);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(16, 32);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(88, 16);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "Количество:";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(432, 440);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(200, 32);
            this.buttonConfirm.TabIndex = 10;
            this.buttonConfirm.Text = "Подтвердить заказ";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(288, 440);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(128, 32);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 489);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.groupBoxOrderDetails);
            this.Controls.Add(this.groupBoxOffice);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.groupBoxBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление предзаказа";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.groupBoxBook.ResumeLayout(false);
            this.groupBoxBook.PerformLayout();
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.groupBoxOffice.ResumeLayout(false);
            this.groupBoxOffice.PerformLayout();
            this.groupBoxOrderDetails.ResumeLayout(false);
            this.groupBoxOrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBook;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelCustomerPhone;
        private System.Windows.Forms.Label labelCustomerAddress;
        private System.Windows.Forms.TextBox textBoxCustomerPhone;
        private System.Windows.Forms.TextBox textBoxCustomerAddress;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.GroupBox groupBoxOffice;
        private System.Windows.Forms.ComboBox comboBoxOffice;
        private System.Windows.Forms.Label labelOffice;
        private System.Windows.Forms.GroupBox groupBoxOrderDetails;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
    }
}