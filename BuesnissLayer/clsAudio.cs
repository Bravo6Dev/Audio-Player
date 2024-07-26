using System;
using System.Threading;
using System.Threading.Tasks;
using NAudio.Gui;
using NAudio.Utils;
using NAudio.Wave;

namespace BuesnissLayer
{
    public class clsAudio 
    { 
        // Declare Variable To Dealing With Audio

        // To Convert The File To Audio wave
        WaveOutEvent wave;
        // To Read The Audio File
        AudioFileReader reader;
        // Create Wave Channel To Dealing With Volume
        WaveChannel32 Volume_Channel;
        long pausedPosition;

        public string Path { get; set; }
        public TimeSpan Total_Time {  get; set; }
        public TimeSpan Current_Time { get; set; }
        public float Volume 
        {  
            get { return wave.Volume; }
            set { wave.Volume = value; }
        }

        /// <summary>
        /// Calculate The Percantage of desired seconds in range (max - min + 1)
        /// </summary>
        /// <param name="Pos">desired position</param>
        /// <param name="Max">max value</param>
        /// <param name="Min">min vlaue</param>
        /// <returns>The desired seconds</returns>
        private TimeSpan Calc_The_desired_Seconds(int Pos, int Max, int Min)
        {
            float Percantage = Pos / (float)(Max - Min + 1);
            return TimeSpan.FromSeconds(Percantage * (Max - Min));
        }
        /// <summary>
        /// Reset The Current Time Audio To Zero and Total Time Property To Original Audio Total Time
        /// </summary>
        public void Reset()
        {
            if (reader != null)
            {
                reader.CurrentTime = TimeSpan.Zero;
                Total_Time = reader.TotalTime;
            }
        }
        private void Load_Data()
        {
            reader = new AudioFileReader(Path);
            Total_Time = reader.TotalTime;
        }
        private void Stop()
        {
            wave?.Stop();
            reader?.Dispose();
        }

        public void Play()
        {
            try
            {
                Stop();
                
                Load_Data();
                wave = new WaveOutEvent();
                wave?.Init(reader);
                wave?.Play();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public void Pause()
        {
            try
            {
                if (wave != null && wave.PlaybackState == PlaybackState.Playing)
                {
                    wave?.Pause();
                    pausedPosition = reader.Position;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Resume()
        {
            try
            {
                if (wave != null && wave.PlaybackState == PlaybackState.Paused)
                    wave?.Play();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Get_Time() => $"{Total_Time.Hours:00}:{Total_Time.Minutes:00}:{Total_Time.Seconds:00}";
        /// <summary>
        /// Mines From Total Time Every Seconds The Timer You Initilazition Works
        /// </summary>
        public void Tick()
        {
            Total_Time = Total_Time.Add(TimeSpan.FromSeconds(-1));
            Current_Time = reader.CurrentTime;
        }
        public PlaybackState Get_State() => wave.PlaybackState;
        /// <summary>
        /// Caculate desired time by Calc_The_desired_Seconds Method 
        /// and Calc The Total Time by Substract Original Time from Current Time  <code></code>
        /// Note : Total time property used for current total so you have to substract from original total time
        /// </summary>
        public void PlayFrom(int Sec, int Max, int Min)
        {
            reader.CurrentTime = Current_Time = Calc_The_desired_Seconds(Sec, Max, Min);
            Total_Time = reader.TotalTime - Current_Time;
        }
        public void AddSeconds(int Sec)
        {
            TimeSpan New_Current_Time = reader.CurrentTime + TimeSpan.FromSeconds(Sec);

            if (New_Current_Time > reader.TotalTime)
                New_Current_Time = reader.TotalTime;

            else if (New_Current_Time < TimeSpan.Zero)
                New_Current_Time = TimeSpan.Zero;

            reader.CurrentTime = Current_Time = New_Current_Time;
            Total_Time -= TimeSpan.FromSeconds(Sec);
        }
        public void Mute() => Volume = 0;
    }
}
