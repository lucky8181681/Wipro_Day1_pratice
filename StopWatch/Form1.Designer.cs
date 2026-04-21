namespace StopWatch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStop = new Button();
            btnSave = new Button();
            txtHours = new TextBox();
            txtMinutes = new TextBox();
            txtSeconds = new TextBox();
            btnStart = new Button();
            SuspendLayout();
            // 
            // btnStop
            // 
            btnStop.BackColor = SystemColors.ActiveCaption;
            btnStop.Location = new Point(273, 150);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 1;
            btnStop.Text = "STOP";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(413, 150);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtHours
            // 
            txtHours.BackColor = SystemColors.Info;
            txtHours.Location = new Point(113, 94);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(125, 27);
            txtHours.TabIndex = 3;
            txtHours.Text = "00";
            txtHours.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMinutes
            // 
            txtMinutes.BackColor = SystemColors.Info;
            txtMinutes.Location = new Point(261, 94);
            txtMinutes.Name = "txtMinutes";
            txtMinutes.Size = new Size(125, 27);
            txtMinutes.TabIndex = 4;
            txtMinutes.Text = "00";
            txtMinutes.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSeconds
            // 
            txtSeconds.BackColor = SystemColors.Info;
            txtSeconds.Location = new Point(413, 94);
            txtSeconds.Name = "txtSeconds";
            txtSeconds.Size = new Size(125, 27);
            txtSeconds.TabIndex = 5;
            txtSeconds.Text = "00";
            txtSeconds.TextAlign = HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.ActiveCaption;
            btnStart.Location = new Point(144, 150);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 6;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(txtSeconds);
            Controls.Add(txtMinutes);
            Controls.Add(txtHours);
            Controls.Add(btnSave);
            Controls.Add(btnStop);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnStart;
        private Button btnStop;
        private Button btnSave;
        private TextBox txtHours;
        private TextBox txtMinutes;
        private TextBox txtSeconds;
        private Button button4;
    }
}
