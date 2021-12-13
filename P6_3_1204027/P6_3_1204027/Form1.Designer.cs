namespace P6_3_1204027
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
            this.label1 = new System.Windows.Forms.Label();
            this.hhh = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.tl = new System.Windows.Forms.Label();
            this.jk = new System.Windows.Forms.Label();
            this.alamt = new System.Windows.Forms.Label();
            this.nt = new System.Windows.Forms.Label();
            this.ps = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.MonthCalendar();
            this.lk = new System.Windows.Forms.RadioButton();
            this.pr = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.epWarn = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbnama = new P6_3_1204027.CharTB();
            this.tbtelp = new P6_3_1204027.NumericTB();
            this.tbnpm = new P6_3_1204027.NumericTB();
            ((System.ComponentModel.ISupportInitialize)(this.epWarn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM INPUT DATA MAHASISWA";
            // 
            // hhh
            // 
            this.hhh.AutoSize = true;
            this.hhh.Location = new System.Drawing.Point(47, 129);
            this.hhh.Name = "hhh";
            this.hhh.Size = new System.Drawing.Size(31, 13);
            this.hhh.TabIndex = 1;
            this.hhh.Text = "NPM";
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Location = new System.Drawing.Point(47, 171);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(35, 13);
            this.nama.TabIndex = 2;
            this.nama.Text = "Nama";
            // 
            // tl
            // 
            this.tl.AutoSize = true;
            this.tl.Location = new System.Drawing.Point(47, 213);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(72, 13);
            this.tl.TabIndex = 3;
            this.tl.Text = "Tanggal Lahir";
            // 
            // jk
            // 
            this.jk.AutoSize = true;
            this.jk.Location = new System.Drawing.Point(47, 402);
            this.jk.Name = "jk";
            this.jk.Size = new System.Drawing.Size(71, 13);
            this.jk.TabIndex = 4;
            this.jk.Text = "Jenis Kelamin";
            // 
            // alamt
            // 
            this.alamt.AutoSize = true;
            this.alamt.Location = new System.Drawing.Point(47, 444);
            this.alamt.Name = "alamt";
            this.alamt.Size = new System.Drawing.Size(39, 13);
            this.alamt.TabIndex = 5;
            this.alamt.Text = "Alamat";
            // 
            // nt
            // 
            this.nt.AutoSize = true;
            this.nt.Location = new System.Drawing.Point(47, 526);
            this.nt.Name = "nt";
            this.nt.Size = new System.Drawing.Size(48, 13);
            this.nt.TabIndex = 6;
            this.nt.Text = "No. Telp";
            // 
            // ps
            // 
            this.ps.AutoSize = true;
            this.ps.Location = new System.Drawing.Point(47, 568);
            this.ps.Name = "ps";
            this.ps.Size = new System.Drawing.Size(73, 13);
            this.ps.TabIndex = 7;
            this.ps.Text = "Program Studi";
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(182, 214);
            this.tanggal.Name = "tanggal";
            this.tanggal.TabIndex = 11;
            // 
            // lk
            // 
            this.lk.AutoSize = true;
            this.lk.Location = new System.Drawing.Point(182, 402);
            this.lk.Name = "lk";
            this.lk.Size = new System.Drawing.Size(68, 17);
            this.lk.TabIndex = 12;
            this.lk.TabStop = true;
            this.lk.Text = "Laki-Laki";
            this.lk.UseVisualStyleBackColor = true;
            // 
            // pr
            // 
            this.pr.AutoSize = true;
            this.pr.Location = new System.Drawing.Point(285, 402);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(79, 17);
            this.pr.TabIndex = 13;
            this.pr.TabStop = true;
            this.pr.Text = "Perempuan";
            this.pr.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 444);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 55);
            this.textBox1.TabIndex = 14;
            this.textBox1.Tag = "";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(182, 568);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 628);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // epWarn
            // 
            this.epWarn.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(182, 168);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(227, 20);
            this.tbnama.TabIndex = 19;
            this.tbnama.Leave += new System.EventHandler(this.tbnama_Leave);
            // 
            // tbtelp
            // 
            this.tbtelp.Location = new System.Drawing.Point(182, 526);
            this.tbtelp.Name = "tbtelp";
            this.tbtelp.Size = new System.Drawing.Size(149, 20);
            this.tbtelp.TabIndex = 15;
            this.tbtelp.Leave += new System.EventHandler(this.tbtelp_Leave);
            // 
            // tbnpm
            // 
            this.tbnpm.Location = new System.Drawing.Point(182, 130);
            this.tbnpm.MaxLength = 7;
            this.tbnpm.Name = "tbnpm";
            this.tbnpm.Size = new System.Drawing.Size(100, 20);
            this.tbnpm.TabIndex = 8;
            this.tbnpm.Leave += new System.EventHandler(this.tbnpm_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 717);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbtelp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pr);
            this.Controls.Add(this.lk);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.tbnpm);
            this.Controls.Add(this.ps);
            this.Controls.Add(this.nt);
            this.Controls.Add(this.alamt);
            this.Controls.Add(this.jk);
            this.Controls.Add(this.tl);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.hhh);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epWarn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hhh;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label tl;
        private System.Windows.Forms.Label jk;
        private System.Windows.Forms.Label alamt;
        private System.Windows.Forms.Label nt;
        private System.Windows.Forms.Label ps;
        private NumericTB tbnpm;
        private System.Windows.Forms.MonthCalendar tanggal;
        private System.Windows.Forms.RadioButton lk;
        private System.Windows.Forms.RadioButton pr;
        private System.Windows.Forms.TextBox textBox1;
        private NumericTB tbtelp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider epWarn;
        private CharTB tbnama;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

