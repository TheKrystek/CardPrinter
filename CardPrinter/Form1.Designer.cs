namespace CardPrinter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.katalog = new System.Windows.Forms.Button();
            this.generuj = new System.Windows.Forms.Button();
            this.duplex = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.wczytaj = new System.Windows.Forms.Button();
            this.zapisz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.szerokosc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wysokosc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.odstepX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.marks = new System.Windows.Forms.CheckBox();
            this.pliki = new System.Windows.Forms.ListBox();
            this.dsf = new System.Windows.Forms.TableLayoutPanel();
            this.prawy = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.revers = new System.Windows.Forms.ComboBox();
            this.lewy = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.para = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Button();
            this.projektlabel = new System.Windows.Forms.Label();
            this.kart = new System.Windows.Forms.Label();
            this.karty = new System.Windows.Forms.DataGridView();
            this.KartyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.saveProject = new System.Windows.Forms.SaveFileDialog();
            this.openProject = new System.Windows.Forms.OpenFileDialog();
            this.savePDF = new System.Windows.Forms.SaveFileDialog();
            this.odstepY = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.dsf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prawy)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lewy)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karty)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pliki, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dsf, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1352, 546);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.katalog);
            this.flowLayoutPanel1.Controls.Add(this.generuj);
            this.flowLayoutPanel1.Controls.Add(this.duplex);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(259, 54);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // katalog
            // 
            this.katalog.Location = new System.Drawing.Point(4, 4);
            this.katalog.Margin = new System.Windows.Forms.Padding(4);
            this.katalog.Name = "katalog";
            this.katalog.Size = new System.Drawing.Size(72, 28);
            this.katalog.TabIndex = 0;
            this.katalog.Text = "katalog";
            this.katalog.UseVisualStyleBackColor = true;
            this.katalog.Click += new System.EventHandler(this.katalog_Click);
            // 
            // generuj
            // 
            this.generuj.Enabled = false;
            this.generuj.Location = new System.Drawing.Point(84, 4);
            this.generuj.Margin = new System.Windows.Forms.Padding(4);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(67, 28);
            this.generuj.TabIndex = 1;
            this.generuj.Text = "generuj";
            this.generuj.UseVisualStyleBackColor = true;
            this.generuj.Click += new System.EventHandler(this.generuj_Click);
            // 
            // duplex
            // 
            this.duplex.AutoSize = true;
            this.duplex.Location = new System.Drawing.Point(158, 8);
            this.duplex.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.duplex.Name = "duplex";
            this.duplex.Size = new System.Drawing.Size(73, 21);
            this.duplex.TabIndex = 2;
            this.duplex.Text = "Duplex";
            this.duplex.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.wczytaj);
            this.flowLayoutPanel2.Controls.Add(this.zapisz);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.szerokosc);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.wysokosc);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.odstepX);
            this.flowLayoutPanel2.Controls.Add(this.odstepY);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.marks);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(271, 4);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1077, 54);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // wczytaj
            // 
            this.wczytaj.Location = new System.Drawing.Point(4, 4);
            this.wczytaj.Margin = new System.Windows.Forms.Padding(4);
            this.wczytaj.Name = "wczytaj";
            this.wczytaj.Size = new System.Drawing.Size(100, 28);
            this.wczytaj.TabIndex = 0;
            this.wczytaj.Text = "wczytaj";
            this.wczytaj.UseVisualStyleBackColor = true;
            this.wczytaj.Click += new System.EventHandler(this.wczytaj_Click);
            // 
            // zapisz
            // 
            this.zapisz.Enabled = false;
            this.zapisz.Location = new System.Drawing.Point(112, 4);
            this.zapisz.Margin = new System.Windows.Forms.Padding(4);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(100, 28);
            this.zapisz.TabIndex = 1;
            this.zapisz.Text = "zapisz";
            this.zapisz.UseVisualStyleBackColor = true;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(13, 10, 13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Szerokosc";
            // 
            // szerokosc
            // 
            this.szerokosc.Location = new System.Drawing.Point(320, 4);
            this.szerokosc.Margin = new System.Windows.Forms.Padding(4);
            this.szerokosc.Name = "szerokosc";
            this.szerokosc.Size = new System.Drawing.Size(132, 22);
            this.szerokosc.TabIndex = 7;
            this.szerokosc.Text = "63";
            this.szerokosc.TextChanged += new System.EventHandler(this.szerokosc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(13, 10, 13, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wysokosc";
            // 
            // wysokosc
            // 
            this.wysokosc.Location = new System.Drawing.Point(558, 4);
            this.wysokosc.Margin = new System.Windows.Forms.Padding(4);
            this.wysokosc.Name = "wysokosc";
            this.wysokosc.Size = new System.Drawing.Size(132, 22);
            this.wysokosc.TabIndex = 8;
            this.wysokosc.Text = "89";
            this.wysokosc.TextChanged += new System.EventHandler(this.szerokosc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(707, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(13, 10, 13, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Odstep";
            // 
            // odstepX
            // 
            this.odstepX.Location = new System.Drawing.Point(778, 4);
            this.odstepX.Margin = new System.Windows.Forms.Padding(4);
            this.odstepX.Name = "odstepX";
            this.odstepX.Size = new System.Drawing.Size(48, 22);
            this.odstepX.TabIndex = 9;
            this.odstepX.Text = "0";
            this.odstepX.TextChanged += new System.EventHandler(this.szerokosc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(899, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(13, 10, 13, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "mm";
            // 
            // marks
            // 
            this.marks.AutoSize = true;
            this.marks.Location = new System.Drawing.Point(946, 10);
            this.marks.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.marks.Name = "marks";
            this.marks.Size = new System.Drawing.Size(68, 21);
            this.marks.TabIndex = 10;
            this.marks.Text = "marks";
            this.marks.UseVisualStyleBackColor = true;
            this.marks.CheckedChanged += new System.EventHandler(this.szerokosc_TextChanged);
            // 
            // pliki
            // 
            this.pliki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pliki.FormattingEnabled = true;
            this.pliki.ItemHeight = 16;
            this.pliki.Location = new System.Drawing.Point(4, 66);
            this.pliki.Margin = new System.Windows.Forms.Padding(4);
            this.pliki.Name = "pliki";
            this.pliki.Size = new System.Drawing.Size(259, 476);
            this.pliki.TabIndex = 3;
            this.pliki.SelectedIndexChanged += new System.EventHandler(this.pliki_SelectedIndexChanged);
            // 
            // dsf
            // 
            this.dsf.ColumnCount = 3;
            this.dsf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dsf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dsf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dsf.Controls.Add(this.prawy, 1, 0);
            this.dsf.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.dsf.Controls.Add(this.lewy, 0, 0);
            this.dsf.Controls.Add(this.flowLayoutPanel4, 0, 1);
            this.dsf.Controls.Add(this.panel1, 2, 1);
            this.dsf.Controls.Add(this.karty, 2, 0);
            this.dsf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsf.Location = new System.Drawing.Point(271, 66);
            this.dsf.Margin = new System.Windows.Forms.Padding(4);
            this.dsf.Name = "dsf";
            this.dsf.RowCount = 2;
            this.dsf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dsf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.dsf.Size = new System.Drawing.Size(1077, 476);
            this.dsf.TabIndex = 4;
            // 
            // prawy
            // 
            this.prawy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prawy.Location = new System.Drawing.Point(419, 4);
            this.prawy.Margin = new System.Windows.Forms.Padding(4);
            this.prawy.Name = "prawy";
            this.prawy.Size = new System.Drawing.Size(407, 406);
            this.prawy.TabIndex = 3;
            this.prawy.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.revers);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(419, 418);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(407, 54);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // revers
            // 
            this.revers.FormattingEnabled = true;
            this.revers.Location = new System.Drawing.Point(4, 4);
            this.revers.Margin = new System.Windows.Forms.Padding(4);
            this.revers.Name = "revers";
            this.revers.Size = new System.Drawing.Size(253, 24);
            this.revers.TabIndex = 0;
            this.revers.SelectedIndexChanged += new System.EventHandler(this.revers_SelectedIndexChanged);
            // 
            // lewy
            // 
            this.lewy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lewy.Location = new System.Drawing.Point(4, 4);
            this.lewy.Margin = new System.Windows.Forms.Padding(4);
            this.lewy.Name = "lewy";
            this.lewy.Size = new System.Drawing.Size(407, 406);
            this.lewy.TabIndex = 2;
            this.lewy.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.para);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(4, 418);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(407, 54);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // para
            // 
            this.para.Enabled = false;
            this.para.Location = new System.Drawing.Point(4, 4);
            this.para.Margin = new System.Windows.Forms.Padding(4);
            this.para.Name = "para";
            this.para.Size = new System.Drawing.Size(100, 28);
            this.para.TabIndex = 0;
            this.para.Text = "dodaj parę";
            this.para.UseVisualStyleBackColor = true;
            this.para.Click += new System.EventHandler(this.para_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.projektlabel);
            this.panel1.Controls.Add(this.kart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(833, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 56);
            this.panel1.TabIndex = 6;
            // 
            // delete
            // 
            this.delete.Enabled = false;
            this.delete.Location = new System.Drawing.Point(161, 1);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "Usuń";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // projektlabel
            // 
            this.projektlabel.AutoSize = true;
            this.projektlabel.Location = new System.Drawing.Point(3, 37);
            this.projektlabel.Name = "projektlabel";
            this.projektlabel.Size = new System.Drawing.Size(0, 17);
            this.projektlabel.TabIndex = 1;
            // 
            // kart
            // 
            this.kart.AutoSize = true;
            this.kart.Location = new System.Drawing.Point(3, 5);
            this.kart.Name = "kart";
            this.kart.Size = new System.Drawing.Size(0, 17);
            this.kart.TabIndex = 0;
            // 
            // karty
            // 
            this.karty.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.karty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.karty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KartyCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.karty.DefaultCellStyle = dataGridViewCellStyle2;
            this.karty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.karty.Location = new System.Drawing.Point(833, 3);
            this.karty.MultiSelect = false;
            this.karty.Name = "karty";
            this.karty.RowHeadersVisible = false;
            this.karty.RowHeadersWidth = 80;
            this.karty.RowTemplate.Height = 24;
            this.karty.Size = new System.Drawing.Size(241, 408);
            this.karty.TabIndex = 7;
            this.karty.SelectionChanged += new System.EventHandler(this.karty_SelectionChanged);
            // 
            // KartyCol
            // 
            this.KartyCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KartyCol.HeaderText = "Karty";
            this.KartyCol.Name = "KartyCol";
            // 
            // openProject
            // 
            this.openProject.FileName = "openFileDialog1";
            // 
            // odstepY
            // 
            this.odstepY.Location = new System.Drawing.Point(834, 4);
            this.odstepY.Margin = new System.Windows.Forms.Padding(4);
            this.odstepY.Name = "odstepY";
            this.odstepY.Size = new System.Drawing.Size(48, 22);
            this.odstepY.TabIndex = 11;
            this.odstepY.Text = "0";
            this.odstepY.TextChanged += new System.EventHandler(this.szerokosc_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 546);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.dsf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prawy)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lewy)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button katalog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button generuj;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button wczytaj;
        private System.Windows.Forms.Button zapisz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox szerokosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wysokosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox odstepX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox marks;
        private System.Windows.Forms.ListBox pliki;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.SaveFileDialog saveProject;
        private System.Windows.Forms.TableLayoutPanel dsf;
        private System.Windows.Forms.PictureBox prawy;
        private System.Windows.Forms.PictureBox lewy;
        private System.Windows.Forms.OpenFileDialog openProject;
        private System.Windows.Forms.SaveFileDialog savePDF;
        private System.Windows.Forms.Button para;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ComboBox revers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label projektlabel;
        private System.Windows.Forms.Label kart;
        private System.Windows.Forms.DataGridView karty;
        private System.Windows.Forms.DataGridViewTextBoxColumn KartyCol;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.CheckBox duplex;
        private System.Windows.Forms.TextBox odstepY;
    }
}

