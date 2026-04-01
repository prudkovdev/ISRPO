using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace AlarmClockApp
{
    public partial class AlarmForm : Form
    {
        private List<Alarm> _alarms;
        private Alarm _selectedAlarm;
        private int _selectedDGVAlarmsIndex;
        private int _SelectedDGVAlarmsIndex
        {
            get { return _selectedDGVAlarmsIndex; }
            set
            {
                _selectedDGVAlarmsIndex = value;
                dgvAlarms.ClearSelection();
                dgvAlarms.Rows[value].Selected = true;
                _selectedAlarm = _alarms[value];
            }
        }
        private bool _clock = false;

        public AlarmForm()
        {
            InitializeComponent();
        }

        private void RefreshDGVAlarms()
        {
            dgvAlarms.Rows.Clear();
            _alarms = DatabaseHelper.GetAlarms();
            foreach (var alarm in _alarms)
                dgvAlarms.Rows.Add(
                    alarm.IsActive,
                    (alarm.AlarmTime.ToString() + ".").Remove(8),
                    alarm.Label,
                    alarm.RepeatDaily,
                    alarm.CreatedDate);
            
            if (dgvAlarms.Rows.Count > 0)
                _SelectedDGVAlarmsIndex = 0;
        }

        private void Play()
        {
            bSetAside.Enabled = true;
            bSetAside.Visible = true;
            bOff.Enabled = true;
            bOff.Visible = true;
            lAlarm.BackColor = Color.Red;
            lAlarm.ForeColor = Color.White;
            lAlarm.Text = "Будильник звенит";
            tAlarm.Start();
        }

        private void Stop()
        {
            bSetAside.Enabled = false;
            bSetAside.Visible = false;
            bOff.Enabled = false;
            bOff.Visible = false;

            tAlarm.Stop();
            lAlarm.BackColor = Color.White;
            lAlarm.ForeColor = Color.Black;
            lAlarm.Text = "Будильник выключен";
        }

        private void AlarmForm_Load(object sender, EventArgs e)
        {
            var date = DateTime.Now;
            lDate.Text = $"{date.DayOfWeek}, {date.ToLongDateString()}";
            lClock.Text = DateTime.Now.TimeOfDay.ToString().Remove(8);
            tMain.Start();

            RefreshDGVAlarms();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lClock.Text = DateTime.Now.TimeOfDay.ToString().Remove(8);
            foreach (var alarm in _alarms)
                if (lClock.Text == alarm.AlarmTime.ToString() && alarm.IsActive)
                {
                    Play();
                    if (!alarm.RepeatDaily)
                    {
                        alarm.IsActive = false; 
                        DatabaseHelper.UpdateAlarm(alarm);
                        RefreshDGVAlarms();
                    }
                }
        }

        private void dgvAlarms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                _SelectedDGVAlarmsIndex = e.RowIndex;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            var alarmEditForm = new AlarmEditForm(new Alarm());
            var result = alarmEditForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                var alarm = alarmEditForm.Alarm;
                DatabaseHelper.InsertAlarm(alarm);
                MessageBox.Show("Будильник успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDGVAlarms();
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            var alarmEditForm = new AlarmEditForm(_selectedAlarm);
            var result = alarmEditForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                var alarm = alarmEditForm.Alarm;
                DatabaseHelper.UpdateAlarm(alarm);
                RefreshDGVAlarms();
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DatabaseHelper.DeleteAlarm(_selectedAlarm.Id);
            RefreshDGVAlarms();
        }

        private void tAlarm_Tick(object sender, EventArgs e)
        {
            _clock = !_clock;
            if (_clock)
            {
                lAlarm.BackColor = Color.DarkRed;
                SystemSounds.Exclamation.Play();
            }
            else
                lAlarm.BackColor = Color.Red;
        }

        private void bOff_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void bSetAside_Click(object sender, EventArgs e)
        {
            var alarm = new Alarm();
            alarm.AlarmTime += TimeSpan.FromMinutes(5);
            DatabaseHelper.InsertAlarm(alarm);
            RefreshDGVAlarms();
            Stop();
        }
    }
}
