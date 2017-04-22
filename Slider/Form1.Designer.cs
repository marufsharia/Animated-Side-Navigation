namespace Slider
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
            this.btnAction = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.line = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblBlackberry = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblAmazon = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFirefox = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblAddress = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMac = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lineUp = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblLinux = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAction.BackgroundImage")));
            this.btnAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAction.ButtonText = "";
            this.btnAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAction.ForeColorHoverState = System.Drawing.Color.Transparent;
            this.btnAction.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAction.Iconimage")));
            this.btnAction.IconVisible = false;
            this.btnAction.IconZoom = 90D;
            this.btnAction.ImageIconOverlay = false;
            this.btnAction.Location = new System.Drawing.Point(126, 5);
            this.btnAction.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(34, 36);
            this.btnAction.TabIndex = 0;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.line.LineThickness = 2;
            this.line.Location = new System.Drawing.Point(59, 37);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(57, 10);
            this.line.TabIndex = 2;
            this.line.Transparency = 255;
            this.line.Vertical = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.lblBlackberry);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.lblAmazon);
            this.panel1.Controls.Add(this.line);
            this.panel1.Controls.Add(this.lblFirefox);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblMac);
            this.panel1.Controls.Add(this.lineUp);
            this.panel1.Controls.Add(this.lblLinux);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 443);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(72, 25);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "OS List";
            // 
            // lblBlackberry
            // 
            this.lblBlackberry.AutoEllipsis = true;
            this.lblBlackberry.BackColor = System.Drawing.Color.Transparent;
            this.lblBlackberry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBlackberry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBlackberry.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackberry.Location = new System.Drawing.Point(-1, 186);
            this.lblBlackberry.Name = "lblBlackberry";
            this.lblBlackberry.Size = new System.Drawing.Size(121, 18);
            this.lblBlackberry.TabIndex = 11;
            this.lblBlackberry.Text = "BlackBerry";
            this.lblBlackberry.Click += new System.EventHandler(this.lblBlackberry_Click);
            // 
            // lblname
            // 
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblname.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(-1, 29);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(120, 18);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Android                             ";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblAmazon
            // 
            this.lblAmazon.AutoEllipsis = true;
            this.lblAmazon.BackColor = System.Drawing.Color.Transparent;
            this.lblAmazon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAmazon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAmazon.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmazon.Location = new System.Drawing.Point(0, 159);
            this.lblAmazon.Name = "lblAmazon";
            this.lblAmazon.Size = new System.Drawing.Size(120, 18);
            this.lblAmazon.TabIndex = 10;
            this.lblAmazon.Text = "Amazon";
            this.lblAmazon.Click += new System.EventHandler(this.lblAmazon_Click);
            // 
            // lblFirefox
            // 
            this.lblFirefox.AutoEllipsis = true;
            this.lblFirefox.BackColor = System.Drawing.Color.Transparent;
            this.lblFirefox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFirefox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFirefox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirefox.Location = new System.Drawing.Point(-1, 132);
            this.lblFirefox.Name = "lblFirefox";
            this.lblFirefox.Size = new System.Drawing.Size(121, 18);
            this.lblFirefox.TabIndex = 9;
            this.lblFirefox.Text = "Firefox";
            this.lblFirefox.Click += new System.EventHandler(this.lblFirefox_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoEllipsis = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAddress.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(0, 54);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(119, 18);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Windows";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblMac
            // 
            this.lblMac.AutoEllipsis = true;
            this.lblMac.BackColor = System.Drawing.Color.Transparent;
            this.lblMac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMac.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMac.Location = new System.Drawing.Point(-1, 104);
            this.lblMac.Name = "lblMac";
            this.lblMac.Size = new System.Drawing.Size(121, 18);
            this.lblMac.TabIndex = 8;
            this.lblMac.Text = "MAC";
            this.lblMac.Click += new System.EventHandler(this.lblMac_Click);
            // 
            // lineUp
            // 
            this.lineUp.BackColor = System.Drawing.Color.Transparent;
            this.lineUp.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lineUp.LineThickness = 2;
            this.lineUp.Location = new System.Drawing.Point(17, 28);
            this.lineUp.Name = "lineUp";
            this.lineUp.Size = new System.Drawing.Size(55, 7);
            this.lineUp.TabIndex = 6;
            this.lineUp.Transparency = 255;
            this.lineUp.Vertical = false;
            // 
            // lblLinux
            // 
            this.lblLinux.AutoEllipsis = true;
            this.lblLinux.BackColor = System.Drawing.Color.Transparent;
            this.lblLinux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLinux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLinux.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinux.Location = new System.Drawing.Point(0, 79);
            this.lblLinux.Name = "lblLinux";
            this.lblLinux.Size = new System.Drawing.Size(120, 18);
            this.lblLinux.TabIndex = 7;
            this.lblLinux.Text = "Linux";
            this.lblLinux.Click += new System.EventHandler(this.lblLinux_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAction);
            this.DisplayHeader = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuThinButton btnAction;
        private Bunifu.Framework.UI.BunifuSeparator line;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblname;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAddress;
        private Bunifu.Framework.UI.BunifuSeparator lineUp;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLinux;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMac;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFirefox;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAmazon;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBlackberry;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}

