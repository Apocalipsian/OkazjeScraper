namespace ShopCountProject
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
            this.simpleSite = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.compareTrunk = new System.Windows.Forms.CheckBox();
            this.trunkUrl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkListing = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkLf = new System.Windows.Forms.RadioButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleSite
            // 
            this.simpleSite.AutoSize = true;
            this.simpleSite.Checked = true;
            this.simpleSite.Location = new System.Drawing.Point(6, 19);
            this.simpleSite.Name = "simpleSite";
            this.simpleSite.Size = new System.Drawing.Size(112, 17);
            this.simpleSite.TabIndex = 1;
            this.simpleSite.TabStop = true;
            this.simpleSite.Text = "Pojedyncza strona";
            this.simpleSite.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pierwsze 5 stron";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 171);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(473, 353);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // compareTrunk
            // 
            this.compareTrunk.AutoSize = true;
            this.compareTrunk.Location = new System.Drawing.Point(12, 104);
            this.compareTrunk.Name = "compareTrunk";
            this.compareTrunk.Size = new System.Drawing.Size(124, 17);
            this.compareTrunk.TabIndex = 4;
            this.compareTrunk.Text = "Porównaj z trunkiem ";
            this.compareTrunk.UseVisualStyleBackColor = true;
            // 
            // trunkUrl
            // 
            this.trunkUrl.Location = new System.Drawing.Point(142, 103);
            this.trunkUrl.Name = "trunkUrl";
            this.trunkUrl.Size = new System.Drawing.Size(296, 20);
            this.trunkUrl.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(473, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kris testuje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(528, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 43);
            this.button3.TabIndex = 9;
            this.button3.Text = "Otwórz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkListing
            // 
            this.checkListing.AutoSize = true;
            this.checkListing.Checked = true;
            this.checkListing.Location = new System.Drawing.Point(15, 19);
            this.checkListing.Name = "checkListing";
            this.checkListing.Size = new System.Drawing.Size(67, 17);
            this.checkListing.TabIndex = 10;
            this.checkListing.TabStop = true;
            this.checkListing.Text = "LISTING";
            this.checkListing.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkLf);
            this.groupBox1.Controls.Add(this.checkListing);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 70);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleSite);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(238, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 70);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // checkLf
            // 
            this.checkLf.AutoSize = true;
            this.checkLf.Location = new System.Drawing.Point(15, 42);
            this.checkLf.Name = "checkLf";
            this.checkLf.Size = new System.Drawing.Size(37, 17);
            this.checkLf.TabIndex = 13;
            this.checkLf.TabStop = true;
            this.checkLf.Text = "LF";
            this.checkLf.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(630, 53);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(347, 345);
            this.richTextBox2.TabIndex = 13;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 687);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trunkUrl);
            this.Controls.Add(this.compareTrunk);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton simpleSite;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox compareTrunk;
        private System.Windows.Forms.TextBox trunkUrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton checkListing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton checkLf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

