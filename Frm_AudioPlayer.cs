using BuesnissLayer;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AudioPlayer.Properties;
using System.Text;
using System.IO;
using System.Threading;
using System;
using Guna.UI2.WinForms;
using NAudio.Wave;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public partial class Frm_AudioPlayer : Form
    {
        clsAudio Audio = new clsAudio();
        List<string> AudioList = clsPlaylist.LoadFiles();
        /// <summary>
        /// To Change Property of Buttons 
        /// </summary>
        /// <param name="Btn">Button You Want To Change</param>
        /// <param name="Path">Path of Image</param>
        /// <param name="Tag">Tag Property</param>
        private void Change_Button_Property(Guna2Button Btn, string imagePath, string tag)
        {
            using (var image = Image.FromFile(imagePath))
            {
                Btn.BackgroundImage = new Bitmap(image);
            }
            Btn.Tag = tag;
        }
        /// <summary>
        /// Fill The List in data grid view
        /// </summary>
        private void Load_Data()
        {
            foreach (string s in AudioList)
                dgv_PlayList.Rows.Add(clsPlaylist.ShowPath(s));
        }
        private void Play(string Path)
        {
            try
            {
                Audio.Path = Path;
                UpdateUI(() =>
                {
                    Change_Button_Property(Btn_Play, @"C:\Users\DELL\Desktop\Projects\Desktop_App\AudioPlayer\Icons\pause-button.png", "Pause");
                });
                Parallel.Invoke(Duration.Start, Audio.Play);
                UpdateUI(() => Audio_Progress.Maximum = (int)Audio.Total_Time.TotalSeconds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset(bool loop)
        {
            if (loop)
                Play(AudioList[dgv_PlayList.CurrentRow.Index]);
            else
            {
                if (dgv_PlayList.CurrentRow.Index == dgv_PlayList.RowCount - 1)
                {
                    Play(AudioList[0]);
                    dgv_PlayList.CurrentCell = dgv_PlayList.Rows[0].Cells[0];
                }
                else
                {
                    Play(AudioList[dgv_PlayList.CurrentRow.Index + 1]);
                    dgv_PlayList.CurrentCell = dgv_PlayList.Rows[dgv_PlayList.CurrentRow.Index + 1].Cells[0];
                }
            }
            Audio.Reset();
        }
        private void Pause()
        {
            try
            {
                Change_Button_Property(Btn_Play,
                @"C:\Users\DELL\Desktop\Projects\Desktop_App\AudioPlayer\Icons\pause-button.png",
                "Resume");
                Audio.Pause();
                Duration.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Resume()
        {
            try
            {
                Change_Button_Property(Btn_Play,
                    @"C:\Users\DELL\Desktop\Projects\Desktop_App\AudioPlayer\Icons\play-button.png",
                    "Pause");
                Audio.Resume();
                Duration.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Frm_AudioPlayer()
        {
            InitializeComponent();
            Load_Data();
        }
        private void Btn_Play_Click(object sender, EventArgs e)
        {
            if (Btn_Play.Tag.ToString() == "Play")
                Play(AudioList[dgv_PlayList.CurrentRow.Index]);
            else if (Btn_Play.Tag.ToString() == "Pause")
                Pause();
            else
                Resume();
        }
        private void dgv_PlayList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Audio.Reset();
            Play(AudioList[e.RowIndex]);
        }
        private void Keyboard(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
        private void Duration_Tick(object sender, EventArgs e)
        {
            if (Audio.Get_State() == PlaybackState.Stopped)
            {
                Reset(Btn_Looped.Tag.ToString() == "Looped");
                return;
            }
            Audio.Tick();
            UpdateUI(() =>
            {
                Audio_Progress.Value = (int)Audio.Current_Time.TotalSeconds;
                lbl_Duration.Text = Audio.Get_Time();
            });
        }
        private void Btn_Looped_Click(object sender, EventArgs e)
        {
            if (Btn_Looped.Tag.ToString() == "Looped")
                Change_Button_Property(Btn_Looped,
                 @"C:\Users\DELL\Desktop\Projects\Desktop_App\AudioPlayer\Icons\arrow (1).png",
                 "No Loop");
            else
                Change_Button_Property(Btn_Looped,
                 @"C:\Users\DELL\Desktop\Projects\Desktop_App\AudioPlayer\Icons\loop.png",
                 "Looped");
        }
        private void Audio_Progress_Scroll(object sender, ScrollEventArgs e)
        { 
            Audio.PlayFrom(e.NewValue, Audio_Progress.Maximum, Audio_Progress.Minimum);
            StringBuilder Time = new StringBuilder(Audio.Get_Time());
            lbl_Duration.Text = Time.ToString();
        }
        private void Btn_Move10_Click(object sender, EventArgs e)
        {
            Audio.AddSeconds(10);
            UpdateUI(() =>
            {
                StringBuilder durationText = new StringBuilder(Audio.Get_Time());
                lbl_Duration.Text = durationText.ToString();
            });
        }
        private void Btn_Back10_Click(object sender, EventArgs e)
        {
            Audio.AddSeconds(-10);
            UpdateUI(() =>
            {
                StringBuilder durationText = new StringBuilder(Audio.Get_Time());
                lbl_Duration.Text = durationText.ToString();
            });
        }
        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (dgv_PlayList.CurrentRow.Index == dgv_PlayList.RowCount - 1)
            {
                Play(AudioList[0]);
                UpdateUI(() =>
                {
                    dgv_PlayList.CurrentCell = dgv_PlayList.Rows[0].Cells[0];
                });
            }
            else
            {
                Play(AudioList[dgv_PlayList.CurrentRow.Index + 1]);
                UpdateUI(() =>
                {
                    dgv_PlayList.CurrentCell = dgv_PlayList.Rows[dgv_PlayList.CurrentRow.Index + 1].Cells[0];
                });
            }
        }
        private void Btn_Prev_Click(object sender, EventArgs e)
        {
            if (dgv_PlayList.CurrentRow.Index == 0)
            {
                Play(AudioList[dgv_PlayList.RowCount - 1]);
                UpdateUI(() =>
                {
                    dgv_PlayList.CurrentCell = dgv_PlayList.Rows[dgv_PlayList.Rows.Count - 1].Cells[0];
                });
            }
            else
            {
                Play(AudioList[dgv_PlayList.CurrentRow.Index - 1]);
                UpdateUI(() =>
                {
                    dgv_PlayList.CurrentCell = dgv_PlayList.Rows[dgv_PlayList.CurrentRow.Index - 1].Cells[0];
                });
            }
        }
        private string Volume_Image(int Progress)
        {
            if (Volume_Progress.Value >= 50 && Volume_Progress.Value <= 75)
                return @"C:\Users\DELL\Desktop\Projects\Desktop_App\AudioPlayer\Icons\speaker-filled-audio-tool.png";
            else if (Volume_Progress.Value == 0)
                return @"C:\Users\DELL\Desktop\Projects\Desktop_App\AudioPlayer\Icons\Mute.png";
            else if (Volume_Progress.Value < 50)
                return @"C:\Users\DELL\Desktop\Projects\Desktop_App\AudioPlayer\Icons\low-volume.png";
            else
                return @"C:\Users\DELL\Desktop\Projects\Desktop_App\AudioPlayer\Icons\volume-up-interface-symbol.png";
        }
        private void Volume_Progress_Scroll(object sender, ScrollEventArgs e)
        {
            Change_Button_Property(Btn_Volume, Volume_Image(Volume_Progress.Value), Btn_Volume.Tag.ToString());
            Audio.Volume = (float)Volume_Progress.Value / 100;
        }
        private void Btn_Volume_Click(object sender, EventArgs e)
        {
            if (Btn_Volume.Tag.ToString() == "Mute")
            {
                Audio.Mute();
                Change_Button_Property(Btn_Volume,
                  @"C:\Users\DELL\Desktop\Projects\Desktop_App\AudioPlayer\Icons\Mute.png",
                  "Unmute");
            }
            else
            {
                Audio.Volume = (float)Volume_Progress.Value / 100;
                Change_Button_Property(Btn_Volume, Volume_Image(Volume_Progress.Value) , "Mute");
            }
        }
        private void UpdateUI(Action updateAction)
        {
            if (InvokeRequired)
            {
                Invoke(updateAction);
            }
            else
            {
                updateAction();
            }
        }
    }
}
