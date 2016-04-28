using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCBTask.ButtonRacing
{
    public partial class Form1 : Form
    {
        private readonly CancellationTokenSource _cts;
        private readonly CancellationToken _token;

        private readonly List<Button> _buttons;
        private Task[] _tasks;

        public Form1()
        {
            InitializeComponent();
            _cts = new CancellationTokenSource();
            _token = _cts.Token;
            _buttons = new List<Button> { Racer0, Racer1, Racer2, Racer3 };
        }

        private void StartRaceButon_Click(object sender, EventArgs e)
        {
            var index = 0;
            _tasks = new Task[_buttons.Count];
            foreach (var btn in _buttons)
            {
                _tasks[index] = Task.Factory.StartNew(() => GoTask(btn), _token);
                ++index;
            }
        }

        private void GoTask(Control button)
        {
            var x = button.Location.X;
            var width = button.Width;
            while (x + width < Width)
            {
                var rand = new Random();
                x += rand.Next(1, 50) / 4;
                button.Invoke((Action)(() =>
                {
                    var rnd = rand.Next(1, 50) / 4;
                    Debug.WriteLine(button.Name + ":" + rnd);
                    button.Location = new Point(x + rnd, button.Location.Y);
                }));
                Thread.CurrentThread.Join(70);
            }
        }

        private void ResetRaceButton_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
            Task.WaitAll(_tasks);
            foreach (var button in _buttons)
            {
                button.Location = new Point(12, button.Location.Y);
            }
        }
    }
}
