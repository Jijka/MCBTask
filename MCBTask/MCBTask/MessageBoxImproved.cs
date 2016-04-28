using System;
using System.Windows.Forms;

namespace MCBTask
{
    public sealed partial class MessageBoxImproved : Form
    {
        private int _seconds;

        public MessageBoxImproved(string messageText, string caption, int seconds)
        {
            _seconds = seconds;
            InitializeComponent(messageText, caption, _seconds);
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_seconds > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                _seconds -= 1;
                StopButton.Text = $"СТОП (осталось {_seconds} сек.)";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                Close();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopButton.Text = @"СТОП";
            timer1.Stop();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
