namespace CurrencyConverterApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.comboFrom = new System.Windows.Forms.ComboBox();
            this.comboTo = new System.Windows.Forms.ComboBox();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.groupRates = new System.Windows.Forms.GroupBox();
            this.labelRates = new System.Windows.Forms.Label();
            this.buttonUpdateRates = new System.Windows.Forms.Button();
            this.groupRates.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(23, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(221, 32);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Конвертер валют";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(25, 64);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(28, 16);
            this.labelFrom.TabIndex = 10;
            this.labelFrom.Text = "Из:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(25, 101);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(19, 16);
            this.labelTo.TabIndex = 9;
            this.labelTo.Text = "В:";
            // 
            // comboFrom
            // 
            this.comboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFrom.FormattingEnabled = true;
            this.comboFrom.Location = new System.Drawing.Point(69, 61);
            this.comboFrom.Name = "comboFrom";
            this.comboFrom.Size = new System.Drawing.Size(239, 24);
            this.comboFrom.TabIndex = 8;
            // 
            // comboTo
            // 
            this.comboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTo.FormattingEnabled = true;
            this.comboTo.Location = new System.Drawing.Point(69, 98);
            this.comboTo.Name = "comboTo";
            this.comboTo.Size = new System.Drawing.Size(239, 24);
            this.comboTo.TabIndex = 7;
            // 
            // buttonSwap
            // 
            this.buttonSwap.Location = new System.Drawing.Point(320, 78);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(46, 32);
            this.buttonSwap.TabIndex = 6;
            this.buttonSwap.Text = "⇄";
            this.buttonSwap.UseVisualStyleBackColor = true;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(25, 144);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(53, 16);
            this.labelAmount.TabIndex = 5;
            this.labelAmount.Text = "Сумма:";
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(103, 141);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(205, 22);
            this.textAmount.TabIndex = 4;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(25, 181);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(80, 16);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Результат:";
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(103, 178);
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(205, 22);
            this.textResult.TabIndex = 2;
            // 
            // groupRates
            // 
            this.groupRates.Controls.Add(this.labelRates);
            this.groupRates.Location = new System.Drawing.Point(29, 219);
            this.groupRates.Name = "groupRates";
            this.groupRates.Size = new System.Drawing.Size(337, 128);
            this.groupRates.TabIndex = 1;
            this.groupRates.TabStop = false;
            this.groupRates.Text = "Курсы валют к RUB";
            // 
            // labelRates
            // 
            this.labelRates.AutoSize = true;
            this.labelRates.Location = new System.Drawing.Point(11, 27);
            this.labelRates.Name = "labelRates";
            this.labelRates.Size = new System.Drawing.Size(131, 64);
            this.labelRates.TabIndex = 0;
            this.labelRates.Text = "1 USD = 77,70 RUB\n1 EUR = 90,34 RUB\n1 CNY = 10,96 RUB\n1 KRW = 0,0670 RUB";
            // 
            // buttonUpdateRates
            // 
            this.buttonUpdateRates.Location = new System.Drawing.Point(211, 357);
            this.buttonUpdateRates.Name = "buttonUpdateRates";
            this.buttonUpdateRates.Size = new System.Drawing.Size(154, 32);
            this.buttonUpdateRates.TabIndex = 0;
            this.buttonUpdateRates.Text = "Обновить курсы";
            this.buttonUpdateRates.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 405);
            this.Controls.Add(this.buttonUpdateRates);
            this.Controls.Add(this.groupRates);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.buttonSwap);
            this.Controls.Add(this.comboTo);
            this.Controls.Add(this.comboFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертер валют";
            this.groupRates.ResumeLayout(false);
            this.groupRates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ComboBox comboFrom;
        private System.Windows.Forms.ComboBox comboTo;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.GroupBox groupRates;
        private System.Windows.Forms.Label labelRates;
        private System.Windows.Forms.Button buttonUpdateRates;
    }
}
