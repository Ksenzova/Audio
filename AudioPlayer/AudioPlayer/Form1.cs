using System;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;
using System.IO;

namespace AudioPlayer
{
    public enum Format
    {
        wav = 1,
        mp3 = 2,
        flac = 3,
        ogg = 4
    }
    public partial class home : Form
    {
        private Format format = Format.wav;
        private double rate = 8;
        private int bit = 8;
        private bool chanels = true;


        private string fileName;
        private string outputFile;
        public home()
        {
            InitializeComponent();
        }
        private WaveFileReader wave = null;
        private DirectSoundOut output = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            
        }


        private void loadWAVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Audio File (*.wav)|*.wav";
            if (open.ShowDialog() != DialogResult.OK) return;
            DisposeWave();
            wave = new WaveFileReader(open.FileName);
            sourceFileTexBox.Text = open.FileName;
            fileName = open.FileName;
            output = new DirectSoundOut();
            output.Init(new WaveChannel32(wave));
            output.Play();
            button2.Enabled = true;
            waveViewer1.WaveStream = new WaveFileReader(open.FileName);
            waveViewer1.Width = 8000;
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                    output.Pause();
                else if (output.PlaybackState == PlaybackState.Paused)
                    output.Play();
            }
        }


        private void DisposeWave()
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                    output.Stop();
                output.Dispose();
                output = null;
            }
            if (wave != null)
            {
                wave.Dispose();
                wave = null;
            }
        }
        private void home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
        }

        private void Convert(int rate,int bits,int channels)
        {
            using (var reader = new WaveFileReader(fileName))
            {             
                var newFormat = new WaveFormat(rate*1000,bit,channels);
                using (var conversionStream = new WaveFormatConversionStream(newFormat, reader))
                {
                    WaveFileWriter.CreateWaveFile("output.wav", conversionStream);
                }
            }
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            Convert(rate,bit,chanels);
            waveViewer3.WaveStream = new WaveFileReader("output.wav");
        }

        private void mp3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            format = Format.mp3;
        }

        private void flacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            format = Format.flac;
        }

        private void oggToolStripMenuItem_Click(object sender, EventArgs e)
        {
            format = Format.ogg;
        }

        private void wavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            format = Format.wav;
        }

	}
}
