namespace calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.top_scrn_sign = new System.Windows.Forms.Label();
            this.top_scrn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Date_now = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.Label();
            this.decimal_point = new System.Windows.Forms.Button();
            this.button00 = new System.Windows.Forms.Button();
            this.button01 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button03 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button04 = new System.Windows.Forms.Button();
            this.button05 = new System.Windows.Forms.Button();
            this.button06 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.button07 = new System.Windows.Forms.Button();
            this.button08 = new System.Windows.Forms.Button();
            this.button09 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.clear_screen = new System.Windows.Forms.Button();
            this.off = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.calc_clock = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.top_scrn_sign);
            this.panel1.Controls.Add(this.top_scrn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.Date_now);
            this.panel1.Controls.Add(this.clock);
            this.panel1.Controls.Add(this.screen);
            this.panel1.Controls.Add(this.decimal_point);
            this.panel1.Controls.Add(this.button00);
            this.panel1.Controls.Add(this.button01);
            this.panel1.Controls.Add(this.button02);
            this.panel1.Controls.Add(this.button03);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.button04);
            this.panel1.Controls.Add(this.button05);
            this.panel1.Controls.Add(this.button06);
            this.panel1.Controls.Add(this.minus);
            this.panel1.Controls.Add(this.button07);
            this.panel1.Controls.Add(this.button08);
            this.panel1.Controls.Add(this.button09);
            this.panel1.Controls.Add(this.multiply);
            this.panel1.Controls.Add(this.clear_screen);
            this.panel1.Controls.Add(this.off);
            this.panel1.Controls.Add(this.equals);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 448);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // top_scrn_sign
            // 
            this.top_scrn_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_scrn_sign.Location = new System.Drawing.Point(298, 18);
            this.top_scrn_sign.Name = "top_scrn_sign";
            this.top_scrn_sign.Size = new System.Drawing.Size(31, 23);
            this.top_scrn_sign.TabIndex = 27;
            this.top_scrn_sign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // top_scrn
            // 
            this.top_scrn.Location = new System.Drawing.Point(5, 18);
            this.top_scrn.Name = "top_scrn";
            this.top_scrn.Size = new System.Drawing.Size(297, 23);
            this.top_scrn.TabIndex = 26;
            this.top_scrn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.top_scrn.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(5, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 51);
            this.button1.TabIndex = 25;
            this.button1.Text = "M+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(89, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 51);
            this.button2.TabIndex = 24;
            this.button2.Text = "M-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(171, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 51);
            this.button3.TabIndex = 23;
            this.button3.Text = "%";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(253, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 51);
            this.button4.TabIndex = 22;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Date_now
            // 
            this.Date_now.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Date_now.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Date_now.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_now.ForeColor = System.Drawing.Color.White;
            this.Date_now.Location = new System.Drawing.Point(7, 106);
            this.Date_now.Name = "Date_now";
            this.Date_now.Size = new System.Drawing.Size(158, 23);
            this.Date_now.TabIndex = 21;
            this.Date_now.Text = "label1";
            this.Date_now.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clock
            // 
            this.clock.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.clock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clock.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock.ForeColor = System.Drawing.Color.White;
            this.clock.Location = new System.Drawing.Point(7, 129);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(158, 31);
            this.clock.TabIndex = 20;
            this.clock.Text = "label1";
            this.clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clock.Click += new System.EventHandler(this.clock_Click);
            // 
            // screen
            // 
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screen.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screen.Location = new System.Drawing.Point(5, 41);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(324, 54);
            this.screen.TabIndex = 19;
            this.screen.Text = "0";
            this.screen.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.screen.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.screen_PreviewKeyDown);
            // 
            // decimal_point
            // 
            this.decimal_point.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.decimal_point.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decimal_point.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimal_point.Location = new System.Drawing.Point(171, 391);
            this.decimal_point.Name = "decimal_point";
            this.decimal_point.Size = new System.Drawing.Size(76, 51);
            this.decimal_point.TabIndex = 18;
            this.decimal_point.Text = ".";
            this.decimal_point.UseVisualStyleBackColor = false;
            this.decimal_point.Click += new System.EventHandler(this.button19_Click);
            // 
            // button00
            // 
            this.button00.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button00.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button00.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button00.Location = new System.Drawing.Point(5, 391);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(160, 51);
            this.button00.TabIndex = 17;
            this.button00.Text = "0";
            this.button00.UseVisualStyleBackColor = false;
            this.button00.Click += new System.EventHandler(this.button00_Click);
            // 
            // button01
            // 
            this.button01.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button01.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button01.Location = new System.Drawing.Point(5, 334);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(76, 51);
            this.button01.TabIndex = 16;
            this.button01.Text = "1";
            this.button01.UseVisualStyleBackColor = false;
            this.button01.Click += new System.EventHandler(this.button01_Click);
            // 
            // button02
            // 
            this.button02.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button02.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button02.Location = new System.Drawing.Point(89, 334);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(76, 51);
            this.button02.TabIndex = 15;
            this.button02.Text = "2";
            this.button02.UseVisualStyleBackColor = false;
            this.button02.Click += new System.EventHandler(this.button02_Click);
            // 
            // button03
            // 
            this.button03.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button03.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button03.Location = new System.Drawing.Point(171, 334);
            this.button03.Name = "button03";
            this.button03.Size = new System.Drawing.Size(76, 51);
            this.button03.TabIndex = 14;
            this.button03.Text = "3";
            this.button03.UseVisualStyleBackColor = false;
            this.button03.Click += new System.EventHandler(this.button03_Click);
            // 
            // add
            // 
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(253, 334);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(76, 51);
            this.add.TabIndex = 13;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button04
            // 
            this.button04.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button04.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button04.Location = new System.Drawing.Point(5, 277);
            this.button04.Name = "button04";
            this.button04.Size = new System.Drawing.Size(76, 51);
            this.button04.TabIndex = 12;
            this.button04.Text = "4";
            this.button04.UseVisualStyleBackColor = false;
            this.button04.Click += new System.EventHandler(this.button04_Click);
            // 
            // button05
            // 
            this.button05.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button05.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button05.Location = new System.Drawing.Point(89, 277);
            this.button05.Name = "button05";
            this.button05.Size = new System.Drawing.Size(76, 51);
            this.button05.TabIndex = 11;
            this.button05.Text = "5";
            this.button05.UseVisualStyleBackColor = false;
            this.button05.Click += new System.EventHandler(this.button05_Click);
            // 
            // button06
            // 
            this.button06.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button06.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button06.Location = new System.Drawing.Point(171, 277);
            this.button06.Name = "button06";
            this.button06.Size = new System.Drawing.Size(76, 51);
            this.button06.TabIndex = 10;
            this.button06.Text = "6";
            this.button06.UseVisualStyleBackColor = false;
            this.button06.Click += new System.EventHandler(this.button06_Click);
            // 
            // minus
            // 
            this.minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(253, 277);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(76, 51);
            this.minus.TabIndex = 9;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // button07
            // 
            this.button07.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button07.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button07.Location = new System.Drawing.Point(5, 220);
            this.button07.Name = "button07";
            this.button07.Size = new System.Drawing.Size(76, 51);
            this.button07.TabIndex = 8;
            this.button07.Text = "7";
            this.button07.UseVisualStyleBackColor = false;
            this.button07.Click += new System.EventHandler(this.button07_Click);
            // 
            // button08
            // 
            this.button08.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button08.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button08.Location = new System.Drawing.Point(89, 220);
            this.button08.Name = "button08";
            this.button08.Size = new System.Drawing.Size(76, 51);
            this.button08.TabIndex = 7;
            this.button08.Text = "8";
            this.button08.UseVisualStyleBackColor = false;
            this.button08.Click += new System.EventHandler(this.button08_Click);
            // 
            // button09
            // 
            this.button09.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button09.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button09.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button09.Location = new System.Drawing.Point(171, 220);
            this.button09.Name = "button09";
            this.button09.Size = new System.Drawing.Size(76, 51);
            this.button09.TabIndex = 6;
            this.button09.Text = "9";
            this.button09.UseVisualStyleBackColor = false;
            this.button09.Click += new System.EventHandler(this.button09_Click);
            // 
            // multiply
            // 
            this.multiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiply.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(253, 220);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(76, 51);
            this.multiply.TabIndex = 5;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click_1);
            // 
            // clear_screen
            // 
            this.clear_screen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_screen.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_screen.Location = new System.Drawing.Point(171, 106);
            this.clear_screen.Name = "clear_screen";
            this.clear_screen.Size = new System.Drawing.Size(76, 51);
            this.clear_screen.TabIndex = 4;
            this.clear_screen.Text = "C";
            this.clear_screen.UseVisualStyleBackColor = true;
            this.clear_screen.Click += new System.EventHandler(this.button5_Click);
            // 
            // off
            // 
            this.off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.off.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.off.Location = new System.Drawing.Point(253, 106);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(76, 51);
            this.off.TabIndex = 2;
            this.off.Text = "OFF";
            this.off.UseVisualStyleBackColor = true;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.SystemColors.Info;
            this.equals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equals.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(253, 391);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(76, 51);
            this.equals.TabIndex = 0;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // calc_clock
            // 
            this.calc_clock.Enabled = true;
            this.calc_clock.Interval = 10;
            this.calc_clock.Tick += new System.EventHandler(this.calc_clock_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 446);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button decimal_point;
        private System.Windows.Forms.Button button00;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button03;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button04;
        private System.Windows.Forms.Button button05;
        private System.Windows.Forms.Button button06;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button button07;
        private System.Windows.Forms.Button button08;
        private System.Windows.Forms.Button button09;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button clear_screen;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Label screen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Timer calc_clock;
        private System.Windows.Forms.Label Date_now;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label top_scrn_sign;
        private System.Windows.Forms.Label top_scrn;
    }
}

