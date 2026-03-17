namespace KnapsackSolverApp
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudMaxWeight = new System.Windows.Forms.NumericUpDown();
            this.bShowSourceData = new System.Windows.Forms.Button();
            this.bSolve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ItemName,
            this.Weight,
            this.Cost});
            this.dgvItems.Location = new System.Drawing.Point(16, 16);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(432, 304);
            this.dgvItems.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Название";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Вес";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Стоимость";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // nudMaxWeight
            // 
            this.nudMaxWeight.Location = new System.Drawing.Point(632, 32);
            this.nudMaxWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxWeight.Name = "nudMaxWeight";
            this.nudMaxWeight.Size = new System.Drawing.Size(80, 22);
            this.nudMaxWeight.TabIndex = 10;
            this.nudMaxWeight.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // bShowSourceData
            // 
            this.bShowSourceData.Location = new System.Drawing.Point(480, 296);
            this.bShowSourceData.Name = "bShowSourceData";
            this.bShowSourceData.Size = new System.Drawing.Size(232, 24);
            this.bShowSourceData.TabIndex = 9;
            this.bShowSourceData.Text = "Показать исходные данные";
            this.bShowSourceData.UseVisualStyleBackColor = true;
            this.bShowSourceData.Click += new System.EventHandler(this.bShowSourceData_Click);
            // 
            // bSolve
            // 
            this.bSolve.Location = new System.Drawing.Point(552, 72);
            this.bSolve.Name = "bSolve";
            this.bSolve.Size = new System.Drawing.Size(96, 24);
            this.bSolve.TabIndex = 8;
            this.bSolve.Text = "Решить";
            this.bSolve.UseVisualStyleBackColor = true;
            this.bSolve.Click += new System.EventHandler(this.bSolve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Макс. вес рюкзака:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 344);
            this.Controls.Add(this.nudMaxWeight);
            this.Controls.Add(this.bShowSourceData);
            this.Controls.Add(this.bSolve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задача о рюкзаке";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.NumericUpDown nudMaxWeight;
        private System.Windows.Forms.Button bShowSourceData;
        private System.Windows.Forms.Button bSolve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}

