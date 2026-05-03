using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;

namespace MusicPlayerApp
{
    public partial class MainForm : Form
    {
        private List<MusicTrack> _allMusicTracks;  // полный список всех треков (для сброса поиска)
        private List<MusicTrack> _musicTracks = new List<MusicTrack>();
        private List<MusicTrack> _MusicTracks
        {
            get { return _musicTracks; }
            set
            {
                _musicTracks = value;
                lvMusicTracks.Items.Clear();
                foreach (var track in _musicTracks)
                    AddTrackToLVMusicTracks(track);

                if (lvMusicTracks.Items.Count > 0)
                    lvMusicTracks.Items[0].Selected = true;
                else
                {
                    lTitle.Text = $"Название: ";
                    lArtist.Text = $"Исполнитель: ";
                    lDuration.Text = $"Длительность: ";
                    lPlayCount.Text = $"Прослушиваний: ";
                    lAddedDate.Text = $"Дата добавления: ";
                }
            }
        }

        private MusicTrack _track;
        private MusicTrack _Track
        {
            get { return _track; }
            set
            {
                if (_track != value)
                {
                    // Останавливаем текущее воспроизведение при смене трека
                    StopPlayback();
                    _track = value;
                    LoadMusicTrack(_track);
                }
            }
        }

        // Компоненты воспроизведения
        private IWavePlayer waveOut;
        private WaveStream waveStream;
        private Timer playbackTimer;
        private bool isPlaying = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadMusicTrack(MusicTrack track)
        {
            lTitle.Text = $"Название: {track.Title}";
            lArtist.Text = $"Исполнитель: {track.Artist}";
            lDuration.Text = $"Длительность: {track.Duration.ToString(@"mm\:ss")}";
            lPlayCount.Text = $"Прослушиваний: {track.PlayCount.ToString()}";
            lAddedDate.Text = $"Дата добавления: {track.AddedDate.ToString("dd.MM.yyyy HH:mm")}";
            lDurationEnd.Text = track.Duration.ToString(@"mm\:ss");
            tbarDuration.Maximum = (int)track.Duration.TotalMilliseconds;
            tbarDuration.Value = 0;
            lDurationBegin.Text = "00:00";
        }

        private void RestoreSelectionAfterFilter()
        {
            if (_track != null)
            {
                foreach (ListViewItem item in lvMusicTracks.Items)
                {
                    if (((MusicTrack)item.Tag).Id == _track.Id)
                    {
                        item.Selected = true;
                        break;
                    }
                }
            }
        }

        private void bToLastTrack_Click(object sender, EventArgs e)
        {
            if (lvMusicTracks.Items.Count == 0) return;
            int currentIndex = lvMusicTracks.SelectedIndices.Count > 0 ? lvMusicTracks.SelectedIndices[0] : 0;
            int newIndex = currentIndex - 1;
            if (newIndex < 0) newIndex = lvMusicTracks.Items.Count - 1;
            lvMusicTracks.Items[newIndex].Selected = true;
        }

        private void bToNextTrack_Click(object sender, EventArgs e)
        {
            if (lvMusicTracks.Items.Count == 0) return;
            int currentIndex = lvMusicTracks.SelectedIndices.Count > 0 ? lvMusicTracks.SelectedIndices[0] : -1;
            int newIndex = currentIndex + 1;
            if (newIndex >= lvMusicTracks.Items.Count) newIndex = 0;
            lvMusicTracks.Items[newIndex].Selected = true;
        }

        private void bFirstTrack_Click(object sender, EventArgs e)
        {
            if (lvMusicTracks.Items.Count > 0)
                lvMusicTracks.Items[0].Selected = true;
        }

        private void bLastTrack_Click(object sender, EventArgs e)
        {
            if (lvMusicTracks.Items.Count > 0)
                lvMusicTracks.Items[lvMusicTracks.Items.Count - 1].Selected = true;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            string searchText = tbSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                _MusicTracks = _allMusicTracks;
                RestoreSelectionAfterFilter();
                return;
            }

            var filtered = _allMusicTracks.FindAll(track =>
                (track.Title != null && track.Title.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (track.Artist != null && track.Artist.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
            );

            _MusicTracks = filtered;
            RestoreSelectionAfterFilter();

            if (filtered.Count == 0)
                MessageBox.Show("Ничего не найдено.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                _MusicTracks = _allMusicTracks;
                RestoreSelectionAfterFilter();
            }
        }
        private void AddTrackToLVMusicTracks(MusicTrack track)
        {
            ListViewItem item = new ListViewItem(track.Title ?? "Неизвестно");
            item.SubItems.Add(track.Artist ?? "Неизвестно");
            item.SubItems.Add(track.Duration.ToString(@"mm\:ss"));
            item.SubItems.Add(track.PlayCount.ToString());
            item.SubItems.Add(track.AddedDate.ToString("dd.MM.yyyy HH:mm"));
            item.Tag = track;
            lvMusicTracks.Items.Add(item);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _allMusicTracks = DatabaseHelper.GetMusicTracks();   // сохраняем полный список
            _MusicTracks = _allMusicTracks;

            // Настройка таймера обновления позиции
            playbackTimer = new Timer();
            playbackTimer.Interval = 100;
            playbackTimer.Tick += PlaybackTimer_Tick;
            playbackTimer.Start();

            // Настройка громкости
            tbVolume.Minimum = 0;
            tbVolume.Maximum = 100;
            tbVolume.Value = 80;
            lVolumeValue.Text = "80";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            playbackTimer?.Stop();
            StopPlayback();
        }

        private void StopPlayback()
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if (waveStream != null)
            {
                waveStream.Dispose();
                waveStream = null;
            }
            isPlaying = false;
            bPlayPause.Text = "▶";
            tbarDuration.Value = 0;
            lDurationBegin.Text = "00:00";
            if (_track != null)
                lDurationEnd.Text = _track.Duration.ToString(@"mm\:ss");
        }

