namespace LabADO_1512159_1512624_1512670
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTuoiMax = new System.Windows.Forms.TextBox();
            this.tbxTuoiMin = new System.Windows.Forms.TextBox();
            this.trbrTuoiMax = new System.Windows.Forms.TrackBar();
            this.trbrTuoiMin = new System.Windows.Forms.TrackBar();
            this.chbxTuoi = new System.Windows.Forms.CheckBox();
            this.tbxTen = new System.Windows.Forms.TextBox();
            this.chbxTen = new System.Windows.Forms.CheckBox();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.chbxLop = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.btnThemSinhVien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbrTuoiMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbrTuoiMin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách lớp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 197);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 289);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(760, 260);
            this.dataGridView2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách sinh viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxTuoiMax);
            this.panel1.Controls.Add(this.tbxTuoiMin);
            this.panel1.Controls.Add(this.trbrTuoiMax);
            this.panel1.Controls.Add(this.trbrTuoiMin);
            this.panel1.Controls.Add(this.chbxTuoi);
            this.panel1.Controls.Add(this.tbxTen);
            this.panel1.Controls.Add(this.chbxTen);
            this.panel1.Controls.Add(this.cbxLop);
            this.panel1.Controls.Add(this.chbxLop);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(388, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 235);
            this.panel1.TabIndex = 4;
            // 
            // btnLoc
            // 
            this.btnLoc.AutoSize = true;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Location = new System.Drawing.Point(64, 192);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(111, 28);
            this.btnLoc.TabIndex = 18;
            this.btnLoc.Text = "Lọc Danh sách";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Từ";
            // 
            // tbxTuoiMax
            // 
            this.tbxTuoiMax.Enabled = false;
            this.tbxTuoiMax.Location = new System.Drawing.Point(294, 153);
            this.tbxTuoiMax.Name = "tbxTuoiMax";
            this.tbxTuoiMax.ReadOnly = true;
            this.tbxTuoiMax.Size = new System.Drawing.Size(36, 22);
            this.tbxTuoiMax.TabIndex = 15;
            this.tbxTuoiMax.TabStop = false;
            // 
            // tbxTuoiMin
            // 
            this.tbxTuoiMin.Enabled = false;
            this.tbxTuoiMin.Location = new System.Drawing.Point(139, 153);
            this.tbxTuoiMin.Name = "tbxTuoiMin";
            this.tbxTuoiMin.ReadOnly = true;
            this.tbxTuoiMin.Size = new System.Drawing.Size(36, 22);
            this.tbxTuoiMin.TabIndex = 14;
            this.tbxTuoiMin.TabStop = false;
            // 
            // trbrTuoiMax
            // 
            this.trbrTuoiMax.Enabled = false;
            this.trbrTuoiMax.Location = new System.Drawing.Point(225, 121);
            this.trbrTuoiMax.Maximum = 60;
            this.trbrTuoiMax.Minimum = 18;
            this.trbrTuoiMax.Name = "trbrTuoiMax";
            this.trbrTuoiMax.Size = new System.Drawing.Size(146, 45);
            this.trbrTuoiMax.TabIndex = 13;
            this.trbrTuoiMax.Value = 18;
            this.trbrTuoiMax.ValueChanged += new System.EventHandler(this.trbrTuoiMax_ValueChanged);
            // 
            // trbrTuoiMin
            // 
            this.trbrTuoiMin.Enabled = false;
            this.trbrTuoiMin.Location = new System.Drawing.Point(77, 121);
            this.trbrTuoiMin.Maximum = 60;
            this.trbrTuoiMin.Minimum = 18;
            this.trbrTuoiMin.Name = "trbrTuoiMin";
            this.trbrTuoiMin.Size = new System.Drawing.Size(146, 45);
            this.trbrTuoiMin.TabIndex = 12;
            this.trbrTuoiMin.Value = 18;
            this.trbrTuoiMin.ValueChanged += new System.EventHandler(this.trbrTuoiMin_ValueChanged);
            // 
            // chbxTuoi
            // 
            this.chbxTuoi.AutoSize = true;
            this.chbxTuoi.Location = new System.Drawing.Point(17, 121);
            this.chbxTuoi.Name = "chbxTuoi";
            this.chbxTuoi.Size = new System.Drawing.Size(54, 20);
            this.chbxTuoi.TabIndex = 10;
            this.chbxTuoi.Text = "Tuổi";
            this.chbxTuoi.UseVisualStyleBackColor = true;
            this.chbxTuoi.CheckStateChanged += new System.EventHandler(this.chbxTuoi_CheckStateChanged);
            // 
            // tbxTen
            // 
            this.tbxTen.Enabled = false;
            this.tbxTen.Location = new System.Drawing.Point(74, 81);
            this.tbxTen.Name = "tbxTen";
            this.tbxTen.Size = new System.Drawing.Size(234, 22);
            this.tbxTen.TabIndex = 9;
            // 
            // chbxTen
            // 
            this.chbxTen.AutoSize = true;
            this.chbxTen.Location = new System.Drawing.Point(17, 82);
            this.chbxTen.Name = "chbxTen";
            this.chbxTen.Size = new System.Drawing.Size(51, 20);
            this.chbxTen.TabIndex = 8;
            this.chbxTen.Text = "Tên";
            this.chbxTen.UseVisualStyleBackColor = true;
            this.chbxTen.CheckedChanged += new System.EventHandler(this.chbxTen_CheckedChanged);
            // 
            // cbxLop
            // 
            this.cbxLop.Enabled = false;
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(74, 40);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(234, 24);
            this.cbxLop.TabIndex = 7;
            // 
            // chbxLop
            // 
            this.chbxLop.AutoSize = true;
            this.chbxLop.Location = new System.Drawing.Point(17, 42);
            this.chbxLop.Name = "chbxLop";
            this.chbxLop.Size = new System.Drawing.Size(50, 20);
            this.chbxLop.TabIndex = 6;
            this.chbxLop.Text = "Lớp";
            this.chbxLop.UseVisualStyleBackColor = true;
            this.chbxLop.CheckedChanged += new System.EventHandler(this.chbxLop_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lọc danh sách sinh viên theo tiêu chí:";
            // 
            // btnThemLop
            // 
            this.btnThemLop.AutoSize = true;
            this.btnThemLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLop.Location = new System.Drawing.Point(258, 9);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(111, 28);
            this.btnThemLop.TabIndex = 19;
            this.btnThemLop.Text = "Thêm lớp";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.AutoSize = true;
            this.btnThemSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSinhVien.Location = new System.Drawing.Point(258, 256);
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.Size = new System.Drawing.Size(111, 28);
            this.btnThemSinhVien.TabIndex = 20;
            this.btnThemSinhVien.Text = "Thêm sinh viên";
            this.btnThemSinhVien.UseVisualStyleBackColor = true;
            this.btnThemSinhVien.Click += new System.EventHandler(this.btnThemSinhVien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnThemSinhVien);
            this.Controls.Add(this.btnThemLop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "LabADO_1512159_1512624_1512670";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbrTuoiMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbrTuoiMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trbrTuoiMin;
        private System.Windows.Forms.CheckBox chbxTuoi;
        private System.Windows.Forms.TextBox tbxTen;
        private System.Windows.Forms.CheckBox chbxTen;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.CheckBox chbxLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTuoiMax;
        private System.Windows.Forms.TextBox tbxTuoiMin;
        private System.Windows.Forms.TrackBar trbrTuoiMax;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.Button btnThemSinhVien;
    }
}

