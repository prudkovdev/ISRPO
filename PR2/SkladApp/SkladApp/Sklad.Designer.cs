namespace SkladApp
{
    partial class Sklad
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
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.buttonAddToTable = new System.Windows.Forms.Button();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonAddNewName = new System.Windows.Forms.Button();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCellNum = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStellazhNum = new System.Windows.Forms.NumericUpDown();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelCellNum = new System.Windows.Forms.Label();
            this.labelStellazhNum = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelNewName = new System.Windows.Forms.Label();
            this.groupBoxSearchByName = new System.Windows.Forms.GroupBox();
            this.buttonSearchByName = new System.Windows.Forms.Button();
            this.labelProductNameForSearch = new System.Windows.Forms.Label();
            this.textBoxNameForSearch = new System.Windows.Forms.TextBox();
            this.groupBoxSearchByCoords = new System.Windows.Forms.GroupBox();
            this.buttonSearchByCoords = new System.Windows.Forms.Button();
            this.labelCell = new System.Windows.Forms.Label();
            this.numericUpDownCell = new System.Windows.Forms.NumericUpDown();
            this.labelStellazh = new System.Windows.Forms.Label();
            this.numericUpDownStellazh = new System.Windows.Forms.NumericUpDown();
            this.groupBoxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCellNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStellazhNum)).BeginInit();
            this.groupBoxSearchByName.SuspendLayout();
            this.groupBoxSearchByCoords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStellazh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.dataGridViewProducts);
            this.groupBoxProducts.Location = new System.Drawing.Point(8, 16);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Size = new System.Drawing.Size(808, 576);
            this.groupBoxProducts.TabIndex = 0;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Text = "Продукты";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(16, 32);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(780, 520);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.buttonSaveAs);
            this.groupBoxAdd.Controls.Add(this.buttonAddToTable);
            this.groupBoxAdd.Controls.Add(this.buttonDeleteSelected);
            this.groupBoxAdd.Controls.Add(this.buttonOpen);
            this.groupBoxAdd.Controls.Add(this.buttonAddNewName);
            this.groupBoxAdd.Controls.Add(this.numericUpDownQuantity);
            this.groupBoxAdd.Controls.Add(this.numericUpDownCellNum);
            this.groupBoxAdd.Controls.Add(this.numericUpDownStellazhNum);
            this.groupBoxAdd.Controls.Add(this.comboBoxProductName);
            this.groupBoxAdd.Controls.Add(this.textBoxNewName);
            this.groupBoxAdd.Controls.Add(this.labelQuantity);
            this.groupBoxAdd.Controls.Add(this.labelCellNum);
            this.groupBoxAdd.Controls.Add(this.labelStellazhNum);
            this.groupBoxAdd.Controls.Add(this.labelProductName);
            this.groupBoxAdd.Controls.Add(this.labelNewName);
            this.groupBoxAdd.Location = new System.Drawing.Point(824, 16);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(552, 280);
            this.groupBoxAdd.TabIndex = 1;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавить";
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Location = new System.Drawing.Point(368, 216);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(144, 32);
            this.buttonSaveAs.TabIndex = 14;
            this.buttonSaveAs.Text = "Сохранить как";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // buttonAddToTable
            // 
            this.buttonAddToTable.Location = new System.Drawing.Point(192, 216);
            this.buttonAddToTable.Name = "buttonAddToTable";
            this.buttonAddToTable.Size = new System.Drawing.Size(144, 32);
            this.buttonAddToTable.TabIndex = 13;
            this.buttonAddToTable.Text = "Добавить";
            this.buttonAddToTable.UseVisualStyleBackColor = true;
            this.buttonAddToTable.Click += new System.EventHandler(this.buttonAddToTable_Click);
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Location = new System.Drawing.Point(16, 208);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(144, 48);
            this.buttonDeleteSelected.TabIndex = 12;
            this.buttonDeleteSelected.Text = "Удалить выбранное";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            this.buttonDeleteSelected.Click += new System.EventHandler(this.buttonDeleteSelected_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(368, 168);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(144, 32);
            this.buttonOpen.TabIndex = 11;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonAddNewName
            // 
            this.buttonAddNewName.Location = new System.Drawing.Point(368, 40);
            this.buttonAddNewName.Name = "buttonAddNewName";
            this.buttonAddNewName.Size = new System.Drawing.Size(144, 32);
            this.buttonAddNewName.TabIndex = 10;
            this.buttonAddNewName.Text = "Добавить";
            this.buttonAddNewName.UseVisualStyleBackColor = true;
            this.buttonAddNewName.Click += new System.EventHandler(this.buttonAddNewName_Click);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(192, 176);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(144, 22);
            this.numericUpDownQuantity.TabIndex = 9;
            // 
            // numericUpDownCellNum
            // 
            this.numericUpDownCellNum.Location = new System.Drawing.Point(192, 144);
            this.numericUpDownCellNum.Name = "numericUpDownCellNum";
            this.numericUpDownCellNum.Size = new System.Drawing.Size(144, 22);
            this.numericUpDownCellNum.TabIndex = 8;
            // 
            // numericUpDownStellazhNum
            // 
            this.numericUpDownStellazhNum.Location = new System.Drawing.Point(192, 112);
            this.numericUpDownStellazhNum.Name = "numericUpDownStellazhNum";
            this.numericUpDownStellazhNum.Size = new System.Drawing.Size(144, 22);
            this.numericUpDownStellazhNum.TabIndex = 7;
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(192, 80);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(144, 24);
            this.comboBoxProductName.TabIndex = 6;
            this.comboBoxProductName.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductName_SelectedIndexChanged);
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(192, 40);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(144, 22);
            this.textBoxNewName.TabIndex = 5;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(16, 176);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(88, 16);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Количество:";
            // 
            // labelCellNum
            // 
            this.labelCellNum.AutoSize = true;
            this.labelCellNum.Location = new System.Drawing.Point(16, 144);
            this.labelCellNum.Name = "labelCellNum";
            this.labelCellNum.Size = new System.Drawing.Size(102, 16);
            this.labelCellNum.TabIndex = 3;
            this.labelCellNum.Text = "Номер ячейки:";
            // 
            // labelStellazhNum
            // 
            this.labelStellazhNum.AutoSize = true;
            this.labelStellazhNum.Location = new System.Drawing.Point(16, 112);
            this.labelStellazhNum.Name = "labelStellazhNum";
            this.labelStellazhNum.Size = new System.Drawing.Size(119, 16);
            this.labelStellazhNum.TabIndex = 2;
            this.labelStellazhNum.Text = "Номер стеллажа:";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(16, 80);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(159, 16);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Наименование товара:";
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Location = new System.Drawing.Point(16, 40);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(152, 16);
            this.labelNewName.TabIndex = 0;
            this.labelNewName.Text = "Новое наименование:";
            // 
            // groupBoxSearchByName
            // 
            this.groupBoxSearchByName.Controls.Add(this.buttonSearchByName);
            this.groupBoxSearchByName.Controls.Add(this.labelProductNameForSearch);
            this.groupBoxSearchByName.Controls.Add(this.textBoxNameForSearch);
            this.groupBoxSearchByName.Location = new System.Drawing.Point(824, 304);
            this.groupBoxSearchByName.Name = "groupBoxSearchByName";
            this.groupBoxSearchByName.Size = new System.Drawing.Size(552, 96);
            this.groupBoxSearchByName.TabIndex = 2;
            this.groupBoxSearchByName.TabStop = false;
            this.groupBoxSearchByName.Text = "Поиск по названию";
            // 
            // buttonSearchByName
            // 
            this.buttonSearchByName.Location = new System.Drawing.Point(368, 40);
            this.buttonSearchByName.Name = "buttonSearchByName";
            this.buttonSearchByName.Size = new System.Drawing.Size(144, 32);
            this.buttonSearchByName.TabIndex = 15;
            this.buttonSearchByName.Text = "Поиск";
            this.buttonSearchByName.UseVisualStyleBackColor = true;
            this.buttonSearchByName.Click += new System.EventHandler(this.buttonSearchByName_Click);
            // 
            // labelProductNameForSearch
            // 
            this.labelProductNameForSearch.AutoSize = true;
            this.labelProductNameForSearch.Location = new System.Drawing.Point(16, 40);
            this.labelProductNameForSearch.Name = "labelProductNameForSearch";
            this.labelProductNameForSearch.Size = new System.Drawing.Size(161, 16);
            this.labelProductNameForSearch.TabIndex = 0;
            this.labelProductNameForSearch.Text = "Имя товара для поиска:";
            // 
            // textBoxNameForSearch
            // 
            this.textBoxNameForSearch.Location = new System.Drawing.Point(192, 40);
            this.textBoxNameForSearch.Name = "textBoxNameForSearch";
            this.textBoxNameForSearch.Size = new System.Drawing.Size(144, 22);
            this.textBoxNameForSearch.TabIndex = 1;
            // 
            // groupBoxSearchByCoords
            // 
            this.groupBoxSearchByCoords.Controls.Add(this.buttonSearchByCoords);
            this.groupBoxSearchByCoords.Controls.Add(this.labelCell);
            this.groupBoxSearchByCoords.Controls.Add(this.numericUpDownCell);
            this.groupBoxSearchByCoords.Controls.Add(this.labelStellazh);
            this.groupBoxSearchByCoords.Controls.Add(this.numericUpDownStellazh);
            this.groupBoxSearchByCoords.Location = new System.Drawing.Point(824, 408);
            this.groupBoxSearchByCoords.Name = "groupBoxSearchByCoords";
            this.groupBoxSearchByCoords.Size = new System.Drawing.Size(552, 184);
            this.groupBoxSearchByCoords.TabIndex = 3;
            this.groupBoxSearchByCoords.TabStop = false;
            this.groupBoxSearchByCoords.Text = "Поиск по координатам";
            // 
            // buttonSearchByCoords
            // 
            this.buttonSearchByCoords.Location = new System.Drawing.Point(368, 64);
            this.buttonSearchByCoords.Name = "buttonSearchByCoords";
            this.buttonSearchByCoords.Size = new System.Drawing.Size(144, 32);
            this.buttonSearchByCoords.TabIndex = 21;
            this.buttonSearchByCoords.Text = "Поиск";
            this.buttonSearchByCoords.UseVisualStyleBackColor = true;
            this.buttonSearchByCoords.Click += new System.EventHandler(this.buttonSearchByCoords_Click);
            // 
            // labelCell
            // 
            this.labelCell.AutoSize = true;
            this.labelCell.Location = new System.Drawing.Point(192, 40);
            this.labelCell.Name = "labelCell";
            this.labelCell.Size = new System.Drawing.Size(56, 16);
            this.labelCell.TabIndex = 20;
            this.labelCell.Text = "Ячейка";
            // 
            // numericUpDownCell
            // 
            this.numericUpDownCell.Location = new System.Drawing.Point(192, 64);
            this.numericUpDownCell.Name = "numericUpDownCell";
            this.numericUpDownCell.Size = new System.Drawing.Size(144, 22);
            this.numericUpDownCell.TabIndex = 19;
            // 
            // labelStellazh
            // 
            this.labelStellazh.AutoSize = true;
            this.labelStellazh.Location = new System.Drawing.Point(16, 40);
            this.labelStellazh.Name = "labelStellazh";
            this.labelStellazh.Size = new System.Drawing.Size(64, 16);
            this.labelStellazh.TabIndex = 18;
            this.labelStellazh.Text = "Стеллаж";
            // 
            // numericUpDownStellazh
            // 
            this.numericUpDownStellazh.Location = new System.Drawing.Point(16, 64);
            this.numericUpDownStellazh.Name = "numericUpDownStellazh";
            this.numericUpDownStellazh.Size = new System.Drawing.Size(144, 22);
            this.numericUpDownStellazh.TabIndex = 17;
            // 
            // Sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 617);
            this.Controls.Add(this.groupBoxSearchByCoords);
            this.Controls.Add(this.groupBoxSearchByName);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.groupBoxProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Sklad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт продукции";
            this.Load += new System.EventHandler(this.Sklad_Load);
            this.groupBoxProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCellNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStellazhNum)).EndInit();
            this.groupBoxSearchByName.ResumeLayout(false);
            this.groupBoxSearchByName.PerformLayout();
            this.groupBoxSearchByCoords.ResumeLayout(false);
            this.groupBoxSearchByCoords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStellazh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Label labelStellazhNum;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.Label labelCellNum;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonAddNewName;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownCellNum;
        private System.Windows.Forms.NumericUpDown numericUpDownStellazhNum;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.Button buttonAddToTable;
        private System.Windows.Forms.GroupBox groupBoxSearchByName;
        private System.Windows.Forms.Button buttonSearchByName;
        private System.Windows.Forms.TextBox textBoxNameForSearch;
        private System.Windows.Forms.Label labelProductNameForSearch;
        private System.Windows.Forms.GroupBox groupBoxSearchByCoords;
        private System.Windows.Forms.Button buttonSearchByCoords;
        private System.Windows.Forms.Label labelCell;
        private System.Windows.Forms.NumericUpDown numericUpDownCell;
        private System.Windows.Forms.Label labelStellazh;
        private System.Windows.Forms.NumericUpDown numericUpDownStellazh;
    }
}