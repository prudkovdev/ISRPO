namespace AlarmClockApp
{
    partial class AlarmEditForm
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
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.cbRepeatDaily = new System.Windows.Forms.CheckBox();
            this.tbLabel = new System.Windows.Forms.TextBox();
            this.bOK = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Location = new System.Drawing.Point(24, 64);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(84, 20);
            this.cbIsActive.TabIndex = 1;
            this.cbIsActive.Text = "Активен";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // cbRepeatDaily
            // 
            this.cbRepeatDaily.AutoSize = true;
            this.cbRepeatDaily.Location = new System.Drawing.Point(24, 96);
            this.cbRepeatDaily.Name = "cbRepeatDaily";
            this.cbRepeatDaily.Size = new System.Drawing.Size(175, 20);
            this.cbRepeatDaily.TabIndex = 2;
            this.cbRepeatDaily.Text = "Повторять ежедневно";
            this.cbRepeatDaily.UseVisualStyleBackColor = true;
            // 
            // tbLabel
            // 
            this.tbLabel.Location = new System.Drawing.Point(24, 136);
            this.tbLabel.Name = "tbLabel";
            this.tbLabel.Size = new System.Drawing.Size(200, 22);
            this.tbLabel.TabIndex = 3;
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(160, 176);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(64, 32);
            this.bOK.TabIndex = 4;
            this.bOK.Text = "ОК";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(64, 176);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(80, 32);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(24, 24);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(200, 22);
            this.dtpTime.TabIndex = 6;
            // 
            // AlarmEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 224);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.tbLabel);
            this.Controls.Add(this.cbRepeatDaily);
            this.Controls.Add(this.cbIsActive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlarmEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки будильника";
            this.Load += new System.EventHandler(this.AlarmEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.CheckBox cbRepeatDaily;
        private System.Windows.Forms.TextBox tbLabel;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.DateTimePicker dtpTime;
    }
}