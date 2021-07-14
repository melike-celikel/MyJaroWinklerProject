
namespace MyJaroWinklerProject
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
            this.txtList1 = new System.Windows.Forms.TextBox();
            this.myJaroWinkler1 = new MyJaroWinklerProject.MyJaroWinkler(this.components);
            this.txtList2 = new System.Windows.Forms.TextBox();
            this.txtekle2 = new System.Windows.Forms.Button();
            this.txtsil1 = new System.Windows.Forms.Button();
            this.txtsil2 = new System.Windows.Forms.Button();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.txtekle1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtList1
            // 
            this.txtList1.Location = new System.Drawing.Point(12, 22);
            this.txtList1.Name = "txtList1";
            this.txtList1.Size = new System.Drawing.Size(100, 20);
            this.txtList1.TabIndex = 0;
            // 
            // myJaroWinkler1
            // 
            this.myJaroWinkler1.Metin1 = null;
            this.myJaroWinkler1.Metin2 = null;
            // 
            // txtList2
            // 
            this.txtList2.Location = new System.Drawing.Point(130, 21);
            this.txtList2.Name = "txtList2";
            this.txtList2.Size = new System.Drawing.Size(100, 20);
            this.txtList2.TabIndex = 1;
            // 
            // txtekle2
            // 
            this.txtekle2.Location = new System.Drawing.Point(149, 57);
            this.txtekle2.Name = "txtekle2";
            this.txtekle2.Size = new System.Drawing.Size(65, 23);
            this.txtekle2.TabIndex = 3;
            this.txtekle2.Text = "EKLE";
            this.txtekle2.UseVisualStyleBackColor = true;
            this.txtekle2.Click += new System.EventHandler(this.txtekle2_Click);
            // 
            // txtsil1
            // 
            this.txtsil1.Location = new System.Drawing.Point(25, 86);
            this.txtsil1.Name = "txtsil1";
            this.txtsil1.Size = new System.Drawing.Size(65, 23);
            this.txtsil1.TabIndex = 4;
            this.txtsil1.Text = "SİL";
            this.txtsil1.UseVisualStyleBackColor = true;
            this.txtsil1.Click += new System.EventHandler(this.txtsil1_Click);
            // 
            // txtsil2
            // 
            this.txtsil2.Location = new System.Drawing.Point(149, 86);
            this.txtsil2.Name = "txtsil2";
            this.txtsil2.Size = new System.Drawing.Size(65, 23);
            this.txtsil2.TabIndex = 5;
            this.txtsil2.Text = "SİL";
            this.txtsil2.UseVisualStyleBackColor = true;
            this.txtsil2.Click += new System.EventHandler(this.txtsil2_Click);
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(376, 69);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(289, 29);
            this.btnhesapla.TabIndex = 6;
            this.btnhesapla.Text = "BENZERLİKLER VE JARO-WİNKLER UZAKLIĞI";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 10.18868F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Items.AddRange(new object[] {
            "melike",
            "ekmeklik",
            "ŞefTali"});
            this.listBox1.Location = new System.Drawing.Point(12, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 225);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Courier New", 10.18868F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 17;
            this.listBox2.Items.AddRange(new object[] {
            "meliçe",
            "tekmelik",
            "ŞEfTail"});
            this.listBox2.Location = new System.Drawing.Point(130, 115);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(100, 225);
            this.listBox2.TabIndex = 8;
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Courier New", 10.18868F);
            this.listBox3.FormattingEnabled = true;
            this.listBox3.HorizontalScrollbar = true;
            this.listBox3.ItemHeight = 17;
            this.listBox3.Location = new System.Drawing.Point(251, 115);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(593, 225);
            this.listBox3.TabIndex = 3;
            // 
            // txtekle1
            // 
            this.txtekle1.Location = new System.Drawing.Point(25, 57);
            this.txtekle1.Name = "txtekle1";
            this.txtekle1.Size = new System.Drawing.Size(65, 23);
            this.txtekle1.TabIndex = 10;
            this.txtekle1.Text = "EKLE";
            this.txtekle1.UseVisualStyleBackColor = true;
            this.txtekle1.Click += new System.EventHandler(this.txtekle1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.txtekle1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.txtsil2);
            this.Controls.Add(this.txtsil1);
            this.Controls.Add(this.txtekle2);
            this.Controls.Add(this.txtList2);
            this.Controls.Add(this.txtList1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtList1;
        private MyJaroWinkler myJaroWinkler1;
        private System.Windows.Forms.TextBox txtList2;
        private System.Windows.Forms.Button txtekle2;
        private System.Windows.Forms.Button txtsil1;
        private System.Windows.Forms.Button txtsil2;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button txtekle1;
    }
}

