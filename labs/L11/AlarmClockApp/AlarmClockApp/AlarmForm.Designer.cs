namespace AlarmClockApp
{
    partial class AlarmForm
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
            this.components = new System.ComponentModel.Container();
            this.lClock = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.dgvAlarms = new System.Windows.Forms.DataGridView();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.alarmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeatDaily = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSetAside = new System.Windows.Forms.Button();
            this.bOff = new System.Windows.Forms.Button();
            this.lAlarm = new System.Windows.Forms.Label();
            this.tMain = new System.Windows.Forms.Timer(this.components);
            this.tAlarm = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarms)).BeginInit();
            this.SuspendLayout();
            // 
            // lClock
            // 
            this.lClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClock.Location = new System.Drawing.Point(24, 24);
            this.lClock.Name = "lClock";
            this.lClock.Size = new System.Drawing.Size(424, 96);
            this.lClock.TabIndex = 0;
            this.lClock.Text = "00:00:00";
            this.lClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lDate
            // 
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDate.Location = new System.Drawing.Point(24, 120);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(424, 23);
            this.lDate.TabIndex = 1;
            this.lDate.Text = "Четверг, 1 января 2001 года";
            this.lDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(24, 160);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(128, 32);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(168, 160);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(136, 32);
            this.bEdit.TabIndex = 3;
            this.bEdit.Text = "Редактировать";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(320, 160);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(128, 32);
            this.bDelete.TabIndex = 4;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // dgvAlarms
            // 
            this.dgvAlarms.AllowUserToAddRows = false;
            this.dgvAlarms.AllowUserToDeleteRows = false;
            this.dgvAlarms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlarms.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlarms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isActive,
            this.alarmTime,
            this.label,
            this.repeatDaily,
            this.createdDate});
            this.dgvAlarms.Location = new System.Drawing.Point(24, 208);
            this.dgvAlarms.Name = "dgvAlarms";
            this.dgvAlarms.RowHeadersVisible = false;
            this.dgvAlarms.RowHeadersWidth = 51;
            this.dgvAlarms.RowTemplate.Height = 24;
            this.dgvAlarms.Size = new System.Drawing.Size(424, 160);
            this.dgvAlarms.TabIndex = 5;
            this.dgvAlarms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlarms_CellClick);
            // 
            // isActive
            // 
            this.isActive.HeaderText = "Активен";
            this.isActive.MinimumWidth = 6;
            this.isActive.Name = "isActive";
            this.isActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isActive.Width = 91;
            // 
            // alarmTime
            // 
            this.alarmTime.HeaderText = "Время";
            this.alarmTime.MinimumWidth = 6;
            this.alarmTime.Name = "alarmTime";
            this.alarmTime.Width = 77;
            // 
            // label
            // 
            this.label.HeaderText = "Название";
            this.label.MinimumWidth = 6;
            this.label.Name = "label";
            this.label.Width = 102;
            // 
            // repeatDaily
            // 
            this.repeatDaily.HeaderText = "Ежедневно";
            this.repeatDaily.MinimumWidth = 6;
            this.repeatDaily.Name = "repeatDaily";
            this.repeatDaily.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.repeatDaily.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.repeatDaily.Width = 112;
            // 
            // createdDate
            // 
            this.createdDate.HeaderText = "Дата создания";
            this.createdDate.MinimumWidth = 6;
            this.createdDate.Name = "createdDate";
            this.createdDate.Width = 122;
            // 
            // bSetAside
            // 
            this.bSetAside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bSetAside.Enabled = false;
            this.bSetAside.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSetAside.Location = new System.Drawing.Point(24, 384);
            this.bSetAside.Name = "bSetAside";
            this.bSetAside.Size = new System.Drawing.Size(160, 32);
            this.bSetAside.TabIndex = 6;
            this.bSetAside.Text = "Отложить (5 мин)";
            this.bSetAside.UseVisualStyleBackColor = false;
            this.bSetAside.Visible = false;
            this.bSetAside.Click += new System.EventHandler(this.bSetAside_Click);
            // 
            // bOff
            // 
            this.bOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bOff.Enabled = false;
            this.bOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOff.Location = new System.Drawing.Point(288, 384);
            this.bOff.Name = "bOff";
            this.bOff.Size = new System.Drawing.Size(160, 32);
            this.bOff.TabIndex = 7;
            this.bOff.Text = "Выключить";
            this.bOff.UseVisualStyleBackColor = false;
            this.bOff.Visible = false;
            this.bOff.Click += new System.EventHandler(this.bOff_Click);
            // 
            // lAlarm
            // 
            this.lAlarm.BackColor = System.Drawing.Color.White;
            this.lAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAlarm.ForeColor = System.Drawing.Color.Black;
            this.lAlarm.Location = new System.Drawing.Point(24, 432);
            this.lAlarm.Name = "lAlarm";
            this.lAlarm.Size = new System.Drawing.Size(424, 40);
            this.lAlarm.TabIndex = 8;
            this.lAlarm.Text = "Будильник выключен";
            this.lAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tMain
            // 
            this.tMain.Interval = 1000;
            this.tMain.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tAlarm
            // 
            this.tAlarm.Interval = 500;
            this.tAlarm.Tick += new System.EventHandler(this.tAlarm_Tick);
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 497);
            this.Controls.Add(this.lAlarm);
            this.Controls.Add(this.bOff);
            this.Controls.Add(this.bSetAside);
            this.Controls.Add(this.dgvAlarms);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.lClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlarmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Будильник";
            this.Load += new System.EventHandler(this.AlarmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lClock;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.DataGridView dgvAlarms;
        private System.Windows.Forms.Button bSetAside;
        private System.Windows.Forms.Button bOff;
        private System.Windows.Forms.Label lAlarm;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn label;
        private System.Windows.Forms.DataGridViewCheckBoxColumn repeatDaily;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.Timer tMain;
        private System.Windows.Forms.Timer tAlarm;
    }
}

