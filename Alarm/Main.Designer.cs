
namespace Alarm
{
    partial class Main
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
            this.btn_delay = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.lbl_now = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.txtbx_alarm = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_delay
            // 
            this.btn_delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_delay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delay.ForeColor = System.Drawing.Color.Transparent;
            this.btn_delay.Location = new System.Drawing.Point(354, 176);
            this.btn_delay.Name = "btn_delay";
            this.btn_delay.Size = new System.Drawing.Size(109, 44);
            this.btn_delay.TabIndex = 1;
            this.btn_delay.Text = "Delay";
            this.btn_delay.UseVisualStyleBackColor = false;
            this.btn_delay.Click += new System.EventHandler(this.btn_delay_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.Color.Transparent;
            this.btn_stop.Location = new System.Drawing.Point(354, 226);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(109, 44);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_set
            // 
            this.btn_set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set.ForeColor = System.Drawing.Color.White;
            this.btn_set.Location = new System.Drawing.Point(354, 126);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(109, 44);
            this.btn_set.TabIndex = 3;
            this.btn_set.Text = "Set Alarm";
            this.btn_set.UseVisualStyleBackColor = false;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // lbl_now
            // 
            this.lbl_now.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_now.Location = new System.Drawing.Point(291, 9);
            this.lbl_now.Name = "lbl_now";
            this.lbl_now.Size = new System.Drawing.Size(236, 78);
            this.lbl_now.TabIndex = 4;
            this.lbl_now.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_time
            // 
            this.lbl_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_time.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(291, 290);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(232, 76);
            this.lbl_time.TabIndex = 5;
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_time.Click += new System.EventHandler(this.lbl_time_Click);
            // 
            // txtbx_alarm
            // 
            this.txtbx_alarm.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_alarm.Location = new System.Drawing.Point(324, 90);
            this.txtbx_alarm.Name = "txtbx_alarm";
            this.txtbx_alarm.Size = new System.Drawing.Size(182, 30);
            this.txtbx_alarm.TabIndex = 6;
            this.txtbx_alarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbx_alarm.TextChanged += new System.EventHandler(this.txtbx_alarm_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::Alarm.Properties.Resources.alarmimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 375);
            this.Controls.Add(this.txtbx_alarm);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_now);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_delay);
            this.Name = "Main";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_delay;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Label lbl_now;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.TextBox txtbx_alarm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

