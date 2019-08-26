namespace Offocus
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
            this.txtip0 = new System.Windows.Forms.Label();
            this.txtip1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btscannet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btfolder = new System.Windows.Forms.Button();
            this.txtfolder = new System.Windows.Forms.TextBox();
            this.btscanfolder = new System.Windows.Forms.Button();
            this.chbimages = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtip0
            // 
            this.txtip0.AutoSize = true;
            this.txtip0.Location = new System.Drawing.Point(39, 23);
            this.txtip0.Name = "txtip0";
            this.txtip0.Size = new System.Drawing.Size(59, 13);
            this.txtip0.TabIndex = 0;
            this.txtip0.Text = "Starting IP:";
            // 
            // txtip1
            // 
            this.txtip1.AutoSize = true;
            this.txtip1.Location = new System.Drawing.Point(42, 59);
            this.txtip1.Name = "txtip1";
            this.txtip1.Size = new System.Drawing.Size(56, 13);
            this.txtip1.TabIndex = 1;
            this.txtip1.Text = "Ending IP:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 3;
            // 
            // txtuser
            // 
            this.txtuser.AutoSize = true;
            this.txtuser.Location = new System.Drawing.Point(289, 23);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(32, 13);
            this.txtuser.TabIndex = 4;
            this.txtuser.Text = "User:";
            // 
            // txtpassword
            // 
            this.txtpassword.AutoSize = true;
            this.txtpassword.Location = new System.Drawing.Point(289, 59);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(59, 13);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.Text = "Password :";
            this.txtpassword.UseMnemonic = false;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(358, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "admin";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(358, 58);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(143, 20);
            this.textBox4.TabIndex = 7;
            // 
            // btscannet
            // 
            this.btscannet.Location = new System.Drawing.Point(519, 12);
            this.btscannet.Name = "btscannet";
            this.btscannet.Size = new System.Drawing.Size(131, 57);
            this.btscannet.TabIndex = 8;
            this.btscannet.Text = "Scan";
            this.btscannet.UseVisualStyleBackColor = true;
            this.btscannet.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Scan a Folder :";
            // 
            // btfolder
            // 
            this.btfolder.Location = new System.Drawing.Point(493, 99);
            this.btfolder.Name = "btfolder";
            this.btfolder.Size = new System.Drawing.Size(75, 23);
            this.btfolder.TabIndex = 10;
            this.btfolder.Text = "Select ";
            this.btfolder.UseVisualStyleBackColor = true;
            this.btfolder.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtfolder
            // 
            this.txtfolder.Location = new System.Drawing.Point(128, 101);
            this.txtfolder.Name = "txtfolder";
            this.txtfolder.Size = new System.Drawing.Size(334, 20);
            this.txtfolder.TabIndex = 11;
            this.txtfolder.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // btscanfolder
            // 
            this.btscanfolder.Location = new System.Drawing.Point(584, 99);
            this.btscanfolder.Name = "btscanfolder";
            this.btscanfolder.Size = new System.Drawing.Size(75, 23);
            this.btscanfolder.TabIndex = 12;
            this.btscanfolder.Text = "button2";
            this.btscanfolder.UseVisualStyleBackColor = true;
            // 
            // chbimages
            // 
            this.chbimages.AutoSize = true;
            this.chbimages.Location = new System.Drawing.Point(537, 76);
            this.chbimages.Name = "chbimages";
            this.chbimages.Size = new System.Drawing.Size(86, 17);
            this.chbimages.TabIndex = 13;
            this.chbimages.Text = "View Images";
            this.chbimages.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(358, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 185);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(303, 185);
            this.dataGridView1.TabIndex = 15;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(45, 348);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(614, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 398);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chbimages);
            this.Controls.Add(this.btscanfolder);
            this.Controls.Add(this.txtfolder);
            this.Controls.Add(this.btfolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btscannet);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtip1);
            this.Controls.Add(this.txtip0);
            this.Name = "Form1";
            this.Text = "Off Focus v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtip0;
        private System.Windows.Forms.Label txtip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtuser;
        private System.Windows.Forms.Label txtpassword;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btscannet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btfolder;
        private System.Windows.Forms.TextBox txtfolder;
        private System.Windows.Forms.Button btscanfolder;
        private System.Windows.Forms.CheckBox chbimages;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

