namespace MusicPlayerApp
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.lvMusicTracks = new System.Windows.Forms.ListView();
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPlayCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAddedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bFirstTrack = new System.Windows.Forms.Button();
            this.bToLastTrack = new System.Windows.Forms.Button();
            this.bPlayPause = new System.Windows.Forms.Button();
            this.bToNextTrack = new System.Windows.Forms.Button();
            this.bLastTrack = new System.Windows.Forms.Button();
            this.tbarDuration = new System.Windows.Forms.TrackBar();
            this.lDurationBegin = new System.Windows.Forms.Label();
            this.lDurationEnd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lAddedDate = new System.Windows.Forms.Label();
            this.lPlayCount = new System.Windows.Forms.Label();
            this.lDuration = new System.Windows.Forms.Label();
            this.lArtist = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.lVolume = new System.Windows.Forms.Label();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.lVolumeValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbarDuration)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(8, 8);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(200, 22);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Поиск";
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(216, 8);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(88, 24);
            this.bSearch.TabIndex = 1;
            this.bSearch.Text = "Поиск";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(624, 8);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(88, 24);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(720, 8);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(88, 24);
            this.bDelete.TabIndex = 3;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // lvMusicTracks
            // 
            this.lvMusicTracks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitle,
            this.chArtist,
            this.chDuration,
            this.chPlayCount,
            this.chAddedDate});
            this.lvMusicTracks.FullRowSelect = true;
            this.lvMusicTracks.HideSelection = false;
            this.lvMusicTracks.Location = new System.Drawing.Point(8, 40);
            this.lvMusicTracks.MultiSelect = false;
            this.lvMusicTracks.Name = "lvMusicTracks";
            this.lvMusicTracks.Size = new System.Drawing.Size(800, 200);
            this.lvMusicTracks.TabIndex = 4;
            this.lvMusicTracks.UseCompatibleStateImageBehavior = false;
            this.lvMusicTracks.View = System.Windows.Forms.View.Details;
            this.lvMusicTracks.SelectedIndexChanged += new System.EventHandler(this.lvMusicTracks_SelectedIndexChanged);
            // 
            // chTitle
            // 
            this.chTitle.Text = "Название";
            this.chTitle.Width = 252;
            // 
            // chArtist
            // 
            this.chArtist.Text = "Исполнитель";
            this.chArtist.Width = 179;
            // 
            // chDuration
            // 
            this.chDuration.Text = "Длительность";
            this.chDuration.Width = 117;
            // 
            // chPlayCount
            // 
            this.chPlayCount.Text = "Прослушиваний";
            this.chPlayCount.Width = 127;
            // 
            // chAddedDate
            // 
            this.chAddedDate.Text = "Дата добавления";
            this.chAddedDate.Width = 159;
            // 
            // bFirstTrack
            // 
            this.bFirstTrack.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bFirstTrack.Location = new System.Drawing.Point(232, 480);
            this.bFirstTrack.Name = "bFirstTrack";
            this.bFirstTrack.Size = new System.Drawing.Size(64, 48);
            this.bFirstTrack.TabIndex = 5;
            this.bFirstTrack.Text = "⏮";
            this.bFirstTrack.UseVisualStyleBackColor = true;
            this.bFirstTrack.Click += new System.EventHandler(this.bFirstTrack_Click);
            // 
            // bToLastTrack
            // 
            this.bToLastTrack.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.bToLastTrack.Location = new System.Drawing.Point(304, 480);
            this.bToLastTrack.Name = "bToLastTrack";
            this.bToLastTrack.Size = new System.Drawing.Size(64, 48);
            this.bToLastTrack.TabIndex = 6;
            this.bToLastTrack.Text = "⏪︎";
            this.bToLastTrack.UseVisualStyleBackColor = true;
            this.bToLastTrack.Click += new System.EventHandler(this.bToLastTrack_Click);
            // 
            // bPlayPause
            // 
            this.bPlayPause.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPlayPause.Location = new System.Drawing.Point(376, 480);
            this.bPlayPause.Name = "bPlayPause";
            this.bPlayPause.Size = new System.Drawing.Size(64, 48);
            this.bPlayPause.TabIndex = 7;
            this.bPlayPause.Text = "▶";
            this.bPlayPause.UseVisualStyleBackColor = true;
            this.bPlayPause.Click += new System.EventHandler(this.bPlayPause_Click);
            // 
            // bToNextTrack
            // 
            this.bToNextTrack.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bToNextTrack.Location = new System.Drawing.Point(448, 480);
            this.bToNextTrack.Name = "bToNextTrack";
            this.bToNextTrack.Size = new System.Drawing.Size(64, 48);
            this.bToNextTrack.TabIndex = 8;
            this.bToNextTrack.Text = "⏩︎";
            this.bToNextTrack.UseVisualStyleBackColor = true;
            this.bToNextTrack.Click += new System.EventHandler(this.bToNextTrack_Click);
            // 
            // bLastTrack
            // 
            this.bLastTrack.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLastTrack.Location = new System.Drawing.Point(520, 480);
            this.bLastTrack.Name = "bLastTrack";
            this.bLastTrack.Size = new System.Drawing.Size(64, 48);
            this.bLastTrack.TabIndex = 9;
            this.bLastTrack.Text = "⏭";
            this.bLastTrack.UseVisualStyleBackColor = true;
            this.bLastTrack.Click += new System.EventHandler(this.bLastTrack_Click);
            // 
            // tbarDuration
            // 
            this.tbarDuration.AutoSize = false;
            this.tbarDuration.LargeChange = 10;
            this.tbarDuration.Location = new System.Drawing.Point(8, 432);
            this.tbarDuration.Maximum = 180;
            this.tbarDuration.Name = "tbarDuration";
            this.tbarDuration.Size = new System.Drawing.Size(800, 40);
            this.tbarDuration.SmallChange = 10;
            this.tbarDuration.TabIndex = 10;
            this.tbarDuration.Scroll += new System.EventHandler(this.tbarDuration_Scroll);
            // 
            // lDurationBegin
            // 
            this.lDurationBegin.AutoSize = true;
            this.lDurationBegin.Location = new System.Drawing.Point(16, 408);
            this.lDurationBegin.Name = "lDurationBegin";
            this.lDurationBegin.Size = new System.Drawing.Size(38, 16);
            this.lDurationBegin.TabIndex = 11;
            this.lDurationBegin.Text = "00:00";
            // 
            // lDurationEnd
            // 
            this.lDurationEnd.AutoSize = true;
            this.lDurationEnd.Location = new System.Drawing.Point(760, 408);
            this.lDurationEnd.Name = "lDurationEnd";
            this.lDurationEnd.Size = new System.Drawing.Size(38, 16);
            this.lDurationEnd.TabIndex = 12;
            this.lDurationEnd.Text = "00:00";
            this.lDurationEnd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lAddedDate);
            this.groupBox1.Controls.Add(this.lPlayCount);
            this.groupBox1.Controls.Add(this.lDuration);
            this.groupBox1.Controls.Add(this.lArtist);
            this.groupBox1.Controls.Add(this.lTitle);
            this.groupBox1.Location = new System.Drawing.Point(8, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 136);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о треке";
            // 
            // lAddedDate
            // 
            this.lAddedDate.AutoSize = true;
            this.lAddedDate.Location = new System.Drawing.Point(472, 96);
            this.lAddedDate.Name = "lAddedDate";
            this.lAddedDate.Size = new System.Drawing.Size(124, 16);
            this.lAddedDate.TabIndex = 4;
            this.lAddedDate.Text = "Дата добавления:";
            // 
            // lPlayCount
            // 
            this.lPlayCount.AutoSize = true;
            this.lPlayCount.Location = new System.Drawing.Point(264, 96);
            this.lPlayCount.Name = "lPlayCount";
            this.lPlayCount.Size = new System.Drawing.Size(116, 16);
            this.lPlayCount.TabIndex = 3;
            this.lPlayCount.Text = "Прослушиваний:";
            // 
            // lDuration
            // 
            this.lDuration.AutoSize = true;
            this.lDuration.Location = new System.Drawing.Point(16, 96);
            this.lDuration.Name = "lDuration";
            this.lDuration.Size = new System.Drawing.Size(102, 16);
            this.lDuration.TabIndex = 2;
            this.lDuration.Text = "Длительность:";
            // 
            // lArtist
            // 
            this.lArtist.AutoSize = true;
            this.lArtist.Location = new System.Drawing.Point(16, 64);
            this.lArtist.Name = "lArtist";
            this.lArtist.Size = new System.Drawing.Size(94, 16);
            this.lArtist.TabIndex = 1;
            this.lArtist.Text = "Исполнитель";
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Location = new System.Drawing.Point(16, 32);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(76, 16);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Название:";
            // 
            // lVolume
            // 
            this.lVolume.AutoSize = true;
            this.lVolume.Location = new System.Drawing.Point(600, 480);
            this.lVolume.Name = "lVolume";
            this.lVolume.Size = new System.Drawing.Size(75, 16);
            this.lVolume.TabIndex = 14;
            this.lVolume.Text = "Громкость";
            // 
            // tbVolume
            // 
            this.tbVolume.AutoSize = false;
            this.tbVolume.LargeChange = 25;
            this.tbVolume.Location = new System.Drawing.Point(600, 504);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(176, 24);
            this.tbVolume.SmallChange = 2;
            this.tbVolume.TabIndex = 15;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // lVolumeValue
            // 
            this.lVolumeValue.AutoSize = true;
            this.lVolumeValue.Location = new System.Drawing.Point(776, 504);
            this.lVolumeValue.Name = "lVolumeValue";
            this.lVolumeValue.Size = new System.Drawing.Size(14, 16);
            this.lVolumeValue.TabIndex = 16;
            this.lVolumeValue.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 536);
            this.Controls.Add(this.lVolumeValue);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.lVolume);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lDurationEnd);
            this.Controls.Add(this.lDurationBegin);
            this.Controls.Add(this.tbarDuration);
            this.Controls.Add(this.bLastTrack);
            this.Controls.Add(this.bToNextTrack);
            this.Controls.Add(this.bPlayPause);
            this.Controls.Add(this.bToLastTrack);
            this.Controls.Add(this.bFirstTrack);
            this.Controls.Add(this.lvMusicTracks);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.tbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Музыкальный плеер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbarDuration)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.ListView lvMusicTracks;
        private System.Windows.Forms.Button bFirstTrack;
        private System.Windows.Forms.Button bToLastTrack;
        private System.Windows.Forms.Button bPlayPause;
        private System.Windows.Forms.Button bToNextTrack;
        private System.Windows.Forms.Button bLastTrack;
        private System.Windows.Forms.TrackBar tbarDuration;
        private System.Windows.Forms.Label lDurationBegin;
        private System.Windows.Forms.Label lDurationEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lAddedDate;
        private System.Windows.Forms.Label lPlayCount;
        private System.Windows.Forms.Label lDuration;
        private System.Windows.Forms.Label lArtist;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lVolume;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Label lVolumeValue;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chArtist;
        private System.Windows.Forms.ColumnHeader chDuration;
        private System.Windows.Forms.ColumnHeader chPlayCount;
        private System.Windows.Forms.ColumnHeader chAddedDate;
    }
}

