namespace Countdown
{
    partial class CountdownWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.restart_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.duration_txt = new System.Windows.Forms.TextBox();
            this.format_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.durationValid_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeLeft_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Countdown";
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(140, 227);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 32);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(227, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // restart_btn
            // 
            this.restart_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart_btn.Location = new System.Drawing.Point(170, 267);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(96, 32);
            this.restart_btn.TabIndex = 3;
            this.restart_btn.Text = "Restart";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Duration:";
            // 
            // duration_txt
            // 
            this.duration_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration_txt.Location = new System.Drawing.Point(170, 103);
            this.duration_txt.Name = "duration_txt";
            this.duration_txt.Size = new System.Drawing.Size(128, 32);
            this.duration_txt.TabIndex = 5;
            this.duration_txt.Leave += new System.EventHandler(this.duration_txt_Leave);
            // 
            // format_txt
            // 
            this.format_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.format_txt.Location = new System.Drawing.Point(170, 156);
            this.format_txt.Name = "format_txt";
            this.format_txt.Size = new System.Drawing.Size(128, 32);
            this.format_txt.TabIndex = 7;
            this.format_txt.Leave += new System.EventHandler(this.format_txt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Format:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Usage: HH:MM:SS";
            // 
            // durationValid_lbl
            // 
            this.durationValid_lbl.AutoSize = true;
            this.durationValid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationValid_lbl.ForeColor = System.Drawing.Color.Red;
            this.durationValid_lbl.Location = new System.Drawing.Point(304, 113);
            this.durationValid_lbl.Name = "durationValid_lbl";
            this.durationValid_lbl.Size = new System.Drawing.Size(141, 20);
            this.durationValid_lbl.TabIndex = 9;
            this.durationValid_lbl.Text = "** Format incorrect";
            this.durationValid_lbl.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Time Left:";
            // 
            // timeLeft_lbl
            // 
            this.timeLeft_lbl.AutoSize = true;
            this.timeLeft_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeft_lbl.Location = new System.Drawing.Point(165, 317);
            this.timeLeft_lbl.Name = "timeLeft_lbl";
            this.timeLeft_lbl.Size = new System.Drawing.Size(0, 26);
            this.timeLeft_lbl.TabIndex = 11;
            // 
            // CountdownWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 361);
            this.Controls.Add(this.timeLeft_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.durationValid_lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.format_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.duration_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.restart_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CountdownWindow";
            this.ShowIcon = false;
            this.Text = "Countdown";
            this.Load += new System.EventHandler(this.Coundown_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox duration_txt;
        private System.Windows.Forms.TextBox format_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label durationValid_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label timeLeft_lbl;
    }
}

