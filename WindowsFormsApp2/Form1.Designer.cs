namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.oiVremena = new System.Windows.Forms.TextBox();
            this.oiMinute = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oiSekunde = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLap = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // oiVremena
            // 
            this.oiVremena.Location = new System.Drawing.Point(556, 66);
            this.oiVremena.Multiline = true;
            this.oiVremena.Name = "oiVremena";
            this.oiVremena.Size = new System.Drawing.Size(100, 190);
            this.oiVremena.TabIndex = 0;
            // 
            // oiMinute
            // 
            this.oiMinute.AutoSize = true;
            this.oiMinute.Location = new System.Drawing.Point(354, 66);
            this.oiMinute.Name = "oiMinute";
            this.oiMinute.Size = new System.Drawing.Size(13, 13);
            this.oiMinute.TabIndex = 1;
            this.oiMinute.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // oiSekunde
            // 
            this.oiSekunde.AutoSize = true;
            this.oiSekunde.Location = new System.Drawing.Point(389, 65);
            this.oiSekunde.Name = "oiSekunde";
            this.oiSekunde.Size = new System.Drawing.Size(13, 13);
            this.oiSekunde.TabIndex = 3;
            this.oiSekunde.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(340, 107);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLap
            // 
            this.btnLap.Location = new System.Drawing.Point(340, 136);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(75, 23);
            this.btnLap.TabIndex = 5;
            this.btnLap.Text = "Lap";
            this.btnLap.UseVisualStyleBackColor = true;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(340, 165);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnLap);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.oiSekunde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oiMinute);
            this.Controls.Add(this.oiVremena);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oiVremena;
        private System.Windows.Forms.Label oiMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label oiSekunde;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLap;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
    }
}

