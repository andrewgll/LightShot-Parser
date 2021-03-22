
namespace LightShootParser
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ThreadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PathButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Go_button = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ScreenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ThreadNumericUpDown
            // 
            this.ThreadNumericUpDown.Location = new System.Drawing.Point(12, 83);
            this.ThreadNumericUpDown.Name = "ThreadNumericUpDown";
            this.ThreadNumericUpDown.Size = new System.Drawing.Size(478, 31);
            this.ThreadNumericUpDown.TabIndex = 0;
            this.ThreadNumericUpDown.UseWaitCursor = true;
            this.ThreadNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of threads: (More = faster, but can be banned from server)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time limit in seconds(0 = infinite work)";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(12, 175);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(261, 31);
            this.TimeTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Change download path";
            // 
            // PathButton
            // 
            this.PathButton.Location = new System.Drawing.Point(12, 273);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(233, 48);
            this.PathButton.TabIndex = 6;
            this.PathButton.Text = "Path";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 389);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(569, 31);
            this.progressBar1.TabIndex = 7;
            // 
            // Go_button
            // 
            this.Go_button.Location = new System.Drawing.Point(257, 273);
            this.Go_button.Name = "Go_button";
            this.Go_button.Size = new System.Drawing.Size(233, 48);
            this.Go_button.TabIndex = 9;
            this.Go_button.Text = "Okay, GO!";
            this.Go_button.UseVisualStyleBackColor = true;
            this.Go_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // ScreenLabel
            // 
            this.ScreenLabel.AutoSize = true;
            this.ScreenLabel.Location = new System.Drawing.Point(7, 352);
            this.ScreenLabel.Name = "ScreenLabel";
            this.ScreenLabel.Size = new System.Drawing.Size(0, 25);
            this.ScreenLabel.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(676, 629);
            this.Controls.Add(this.ScreenLabel);
            this.Controls.Add(this.Go_button);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.PathButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThreadNumericUpDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.Text = "LightShot Parser by AndrewGL";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ThreadNumericUpDown;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button PathButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Go_button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label ScreenLabel;
    }
}

