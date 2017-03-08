namespace WindowsFormsApplication1
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
            this.tbError = new System.Windows.Forms.TextBox();
            this.tbKoordynaty = new System.Windows.Forms.TextBox();
            this.rbInfo = new System.Windows.Forms.RichTextBox();
            this.cblSlices = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dlg1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbError
            // 
            this.tbError.Location = new System.Drawing.Point(120, 33);
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(405, 20);
            this.tbError.TabIndex = 0;
            this.tbError.Text = "C:\\Documents and Settings\\Mudia.BIURO\\Moje dokumenty\\Downloads\\error.txt";
            // 
            // tbKoordynaty
            // 
            this.tbKoordynaty.Location = new System.Drawing.Point(120, 59);
            this.tbKoordynaty.Name = "tbKoordynaty";
            this.tbKoordynaty.Size = new System.Drawing.Size(405, 20);
            this.tbKoordynaty.TabIndex = 1;
            this.tbKoordynaty.Text = "C:\\Documents and Settings\\Mudia.BIURO\\Moje dokumenty\\Downloads\\koordynaty.txt";
            // 
            // rbInfo
            // 
            this.rbInfo.Location = new System.Drawing.Point(34, 269);
            this.rbInfo.Name = "rbInfo";
            this.rbInfo.Size = new System.Drawing.Size(491, 196);
            this.rbInfo.TabIndex = 2;
            this.rbInfo.Text = "";
            // 
            // cblSlices
            // 
            this.cblSlices.CheckOnClick = true;
            this.cblSlices.FormattingEnabled = true;
            this.cblSlices.Location = new System.Drawing.Point(34, 125);
            this.cblSlices.Name = "cblSlices";
            this.cblSlices.Size = new System.Drawing.Size(491, 109);
            this.cblSlices.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Wczytaj błędy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dlg1
            // 
            this.dlg1.FileName = "openFileDialog1";
            this.dlg1.Filter = "txt|*.txt";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Wczytaj wybrane elementy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(531, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(531, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbFolder
            // 
            this.tbFolder.Location = new System.Drawing.Point(120, 7);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(405, 20);
            this.tbFolder.TabIndex = 8;
            this.tbFolder.Text = "C:\\MapoTero_v3.0.0.4";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(531, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 477);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tbFolder);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cblSlices);
            this.Controls.Add(this.rbInfo);
            this.Controls.Add(this.tbKoordynaty);
            this.Controls.Add(this.tbError);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.TextBox tbKoordynaty;
        private System.Windows.Forms.RichTextBox rbInfo;
        private System.Windows.Forms.CheckedListBox cblSlices;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog dlg1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Button button5;
    }
}

