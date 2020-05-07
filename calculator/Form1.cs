using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal scrn_no;
        decimal tp_scrn;
        decimal rst;
        // ==========================================================================================
        // =======================       DECIMAL BUTTON        =====================================
        // ==========================================================================================
        private void button19_Click(object sender, EventArgs e)
        {
            if(screen.Text == "")
            {
                this.screen.Text = "0.";
            }
            if (screen.Text.Contains("."))
            {
                this.screen.Text = this.screen.Text + "";
            }
            else
            {
                this.screen.Text = this.screen.Text + ".";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.top_scrn.ResetText();
            this.top_scrn_sign.ResetText();
            this.screen.ResetText();
            this.screen.Text = "0";
        }
        // ==========================================================================================
        // =======================       NUMBER BUTTONS STARTS        =====================================
        // ==========================================================================================
        private void button00_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                this.screen.Text = "0";
            }
            else
            {
                this.screen.Text = this.screen.Text + "0";
            }
        }

        private void button01_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
            {
                this.screen.Text = this.screen.Text + "1";
            }
            else
            {
                this.screen.Text = "1";
            }
        }

        private void button02_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
            {
                this.screen.Text = this.screen.Text + "2";
            }
            else
            {
                this.screen.Text = "2";
            }
        }

        private void button03_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
            {
                this.screen.Text = this.screen.Text + "3";
            }
            else
            {
                this.screen.Text = "3";
            }
        }

        private void button04_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
            {
                this.screen.Text = this.screen.Text + "4";
            }
            else
            {
                this.screen.Text = "4";
            }
        }

        private void button05_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
            {
                this.screen.Text = this.screen.Text + "5";
            }
            else
            {
                this.screen.Text = "5";
            }
        }

        private void button06_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
            {
                this.screen.Text = this.screen.Text + "6";
            }
            else
            {
                this.screen.Text = "6";
            }
        }

        private void button07_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
            {
                this.screen.Text = this.screen.Text + "7";
            }
            else
            {
                this.screen.Text = "7";
            }
        }

        private void button08_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
            {
                this.screen.Text = this.screen.Text + "8";
            }
            else
            {
                this.screen.Text = "8";
            }
        }

        private void button09_Click(object sender, EventArgs e)
        {
            if (screen.Text != "0")
            {
                this.screen.Text = this.screen.Text + "9";
            }
            else
            {
                this.screen.Text = "9";
            }
        }
        // ==========================================================================================
        // =======================       NUMBER BUTTONS STOP        =====================================
        // ==========================================================================================

        // =====================    CLOSE WINDOW ======================
        private void off_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // ==========================================================================================
        // =======================       TIMER CONTROL BUTTON        =====================================
        // ==========================================================================================
        private void calc_clock_Tick(object sender, EventArgs e)
        {
            this.Date_now.Text = DateTime.Now.DayOfWeek.ToString();
            this.clock.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(); //+ ":" + DateTime.Now.Millisecond.ToString();
        }

        private void clock_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // ==========================================================================================
        // =======================       ADDITION BUTTON        =====================================
        // ==========================================================================================
        private void add_Click(object sender, EventArgs e)
        {
            this.top_scrn_sign.Text = "+";
            if (screen.Text != "")
            {
                decimal.TryParse(screen.Text, out scrn_no);
                decimal.TryParse(top_scrn.Text, out tp_scrn);
               rst = tp_scrn + scrn_no;
                
                this.top_scrn.Text = rst.ToString();
            }
            this.screen.ResetText();
        }
        // ==========================================================================================
        // =======================       MINUS BUTTON        =====================================
        // ==========================================================================================
        private void minus_Click(object sender, EventArgs e)
        {
            this.top_scrn_sign.Text = "-";
                decimal.TryParse(screen.Text, out scrn_no);
                decimal.TryParse(top_scrn.Text, out tp_scrn);
                
            //if(top_scrn.Text == "" || top_scrn.Text == "0")
            //{
            //    this.top_scrn.Text = this.screen.Text;
            //}
            if (top_scrn.Text != "")
            {
                rst = tp_scrn - scrn_no;
                this.top_scrn.Text = rst.ToString();
                //this.top_scrn.Text = screen.Text;
            }
            else if (top_scrn.Text == "" || top_scrn.Text == "0")
            {
                this.top_scrn.Text = this.screen.Text;

            }
            this.screen.ResetText();
        }

        // ==========================================================================================
        // =======================       MULTIPLY BUTTON        =====================================
        // ==========================================================================================

        private void multiply_Click_1(object sender, EventArgs e)
        {
            
            this.top_scrn_sign.Text = "x";
            if (top_scrn.Text == "0" || top_scrn.Text == "")
            {
                this.top_scrn.Text = screen.Text;
                this.screen.ResetText();

            }
            else if (screen.Text != "")
            {
                //this.top_scrn.Text = screen.Text;
                decimal.TryParse(screen.Text, out scrn_no);
                decimal.TryParse(top_scrn.Text, out tp_scrn);
                
                rst = tp_scrn * scrn_no;

                this.top_scrn.Text = rst.ToString();
                //this.top_scrn.Text = screen.Text;
            }
            this.screen.ResetText();
        }
        // ==========================================================================================
        // =======================       DIVISION BUTTON        =====================================
        // ==========================================================================================
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.top_scrn_sign.Text = "/";
            if (top_scrn.Text == "0" || top_scrn.Text == "")
            {
                this.top_scrn.Text = screen.Text;
                this.screen.ResetText();

            }
            else if (screen.Text != "")
            {
                decimal.TryParse(screen.Text, out scrn_no);
                decimal.TryParse(top_scrn.Text, out tp_scrn);
                top_scrn.Text = screen.Text;
                rst = tp_scrn / scrn_no;

                this.top_scrn.Text = rst.ToString();
                //this.top_scrn.Text = screen.Text;
            }
            this.screen.ResetText();
        }
        // ==========================================================================================
        // =======================       %PERCENT BUTTON        =====================================
        // ==========================================================================================
        private void button3_Click(object sender, EventArgs e)
        {
            decimal pct;
            decimal.TryParse(this.screen.Text, out pct);
            decimal rst = pct / 100;
            this.screen.Text = rst.ToString();
            
        }
        // ==========================================================================================
        // =======================       EQUATION BUTTON        =====================================
        // ==========================================================================================
        private void equals_Click(object sender, EventArgs e)
        {
            

            if (top_scrn_sign.Text == "+")
            {
                decimal.TryParse(screen.Text, out scrn_no);
                decimal.TryParse(top_scrn.Text, out tp_scrn);

                rst = scrn_no + tp_scrn;
                this.screen.Text = rst.ToString();
                this.top_scrn.ResetText();
                this.top_scrn_sign.ResetText();
            }
            else if (top_scrn_sign.Text == "-")
            {
                decimal.TryParse(screen.Text, out scrn_no);
                decimal.TryParse(top_scrn.Text, out tp_scrn);

                rst = tp_scrn - scrn_no;
                this.screen.Text = rst.ToString();
                this.top_scrn.ResetText();
                this.top_scrn_sign.ResetText();
            }
            else if (top_scrn_sign.Text == "x")
            {
                decimal.TryParse(screen.Text, out scrn_no);
                decimal.TryParse(top_scrn.Text, out tp_scrn);

                rst = tp_scrn *  scrn_no;
                this.screen.Text = rst.ToString();
                this.top_scrn.ResetText();
                this.top_scrn_sign.ResetText();
            }
            else if (top_scrn_sign.Text == "/")
            {
                decimal.TryParse(screen.Text, out scrn_no);
                decimal.TryParse(top_scrn.Text, out tp_scrn);

                rst = tp_scrn / scrn_no;
                this.screen.Text = rst.ToString();
                this.top_scrn.ResetText();
                this.top_scrn_sign.ResetText();
            }
            // ==========================================================================================
            // =======================       EQUATION FINISH        =====================================
            // ==========================================================================================
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal s;
            Int32 xample = 1 - 2;
            decimal.TryParse(screen.Text, out s);
            decimal total = s  * xample;
            this.screen.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal fn;
            decimal sn = 1-2;
            decimal tn;
            decimal.TryParse(this.screen.Text, out fn);
            if (this.screen.Text.Contains("-"))
            {
                tn = fn * sn;
                this.screen.Text = tn.ToString();
            }
        }

        private void screen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            this.screen.Text = e.KeyCode.ToString();
            this.Text = e.KeyCode.ToString();
        }
    }
}
