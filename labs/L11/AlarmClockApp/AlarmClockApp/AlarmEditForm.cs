using System;
using System.Windows.Forms;

namespace AlarmClockApp
{
    public partial class AlarmEditForm : Form
    {
        private Alarm _alarm;
        public Alarm Alarm { get { return _alarm; } }

        public AlarmEditForm(Alarm alarm)
        {
            InitializeComponent();
            _alarm = alarm;
        }

        private void AlarmEditForm_Load(object sender, EventArgs e)
        {
            dtpTime.Value = DateTime.Parse(_alarm.AlarmTime.ToString());
            cbIsActive.Checked = _alarm.IsActive;
            cbRepeatDaily.Checked = _alarm.RepeatDaily;
            tbLabel.Text = _alarm.Label;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            _alarm.AlarmTime = dtpTime.Value.TimeOfDay;
            _alarm.IsActive = cbIsActive.Checked;
            _alarm.RepeatDaily = cbRepeatDaily.Checked;
            _alarm.Label = tbLabel.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
