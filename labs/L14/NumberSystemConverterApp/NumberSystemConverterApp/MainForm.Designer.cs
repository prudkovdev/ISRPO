namespace NumberSystemConverterApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputBaseComboBox = new System.Windows.Forms.ComboBox();
            this.outputBaseComboBox = new System.Windows.Forms.ComboBox();
            this.inputNumberTextBox = new System.Windows.Forms.TextBox();
            this.outputNumberTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.inputNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputBaseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputBaseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conversionDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "( ! )    Поддерживаемые системы счисления: двоичная (2), восьмеричная (8), десяти" +
    "чная (10), шестнадцатеричная (16)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Из системы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "В систему:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Число:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Результат:";
            // 
            // inputBaseComboBox
            // 
            this.inputBaseComboBox.FormattingEnabled = true;
            this.inputBaseComboBox.Location = new System.Drawing.Point(144, 64);
            this.inputBaseComboBox.Name = "inputBaseComboBox";
            this.inputBaseComboBox.Size = new System.Drawing.Size(336, 24);
            this.inputBaseComboBox.TabIndex = 5;
            this.inputBaseComboBox.SelectedIndexChanged += new System.EventHandler(this.inputBaseComboBox_SelectedIndexChanged);
            // 
            // outputBaseComboBox
            // 
            this.outputBaseComboBox.FormattingEnabled = true;
            this.outputBaseComboBox.Location = new System.Drawing.Point(144, 96);
            this.outputBaseComboBox.Name = "outputBaseComboBox";
            this.outputBaseComboBox.Size = new System.Drawing.Size(336, 24);
            this.outputBaseComboBox.TabIndex = 6;
            this.outputBaseComboBox.SelectedIndexChanged += new System.EventHandler(this.outputBaseComboBox_SelectedIndexChanged);
            // 
            // inputNumberTextBox
            // 
            this.inputNumberTextBox.Location = new System.Drawing.Point(144, 128);
            this.inputNumberTextBox.Name = "inputNumberTextBox";
            this.inputNumberTextBox.Size = new System.Drawing.Size(336, 22);
            this.inputNumberTextBox.TabIndex = 7;
            // 
            // outputNumberTextBox
            // 
            this.outputNumberTextBox.Location = new System.Drawing.Point(144, 160);
            this.outputNumberTextBox.Name = "outputNumberTextBox";
            this.outputNumberTextBox.ReadOnly = true;
            this.outputNumberTextBox.Size = new System.Drawing.Size(336, 22);
            this.outputNumberTextBox.TabIndex = 8;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(144, 200);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(160, 24);
            this.convertButton.TabIndex = 9;
            this.convertButton.Text = "Конвертировать";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(320, 200);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(160, 24);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(24, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "История конвертаций";
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.AllowUserToAddRows = false;
            this.historyDataGridView.AllowUserToDeleteRows = false;
            this.historyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inputNumberColumn,
            this.inputBaseColumn,
            this.outputNumberColumn,
            this.outputBaseColumn,
            this.conversionDateColumn});
            this.historyDataGridView.Location = new System.Drawing.Point(24, 264);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.ReadOnly = true;
            this.historyDataGridView.RowHeadersVisible = false;
            this.historyDataGridView.RowHeadersWidth = 51;
            this.historyDataGridView.RowTemplate.Height = 24;
            this.historyDataGridView.Size = new System.Drawing.Size(752, 168);
            this.historyDataGridView.TabIndex = 12;
            // 
            // inputNumberColumn
            // 
            this.inputNumberColumn.HeaderText = "Исходное число";
            this.inputNumberColumn.MinimumWidth = 6;
            this.inputNumberColumn.Name = "inputNumberColumn";
            this.inputNumberColumn.ReadOnly = true;
            // 
            // inputBaseColumn
            // 
            this.inputBaseColumn.HeaderText = "Из системы";
            this.inputBaseColumn.MinimumWidth = 6;
            this.inputBaseColumn.Name = "inputBaseColumn";
            this.inputBaseColumn.ReadOnly = true;
            // 
            // outputNumberColumn
            // 
            this.outputNumberColumn.HeaderText = "Результат";
            this.outputNumberColumn.MinimumWidth = 6;
            this.outputNumberColumn.Name = "outputNumberColumn";
            this.outputNumberColumn.ReadOnly = true;
            // 
            // outputBaseColumn
            // 
            this.outputBaseColumn.HeaderText = "В систему";
            this.outputBaseColumn.MinimumWidth = 6;
            this.outputBaseColumn.Name = "outputBaseColumn";
            this.outputBaseColumn.ReadOnly = true;
            // 
            // conversionDateColumn
            // 
            this.conversionDateColumn.HeaderText = "Дата конвертации";
            this.conversionDateColumn.MinimumWidth = 6;
            this.conversionDateColumn.Name = "conversionDateColumn";
            this.conversionDateColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historyDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputNumberTextBox);
            this.Controls.Add(this.inputNumberTextBox);
            this.Controls.Add(this.outputBaseComboBox);
            this.Controls.Add(this.inputBaseComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертер систем счисления";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox inputBaseComboBox;
        private System.Windows.Forms.ComboBox outputBaseComboBox;
        private System.Windows.Forms.TextBox inputNumberTextBox;
        private System.Windows.Forms.TextBox outputNumberTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputBaseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputBaseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conversionDateColumn;
    }
}

