namespace MCBTask.MessageBox
{
    sealed partial class MessageBoxImproved
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(string messageText, string caption, int _seconds)
        {
            components = new System.ComponentModel.Container();
            // 
            // OKButton
            // 
            OKButton = new System.Windows.Forms.Button
            {
                Location = new System.Drawing.Point(12, 104),
                Name = "OKButton",
                Size = new System.Drawing.Size(75, 23),
                TabIndex = 0,
                Text = "OK",
                UseVisualStyleBackColor = true
            };
            OKButton.Click += new System.EventHandler(OKButton_Click);
            // 
            // StopButton
            // 
            StopButton = new System.Windows.Forms.Button
            {
                Location = new System.Drawing.Point(170, 104),
                Name = "StopButton",
                Size = new System.Drawing.Size(150, 23),
                TabIndex = 1,
                Text = $"СТОП (осталось {_seconds} сек.)",
                UseVisualStyleBackColor = true
            };
            StopButton.Click += new System.EventHandler(StopButton_Click);
            // 
            // timer1
            // 
            timer1 = new System.Windows.Forms.Timer(container: components) { Interval = 1000 };
            timer1.Tick += new System.EventHandler(timer1_Tick);


            // 
            // MessageBoxText
            // 
            MessageBoxText = new System.Windows.Forms.Label
            {
                Name = messageText,
                Location = new System.Drawing.Point(12, 9),
                AutoSize = true,
                Size = new System.Drawing.Size(0, 13),
                TabIndex = 2,
                Text = messageText
            };
            SuspendLayout();
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(332, 139);
            Controls.Add(MessageBoxText);
            Controls.Add(StopButton);
            Controls.Add(OKButton);
            Name = "MessageBoxImproved";
            Text = caption;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label MessageBoxText;
    }
}

