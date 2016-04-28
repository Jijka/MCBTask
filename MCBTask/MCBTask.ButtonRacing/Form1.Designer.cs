namespace MCBTask.ButtonRacing
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.Racer0 = new System.Windows.Forms.Button();
            this.Racer1 = new System.Windows.Forms.Button();
            this.Racer2 = new System.Windows.Forms.Button();
            this.Racer3 = new System.Windows.Forms.Button();
            this.StartRaceButon = new System.Windows.Forms.Button();
            this.ResetRaceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Racer0
            // 
            this.Racer0.Location = new System.Drawing.Point(12, 12);
            this.Racer0.Name = "Racer0";
            this.Racer0.Size = new System.Drawing.Size(55, 55);
            this.Racer0.TabIndex = 0;
            this.Racer0.UseVisualStyleBackColor = true;
            // 
            // Racer1
            // 
            this.Racer1.Location = new System.Drawing.Point(12, 73);
            this.Racer1.Name = "Racer1";
            this.Racer1.Size = new System.Drawing.Size(55, 55);
            this.Racer1.TabIndex = 1;
            this.Racer1.UseVisualStyleBackColor = true;
            // 
            // Racer2
            // 
            this.Racer2.Location = new System.Drawing.Point(12, 134);
            this.Racer2.Name = "Racer2";
            this.Racer2.Size = new System.Drawing.Size(55, 55);
            this.Racer2.TabIndex = 2;
            this.Racer2.UseVisualStyleBackColor = true;
            // 
            // Racer3
            // 
            this.Racer3.Location = new System.Drawing.Point(12, 195);
            this.Racer3.Name = "Racer3";
            this.Racer3.Size = new System.Drawing.Size(55, 55);
            this.Racer3.TabIndex = 3;
            this.Racer3.UseVisualStyleBackColor = true;
            // 
            // StartRaceButon
            // 
            this.StartRaceButon.Location = new System.Drawing.Point(12, 295);
            this.StartRaceButon.Name = "StartRaceButon";
            this.StartRaceButon.Size = new System.Drawing.Size(75, 23);
            this.StartRaceButon.TabIndex = 4;
            this.StartRaceButon.Text = "Старт";
            this.StartRaceButon.UseVisualStyleBackColor = true;
            this.StartRaceButon.Click += new System.EventHandler(this.StartRaceButon_Click);
            // 
            // ResetRaceButton
            // 
            this.ResetRaceButton.Location = new System.Drawing.Point(93, 295);
            this.ResetRaceButton.Name = "ResetRaceButton";
            this.ResetRaceButton.Size = new System.Drawing.Size(75, 23);
            this.ResetRaceButton.TabIndex = 5;
            this.ResetRaceButton.Text = "Сброс";
            this.ResetRaceButton.UseVisualStyleBackColor = true;
            this.ResetRaceButton.Click += new System.EventHandler(this.ResetRaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 357);
            this.Controls.Add(this.ResetRaceButton);
            this.Controls.Add(this.StartRaceButon);
            this.Controls.Add(this.Racer3);
            this.Controls.Add(this.Racer2);
            this.Controls.Add(this.Racer1);
            this.Controls.Add(this.Racer0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Racer0;
        private System.Windows.Forms.Button Racer1;
        private System.Windows.Forms.Button Racer2;
        private System.Windows.Forms.Button Racer3;
        private System.Windows.Forms.Button StartRaceButon;
        private System.Windows.Forms.Button ResetRaceButton;
    }
}

