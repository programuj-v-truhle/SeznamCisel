namespace SeznamCisel
{
    partial class MyForm
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
            this.seznam = new System.Windows.Forms.ListBox();
            this.vkladaneCislo = new System.Windows.Forms.TextBox();
            this.vlozCislo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nejmensi = new System.Windows.Forms.Label();
            this.nejvetsi = new System.Windows.Forms.Label();
            this.prumer = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.parita = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // seznam
            // 
            this.seznam.FormattingEnabled = true;
            this.seznam.Location = new System.Drawing.Point(5, 33);
            this.seznam.Name = "seznam";
            this.seznam.Size = new System.Drawing.Size(219, 212);
            this.seznam.TabIndex = 0;
            this.seznam.SelectedIndexChanged += new System.EventHandler(this.seznam_SelectedIndexChanged);
            this.seznam.DoubleClick += new System.EventHandler(this.seznam_DoubleClick);
            // 
            // vkladaneCislo
            // 
            this.vkladaneCislo.Location = new System.Drawing.Point(52, 7);
            this.vkladaneCislo.Name = "vkladaneCislo";
            this.vkladaneCislo.Size = new System.Drawing.Size(91, 20);
            this.vkladaneCislo.TabIndex = 1;
            this.vkladaneCislo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vkladaneCislo_KeyDown);
            // 
            // vlozCislo
            // 
            this.vlozCislo.Location = new System.Drawing.Point(150, 7);
            this.vlozCislo.Name = "vlozCislo";
            this.vlozCislo.Size = new System.Drawing.Size(75, 20);
            this.vlozCislo.TabIndex = 2;
            this.vlozCislo.Text = "Vlozit cislo";
            this.vlozCislo.UseVisualStyleBackColor = true;
            this.vlozCislo.Click += new System.EventHandler(this.vlozCislo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cislo :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nejmensi);
            this.groupBox1.Controls.Add(this.nejvetsi);
            this.groupBox1.Controls.Add(this.prumer);
            this.groupBox1.Location = new System.Drawing.Point(6, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Udaje o cislech";
            // 
            // nejmensi
            // 
            this.nejmensi.AutoSize = true;
            this.nejmensi.Location = new System.Drawing.Point(6, 70);
            this.nejmensi.Name = "nejmensi";
            this.nejmensi.Size = new System.Drawing.Size(77, 13);
            this.nejmensi.TabIndex = 2;
            this.nejmensi.Text = "Nejmensi cislo:";
            // 
            // nejvetsi
            // 
            this.nejvetsi.AutoSize = true;
            this.nejvetsi.Location = new System.Drawing.Point(8, 45);
            this.nejvetsi.Name = "nejvetsi";
            this.nejvetsi.Size = new System.Drawing.Size(72, 13);
            this.nejvetsi.TabIndex = 1;
            this.nejvetsi.Text = "Nejvetsi cislo:";
            // 
            // prumer
            // 
            this.prumer.AutoSize = true;
            this.prumer.Location = new System.Drawing.Point(8, 20);
            this.prumer.Name = "prumer";
            this.prumer.Size = new System.Drawing.Size(78, 13);
            this.prumer.TabIndex = 0;
            this.prumer.Text = "Prumer z cisel: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.parita);
            this.groupBox2.Location = new System.Drawing.Point(6, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 70);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Udaje o vybranem cislu";
            // 
            // parita
            // 
            this.parita.AutoSize = true;
            this.parita.Location = new System.Drawing.Point(11, 29);
            this.parita.Name = "parita";
            this.parita.Size = new System.Drawing.Size(40, 13);
            this.parita.TabIndex = 0;
            this.parita.Text = "Parita :";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vlozCislo);
            this.Controls.Add(this.vkladaneCislo);
            this.Controls.Add(this.seznam);
            this.MaximizeBox = false;
            this.Name = "MyForm";
            this.Text = "Seznam";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox seznam;
        private System.Windows.Forms.TextBox vkladaneCislo;
        private System.Windows.Forms.Button vlozCislo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label nejmensi;
        private System.Windows.Forms.Label nejvetsi;
        private System.Windows.Forms.Label prumer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label parita;

    }
}

