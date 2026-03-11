namespace Testing
{
    partial class ResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lCorrectAnswers = new System.Windows.Forms.Label();
            this.lResult = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.bAgain = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тест завершён";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lCorrectAnswers
            // 
            this.lCorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCorrectAnswers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lCorrectAnswers.Location = new System.Drawing.Point(40, 72);
            this.lCorrectAnswers.Name = "lCorrectAnswers";
            this.lCorrectAnswers.Size = new System.Drawing.Size(720, 29);
            this.lCorrectAnswers.TabIndex = 1;
            this.lCorrectAnswers.Text = "Правильных ответов: 0 из 0";
            this.lCorrectAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lResult
            // 
            this.lResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lResult.Location = new System.Drawing.Point(40, 112);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(720, 29);
            this.lResult.TabIndex = 2;
            this.lResult.Text = "Результат 0% -";
            this.lResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(40, 152);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersWidth = 51;
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(720, 200);
            this.dgvResult.TabIndex = 3;
            // 
            // bAgain
            // 
            this.bAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAgain.ForeColor = System.Drawing.Color.White;
            this.bAgain.Location = new System.Drawing.Point(144, 384);
            this.bAgain.Name = "bAgain";
            this.bAgain.Size = new System.Drawing.Size(200, 32);
            this.bAgain.TabIndex = 4;
            this.bAgain.Text = "Пройти заново";
            this.bAgain.UseVisualStyleBackColor = false;
            this.bAgain.Click += new System.EventHandler(this.bAgain_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Gray;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.ForeColor = System.Drawing.Color.White;
            this.bExit.Location = new System.Drawing.Point(456, 384);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(200, 32);
            this.bExit.TabIndex = 5;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bAgain);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.lCorrectAnswers);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты теста";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lCorrectAnswers;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button bAgain;
        private System.Windows.Forms.Button bExit;
    }
}