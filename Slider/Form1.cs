using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slider
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblname_Click(object sender, EventArgs e)
        {
            line.Width = lblname.Width;
            line.Left = lblname.Left;
            line.Top = lblname.Bottom;
            lineUp.Width = lblname.Width;
            lineUp.Left = lblname.Left;
            lineUp.Top = lblname.Top + -3;
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {
            line.Width = lblAddress.Width;
            line.Left = lblAddress.Left;
            line.Top = lblAddress.Bottom;
            lineUp.Width = lblAddress.Width;
            lineUp.Left = lblAddress.Left;
            lineUp.Top = lblAddress.Top + -3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAction.Left = 0;
        }

        private void lblLinux_Click(object sender, EventArgs e)
        {
            line.Width = lblLinux.Width;
            line.Left = lblLinux.Left;
            line.Top = lblLinux.Bottom;
            lineUp.Width = lblLinux.Width;
            lineUp.Left = lblLinux.Left;
            lineUp.Top = lblLinux.Top + -3;
        }

        private void lblMac_Click(object sender, EventArgs e)
        {
            line.Width = lblMac.Width;
            line.Left = lblMac.Left;
            line.Top = lblMac.Bottom;
            lineUp.Width = lblMac.Width;
            lineUp.Left = lblMac.Left;
            lineUp.Top = lblMac.Top + -3;
        }

        private void lblFirefox_Click(object sender, EventArgs e)
        {
            line.Width = lblFirefox.Width;
            line.Left = lblFirefox.Left;
            line.Top = lblFirefox.Bottom;
            lineUp.Width = lblFirefox.Width;
            lineUp.Left = lblFirefox.Left;
            lineUp.Top = lblFirefox.Top + -3;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAmazon_Click(object sender, EventArgs e)
        {
            line.Width = lblAmazon.Width;
            line.Left = lblAmazon.Left;
            line.Top = lblAmazon.Bottom;
            lineUp.Width = lblAmazon.Width;
            lineUp.Left = lblAmazon.Left;
            lineUp.Top = lblAmazon.Top + -3;
        }

        private void lblBlackberry_Click(object sender, EventArgs e)
        {
            line.Width = lblBlackberry.Width;
            line.Left = lblBlackberry.Left;
            line.Top = lblBlackberry.Bottom;
            lineUp.Width = lblBlackberry.Width;
            lineUp.Left = lblBlackberry.Left;
            lineUp.Top = lblBlackberry.Top + -3;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                timer2.Enabled = true;
               


            }
            else
            {
                timer1.Enabled = true;
               

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (panel1.Width >= 119)
            {
                
                timer1.Enabled = false;
               
                
            }
            
             else
             {
                btnAction.Left = panel1.Right - 5;
                panel1.Width += 10;
                panel1.Visible = true;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel1.Width <= 5)
            {
                
                this.timer2.Enabled = false;
                panel1.Visible = false;
                panel1.Width = 5;
                btnAction.Left = 0;


            }
            else
            {
                btnAction.Left = panel1.Right - 15;
                panel1.Width -= 10;

            }
        }
    }
}
