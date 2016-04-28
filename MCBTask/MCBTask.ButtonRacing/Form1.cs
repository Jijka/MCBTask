using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCBTask.ButtonRacing
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cts;
        private CancellationToken _token;
        public Form1()
        {
            InitializeComponent();
            _cts = new CancellationTokenSource();
            _token = _cts.Token;
        }

        private void StartRaceButon_Click(object sender, EventArgs e)
        {
            var task0 = Task.Factory.StartNew(() => GoTask(Racer0), _token);
            var task1 = Task.Factory.StartNew(() => GoTask(Racer1), _token);
            var task2 = Task.Factory.StartNew(() => GoTask(Racer2), _token);
            var task3 = Task.Factory.StartNew(() => GoTask(Racer3), _token);
        }

        private void GoTask(Control button)
        {
            while (button.Location.X + button.Width < Width)
            {
                var rand = new Random();
                button.Invoke((Action)(() =>
                {
                    var rnd = rand.Next(1, 50) / 4;
                    Debug.WriteLine(button.Name + ":" + rnd);
                    button.Location = new Point(button.Location.X + rnd, button.Location.Y);
                }));
                Thread.CurrentThread.Join(70);
            }
        }
        private void Go(Control button)
        {
            ThreadPool.QueueUserWorkItem(sender =>
            {

                var btn = (Button)sender;
                while (btn.Location.X + btn.Width < Width && !_cts.Token.IsCancellationRequested)
                {
                    var rand = new Random();
                    btn.Invoke((Action)(() =>
                    {
                        var rnd = rand.Next(1, 50) / 5;
                        Debug.WriteLine(button.Name + ":" + rnd);
                        btn.Location = new Point(btn.Location.X + rnd, btn.Location.Y);
                    }));
                    Thread.CurrentThread.Join(70);
                }
            }, button);
        }

        private void ResetRaceButton_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
            Racer0.Location = new Point(12, Racer0.Location.Y);
            Racer1.Location = new Point(12, Racer1.Location.Y);
            Racer2.Location = new Point(12, Racer2.Location.Y);
            Racer3.Location = new Point(12, Racer3.Location.Y);
        }


        private static void Reset(Button button)
        {
            ThreadPool.QueueUserWorkItem(sender =>
            {
                var btn = (Button)sender;
                btn.Invoke((Action)(() =>
                {
                    btn.Location = new Point(12, btn.Location.Y);
                }));
            }, button);
        }
    }
}
