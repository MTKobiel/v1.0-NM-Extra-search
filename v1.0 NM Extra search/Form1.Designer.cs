namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Wyszukiwarka = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchSubstring = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDirBrowse = new System.Windows.Forms.Button();
            this.lbxResults = new System.Windows.Forms.ListBox();
            this.txtSearchDirectory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.Wyszukiwarka);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 633);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(181, 54);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Wyszukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Wyszukiwarka
            // 
            this.Wyszukiwarka.AutoSize = true;
            this.Wyszukiwarka.BackColor = System.Drawing.Color.Transparent;
            this.Wyszukiwarka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Wyszukiwarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyszukiwarka.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Wyszukiwarka.Location = new System.Drawing.Point(33, 607);
            this.Wyszukiwarka.Name = "Wyszukiwarka";
            this.Wyszukiwarka.Size = new System.Drawing.Size(90, 15);
            this.Wyszukiwarka.TabIndex = 3;
            this.Wyszukiwarka.Text = "Wyszukiwarka";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(181, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(201, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 136);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtSearchSubstring
            // 
            this.txtSearchSubstring.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSearchSubstring.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchSubstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearchSubstring.Location = new System.Drawing.Point(483, 203);
            this.txtSearchSubstring.Multiline = true;
            this.txtSearchSubstring.Name = "txtSearchSubstring";
            this.txtSearchSubstring.Size = new System.Drawing.Size(389, 31);
            this.txtSearchSubstring.TabIndex = 4;
            this.txtSearchSubstring.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchSubstring.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(597, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "WPISZ KOD ELEMENTU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(210, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "OTWÓRZ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(973, 607);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btnDirBrowse
            // 
            this.btnDirBrowse.Location = new System.Drawing.Point(973, 574);
            this.btnDirBrowse.Name = "btnDirBrowse";
            this.btnDirBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnDirBrowse.TabIndex = 9;
            this.btnDirBrowse.Text = "Katalog";
            this.btnDirBrowse.UseVisualStyleBackColor = true;
            this.btnDirBrowse.Click += new System.EventHandler(this.btnDirBrowse_Click);
            // 
            // lbxResults
            // 
            this.lbxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbxResults.FormattingEnabled = true;
            this.lbxResults.ItemHeight = 20;
            this.lbxResults.Location = new System.Drawing.Point(214, 406);
            this.lbxResults.Name = "lbxResults";
            this.lbxResults.Size = new System.Drawing.Size(457, 180);
            this.lbxResults.TabIndex = 10;
            this.lbxResults.SelectedIndexChanged += new System.EventHandler(this.lbxResults_SelectedIndexChanged);
            // 
            // txtSearchDirectory
            // 
            this.txtSearchDirectory.Location = new System.Drawing.Point(710, 576);
            this.txtSearchDirectory.Name = "txtSearchDirectory";
            this.txtSearchDirectory.ReadOnly = true;
            this.txtSearchDirectory.Size = new System.Drawing.Size(257, 20);
            this.txtSearchDirectory.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(326, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nord Mebel Sp z .o.o";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(384, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "ul. Sportowa 11";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(384, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "13-100 Nidzica";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1071, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = "Zamknij program";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearchDirectory);
            this.Controls.Add(this.lbxResults);
            this.Controls.Add(this.btnDirBrowse);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchSubstring);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Wyszukiwarka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchSubstring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDirBrowse;
        private System.Windows.Forms.ListBox lbxResults;
        private System.Windows.Forms.TextBox txtSearchDirectory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

