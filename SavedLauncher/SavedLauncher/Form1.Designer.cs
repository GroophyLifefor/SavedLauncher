namespace SavedLauncher
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
            this.con = new System.Windows.Forms.Button();
            this.uncon = new System.Windows.Forms.Button();
            this.stat = new System.Windows.Forms.Label();
            this.selectlist = new System.Windows.Forms.ComboBox();
            this.newadd = new System.Windows.Forms.Button();
            this.newaddname = new System.Windows.Forms.TextBox();
            this.newaddip = new System.Windows.Forms.TextBox();
            this.addnow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Location = new System.Drawing.Point(13, 13);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(75, 37);
            this.con.TabIndex = 0;
            this.con.Text = "Connect";
            this.con.UseVisualStyleBackColor = true;
            this.con.Click += new System.EventHandler(this.con_Click);
            // 
            // uncon
            // 
            this.uncon.Location = new System.Drawing.Point(94, 13);
            this.uncon.Name = "uncon";
            this.uncon.Size = new System.Drawing.Size(75, 37);
            this.uncon.TabIndex = 1;
            this.uncon.Text = "Unconnect";
            this.uncon.UseVisualStyleBackColor = true;
            this.uncon.Click += new System.EventHandler(this.uncon_Click);
            // 
            // stat
            // 
            this.stat.AutoSize = true;
            this.stat.Location = new System.Drawing.Point(13, 57);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(43, 13);
            this.stat.TabIndex = 2;
            this.stat.Text = "Status: ";
            // 
            // selectlist
            // 
            this.selectlist.FormattingEnabled = true;
            this.selectlist.Items.AddRange(new object[] {
            "RealGT,127.0.0.1"});
            this.selectlist.Location = new System.Drawing.Point(175, 22);
            this.selectlist.Name = "selectlist";
            this.selectlist.Size = new System.Drawing.Size(134, 21);
            this.selectlist.TabIndex = 3;
            // 
            // newadd
            // 
            this.newadd.Location = new System.Drawing.Point(12, 112);
            this.newadd.Name = "newadd";
            this.newadd.Size = new System.Drawing.Size(85, 37);
            this.newadd.TabIndex = 4;
            this.newadd.Text = "Add New Private";
            this.newadd.UseVisualStyleBackColor = true;
            this.newadd.Click += new System.EventHandler(this.newadd_Click);
            // 
            // newaddname
            // 
            this.newaddname.Location = new System.Drawing.Point(12, 156);
            this.newaddname.Name = "newaddname";
            this.newaddname.Size = new System.Drawing.Size(198, 20);
            this.newaddname.TabIndex = 5;
            this.newaddname.Text = "Name (ex: GTPS)";
            this.newaddname.Visible = false;
            // 
            // newaddip
            // 
            this.newaddip.Location = new System.Drawing.Point(11, 182);
            this.newaddip.Name = "newaddip";
            this.newaddip.Size = new System.Drawing.Size(199, 20);
            this.newaddip.TabIndex = 6;
            this.newaddip.Text = "Ip (ex: 123.123.123.123)";
            this.newaddip.Visible = false;
            // 
            // addnow
            // 
            this.addnow.Location = new System.Drawing.Point(11, 208);
            this.addnow.Name = "addnow";
            this.addnow.Size = new System.Drawing.Size(75, 37);
            this.addnow.TabIndex = 7;
            this.addnow.Text = "Add Now";
            this.addnow.UseVisualStyleBackColor = true;
            this.addnow.Visible = false;
            this.addnow.Click += new System.EventHandler(this.addnow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "hosts: ";
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(283, 57);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(75, 23);
            this.res.TabIndex = 9;
            this.res.Text = "button1";
            this.res.UseVisualStyleBackColor = true;
            this.res.Visible = false;
            this.res.Click += new System.EventHandler(this.res_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(213, 183);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Remove Selected Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addnow);
            this.Controls.Add(this.newaddip);
            this.Controls.Add(this.newaddname);
            this.Controls.Add(this.newadd);
            this.Controls.Add(this.selectlist);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.uncon);
            this.Controls.Add(this.con);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Savedlauncher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button con;
        private System.Windows.Forms.Button uncon;
        private System.Windows.Forms.Label stat;
        private System.Windows.Forms.ComboBox selectlist;
        private System.Windows.Forms.Button newadd;
        private System.Windows.Forms.TextBox newaddname;
        private System.Windows.Forms.TextBox newaddip;
        private System.Windows.Forms.Button addnow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button res;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

