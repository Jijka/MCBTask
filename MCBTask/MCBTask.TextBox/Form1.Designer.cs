using System.Windows.Forms;
using MCBTask.TextBox.Properties;

namespace MCBTask.TextBox
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
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenFile = new System.Windows.Forms.Button();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Encodings = new System.Windows.Forms.ComboBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(178, 11);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.ReadOnly = true;
            this.FileNameBox.Size = new System.Drawing.Size(311, 20);
            this.FileNameBox.TabIndex = 0;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            this.OpenFileDialog.Filter = "TxtFiles|*.txt";
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(495, 9);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 1;
            this.OpenFile.Text = "Открыть";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(12, 55);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(558, 279);
            this.RichTextBox.TabIndex = 2;
            this.RichTextBox.Text = "";
            // 
            // Encodings
            // 
            this.Encodings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Encodings.FormattingEnabled = true;
            this.Encodings.Location = new System.Drawing.Point(12, 11);
            this.Encodings.Name = "Encodings";
            this.Encodings.Size = new System.Drawing.Size(160, 21);
            this.Encodings.TabIndex = 4;
            Encodings.Items.AddRange(Settings.Default.EncodingsList);
            Encodings.SelectedIndex = 0;
            this.Encodings.SelectedValueChanged += new System.EventHandler(this.Encodings_SelectedValueChanged);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 38);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(558, 11);
            this.ProgressBar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 346);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Encodings);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.FileNameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

            this._bw.WorkerReportsProgress = true;

        }

        #endregion

        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.ComboBox Encodings;
        private ProgressBar ProgressBar;
    }
}