        private void bPlayPause_Click(object sender, EventArgs e)
        {
            if (_track == null)
            {
                MessageBox.Show("Выберите трек для воспроизведения.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (waveOut == null)
            {
                // Начинаем воспроизведение с нуля
                try
                {
                    MemoryStream ms = new MemoryStream(_track.FileData);
                    string ext = Path.GetExtension(_track.FileName).ToLower();

                    if (ext == ".mp3")
                        waveStream = new Mp3FileReader(ms);
                    else if (ext == ".wav")
                        waveStream = new WaveFileReader(ms);
                    else
                        throw new NotSupportedException($"Формат {ext} не поддерживается");

                    waveOut = new WaveOutEvent();
                    waveOut.Init(waveStream);
                    waveOut.PlaybackStopped += WaveOut_PlaybackStopped;

                    if (waveOut is WaveOutEvent waveOutEvent)
                        waveOutEvent.Volume = tbVolume.Value / 100f;

                    waveOut.Play();
                    isPlaying = true;
                    bPlayPause.Text = "⏸";

                    // Обновляем счётчик прослушиваний
                    _track.PlayCount++;
                    DatabaseHelper.UpdatePlayCount(_track.Id, _track.PlayCount);
                    UpdatePlayCountDisplay(_track);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка воспроизведения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    StopPlayback();
                }
            }
            else
            {
                // Управление паузой/продолжением
                if (waveOut.PlaybackState == PlaybackState.Playing)
                {
                    waveOut.Pause();
                    isPlaying = false;
                    bPlayPause.Text = "▶";
                }
                else if (waveOut.PlaybackState == PlaybackState.Paused)
                {
                    waveOut.Play();
                    isPlaying = true;
                    bPlayPause.Text = "⏸";
                }
            }
        }
        private void WaveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            // Проверяем, не находится ли форма в процессе закрытия
            if (this.IsDisposed || !this.IsHandleCreated || this.Disposing)
                return;

            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    if (e.Exception != null)
                        MessageBox.Show($"Воспроизведение остановлено с ошибкой: {e.Exception.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    StopPlayback();
                });
            }
            catch (InvalidOperationException)
            {
                // Игнорируем исключение, если форма уже закрыта
            }
        }

        private void PlaybackTimer_Tick(object sender, EventArgs e)
        {
            if (waveStream != null && waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
            {
                // Текущая позиция в миллисекундах
                double positionMs = waveStream.CurrentTime.TotalMilliseconds;
                double totalMs = waveStream.TotalTime.TotalMilliseconds;

                if (totalMs > 0)
                {
                    // Обновляем ползунок без вызова события Scroll
                    if (tbarDuration.Value != (int)positionMs)
                    {
                        if ((int)positionMs <= tbarDuration.Maximum)
                            tbarDuration.Value = (int)positionMs;
                        lDurationBegin.Text = waveStream.CurrentTime.ToString(@"mm\:ss");
                        var remaining = waveStream.TotalTime - waveStream.CurrentTime;
                        lDurationEnd.Text = remaining.ToString(@"mm\:ss");
                    }
                }
            }
        }

        private void tbarDuration_Scroll(object sender, EventArgs e)
        {
            if (waveStream != null && waveOut != null)
            {
                double newPosMs = tbarDuration.Value;
                waveStream.CurrentTime = TimeSpan.FromMilliseconds(newPosMs);
                lDurationBegin.Text = waveStream.CurrentTime.ToString(@"mm\:ss");
                var remaining = waveStream.TotalTime - waveStream.CurrentTime;
                lDurationEnd.Text = remaining.ToString(@"mm\:ss");
            }
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            lVolumeValue.Text = tbVolume.Value.ToString();
            if (waveOut is WaveOutEvent waveOutEvent)
            {
                waveOutEvent.Volume = tbVolume.Value / 100f;
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Аудиофайлы (*.mp3;*.wav)|*.mp3;*.wav|Все файлы (*.*)|*.*";
                openFileDialog.Title = "Выберите аудиофайл";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var track = AudioFileReader.Read(openFileDialog.FileName);
                        DatabaseHelper.InsertMusicTrack(track);
                        _MusicTracks = DatabaseHelper.GetMusicTracks();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при добавлении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (_track != null)
            {
                DatabaseHelper.DeleteMusicTrack(_track.Id);
                _MusicTracks = DatabaseHelper.GetMusicTracks();
                if (_MusicTracks.Count == 0)
                    StopPlayback();
            }
        }

        private void lvMusicTracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMusicTracks.Items)
                if (item.Selected)
                {
                    _Track = (MusicTrack)item.Tag;
                    break;
                }
        }

        private void UpdatePlayCountDisplay(MusicTrack updatedTrack)
        {
            foreach (ListViewItem item in lvMusicTracks.Items)
            {
                if (item.Tag == updatedTrack)
                {
                    item.SubItems[3].Text = updatedTrack.PlayCount.ToString();
                    break;
                }
            }
            if (_track == updatedTrack)
                lPlayCount.Text = $"Прослушиваний: {updatedTrack.PlayCount}";
        }
    }
}