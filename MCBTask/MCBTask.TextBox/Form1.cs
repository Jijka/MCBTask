using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MCBTask.TextBox
{
    public partial class Form1 : Form
    {
        private readonly BackgroundWorker _bw;

        public Form1()
        {
            _bw = new BackgroundWorker();
            InitializeComponent();
            _bw.DoWork += _bw_DoWork;
            _bw.RunWorkerCompleted += _bw_RunWorkerCompleted;
            _bw.ProgressChanged += _bw_ProgressChanged;
        }

        private void _bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Encodings.Enabled = true;
            OpenFile.Enabled = true;
            // Finally, handle the case where the operation 
            // succeeded.
            RichTextBox.Text = e.Result.ToString();
        }

        // This event handler is where the actual,
        // potentially time-consuming work is done.
        private void _bw_DoWork(object sender,
            DoWorkEventArgs e)
        {
            // Assign the result of the computation
            // to the Result property of the DoWorkEventArgs
            // object. This is will be available to the 
            // RunWorkerCompleted eventhandler.
            ReadFile(FileNameBox.Text, _bw, e);
        }

        // This event handler updates the progress bar.
        private void _bw_ProgressChanged(object sender,
            ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
        }



        private void OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = "c:\\",
                    Filter = @"txt files (*.txt)|*.txt",
                    FilterIndex = 1,
                    RestoreDirectory = true
                })
                {
                    if (openFileDialog.ShowDialog() != DialogResult.OK) return;
                    FileNameBox.Text = openFileDialog.FileName;

                    if (_bw.IsBusy) return;
                    // Start the asynchronous operation.
                    _bw.RunWorkerAsync(Encodings.SelectedItem);
                    Encodings.Enabled = false;
                    OpenFile.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        private static void ReadFile(string fileName, BackgroundWorker bw, DoWorkEventArgs e)
        {
            bw.ReportProgress(0);
            using (var sr = new StreamReader(fileName, Encoding.GetEncoding((string)e.Argument)))
            {
                e.Result = sr.ReadToEnd();
            }
            bw.ReportProgress(100);
        }

        private void Encodings_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(FileNameBox.Text)) return;
                if (_bw.IsBusy) return;
                // Start the asynchronous operation.
                _bw.RunWorkerAsync(Encodings.SelectedItem);
                Encodings.Enabled = false;
                OpenFile.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }
    }
}

