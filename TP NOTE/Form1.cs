using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.IO;
using System.Windows.Forms;

namespace TP_NOTE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BlockAlignReductionStream song = null;
        private DirectSoundOut output = null;
        private WaveFileWriter RecordedAudioWriter = null;
        private WasapiLoopbackCapture CaptureInstance = null;
        //initialisation de l'emplacement
        String Emplacement = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        //initialisation du nom de fichier d'enregistrement
        String RecordFileName = "record";

        private void openaudio_Click(object sender, EventArgs e)
        {
            //ouverture d'une fenetre de recherche avec les filtre MP3 et WAV
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Audio File (*.mp3;*.wav)|*.mp3;*.wav;";
            open.Multiselect = true;
            if (open.ShowDialog() != DialogResult.OK) return;
            for (int i = 0; i < open.FileNames.Length; i++)
            {
                List_Son.Items.Add(new AvoirPath { Name = Path.GetFileName(open.FileNames[i].ToString()), Path = open.FileNames[i].ToString() });
            }
        }

        private void Lecture_Click(object sender, EventArgs e)
        {
            //appel de la fonction Lecture / Pause
            Lecture_du_son();
        }

        private void Lecture_du_son()
        {

            if (output != null)
            {
                //Si on appuie sur la touche lecture => pause et pause => lecture
                if (output.PlaybackState == PlaybackState.Playing)
                {
                    output.Pause();
                }
                else if (output.PlaybackState == PlaybackState.Paused)
                {
                    output.Play();
                }
            }
        }
        private void STOP_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Dispose()
        {
            if (output != null)
            {
                //arreter la musique
                output.Stop();
                output.Dispose();
                song.Dispose();
                song = null;
                output = null;
            }
        }

        private void RECORD_Click(object sender, EventArgs e)
        {

            int incrementation = 0;
            string output = Emplacement + "\\" + RecordFileName + ".wav";
            while (File.Exists(output))
            {
                incrementation = incrementation + 1;
                output = Emplacement + "\\" + RecordFileName + incrementation.ToString() + ".wav";
            }



            //ecriture du fichier en WAV
            CaptureInstance = new WasapiLoopbackCapture();
            RecordedAudioWriter = new WaveFileWriter(output, CaptureInstance.WaveFormat);
            CaptureInstance.DataAvailable += (s, a) =>
            {
                RecordedAudioWriter.Write(a.Buffer, 0, a.BytesRecorded);
            };

            //arret de l'ecriture
            CaptureInstance.RecordingStopped += (s, a) =>
            {
                RecordedAudioWriter.Dispose();
                RecordedAudioWriter = null;
                CaptureInstance.Dispose();
            };

            //Afficher le boutton stop
            RECORD.Visible = false;
            RECORDSTOP.Visible = true;

            // Commencer l'enregistrement
            CaptureInstance.StartRecording();
            List_Son.Items.Add(new AvoirPath { Name = Path.GetFileName(output), Path = output });
        }

        private void RECORDSTOP_Click(object sender, EventArgs e)
        {

            //Arreter la capture
            CaptureInstance.StopRecording();

            //Afficher le boutton jouer
            RECORD.Visible = true;
            RECORDSTOP.Visible = false;

        }

        private void List_Son_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (List_Son.SelectedItem != null)
            {
                // Avoir l'item selectionné
                string itemSelectionne = ((AvoirPath)List_Son.SelectedItem).Path;
                Dispose();
                //condition si c'est MP3 on le convertit
                if (itemSelectionne.EndsWith(".mp3"))
                {
                    WaveStream convert = WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(itemSelectionne));
                    song = new BlockAlignReductionStream(convert);
                }
                else if (itemSelectionne.EndsWith(".wav"))
                {
                    WaveStream convert = new WaveChannel32(new WaveFileReader(itemSelectionne));
                    song = new BlockAlignReductionStream(convert);
                }

                output = new DirectSoundOut();
                //initialisation du son
                output.Init(song);
                output.Play();
            }
        }

        private void ChoosePath_Click(object sender, EventArgs e)
        {
            //ouvre un fenetre pour choisir son dossier
            FolderBrowserDialog open = new FolderBrowserDialog();
            if (DialogResult.OK == open.ShowDialog())
            {
                string dir = open.SelectedPath;
                path.Text = dir;
                Emplacement = dir;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            DesignSong.Value = (int)(Math.Round(devices.AudioMeterInformation.MasterPeakValue * 15));
            DesignSong2.Value = (int)(Math.Round(devices.AudioMeterInformation.MasterPeakValue * 30));
            DesignSong3.Value = (int)(Math.Round(devices.AudioMeterInformation.MasterPeakValue * 60));
            DesignSong4.Value = (int)(Math.Round(devices.AudioMeterInformation.MasterPeakValue * 100));
            DesignSong5.Value = (int)(Math.Round(devices.AudioMeterInformation.MasterPeakValue * 60));
            DesignSong6.Value = (int)(Math.Round(devices.AudioMeterInformation.MasterPeakValue * 30));
            DesignSong7.Value = (int)(Math.Round(devices.AudioMeterInformation.MasterPeakValue * 15));

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //recuperation evenement touche Espace
            if (e.KeyChar == 'p')
            {
                // appel de la fonction Lecture / Pause
                Lecture_du_son();
            }
        }
    }
}
