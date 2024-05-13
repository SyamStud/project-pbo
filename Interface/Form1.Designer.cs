namespace project_pbo.Interface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.namajur_cmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ket_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hapusbtn = new System.Windows.Forms.Button();
            this.simpanbtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pemasukan_dgv = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.namacari_txt = new System.Windows.Forms.TextBox();
            this.nominal_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pemasukan_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // namajur_cmb
            // 
            this.namajur_cmb.FormattingEnabled = true;
            this.namajur_cmb.Location = new System.Drawing.Point(297, 208);
            this.namajur_cmb.Name = "namajur_cmb";
            this.namajur_cmb.Size = new System.Drawing.Size(218, 28);
            this.namajur_cmb.TabIndex = 33;
            this.namajur_cmb.SelectedIndexChanged += new System.EventHandler(this.namajur_cmb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "SUMBER DANA";
            // 
            // ket_txt
            // 
            this.ket_txt.Location = new System.Drawing.Point(297, 135);
            this.ket_txt.Multiline = true;
            this.ket_txt.Name = "ket_txt";
            this.ket_txt.Size = new System.Drawing.Size(218, 56);
            this.ket_txt.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "NOMINAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "KETERANGAN";
            // 
            // hapusbtn
            // 
            this.hapusbtn.BackColor = System.Drawing.Color.Red;
            this.hapusbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapusbtn.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapusbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hapusbtn.Location = new System.Drawing.Point(259, 297);
            this.hapusbtn.Name = "hapusbtn";
            this.hapusbtn.Size = new System.Drawing.Size(121, 48);
            this.hapusbtn.TabIndex = 37;
            this.hapusbtn.Text = "hapus";
            this.hapusbtn.UseVisualStyleBackColor = false;
            this.hapusbtn.Click += new System.EventHandler(this.hapusbtn_Click_1);
            // 
            // simpanbtn
            // 
            this.simpanbtn.BackColor = System.Drawing.Color.ForestGreen;
            this.simpanbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpanbtn.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpanbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.simpanbtn.Location = new System.Drawing.Point(96, 297);
            this.simpanbtn.Name = "simpanbtn";
            this.simpanbtn.Size = new System.Drawing.Size(121, 48);
            this.simpanbtn.TabIndex = 36;
            this.simpanbtn.Text = "simpan";
            this.simpanbtn.UseVisualStyleBackColor = false;
            this.simpanbtn.Click += new System.EventHandler(this.simpanbtn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(413, 297);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 48);
            this.button5.TabIndex = 39;
            this.button5.Text = "batal";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(576, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 48);
            this.button4.TabIndex = 38;
            this.button4.Text = "tutup";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pemasukan_dgv
            // 
            this.pemasukan_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pemasukan_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pemasukan_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pemasukan_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_id,
            this.c_kode,
            this.c_nama,
            this.Column1});
            this.pemasukan_dgv.Location = new System.Drawing.Point(32, 445);
            this.pemasukan_dgv.Name = "pemasukan_dgv";
            this.pemasukan_dgv.RowHeadersWidth = 62;
            this.pemasukan_dgv.RowTemplate.Height = 28;
            this.pemasukan_dgv.Size = new System.Drawing.Size(834, 325);
            this.pemasukan_dgv.TabIndex = 40;
            this.pemasukan_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pemasukan_dgv_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "Pencarian Berdasarkan Nama";
            // 
            // namacari_txt
            // 
            this.namacari_txt.Location = new System.Drawing.Point(32, 388);
            this.namacari_txt.Multiline = true;
            this.namacari_txt.Name = "namacari_txt";
            this.namacari_txt.Size = new System.Drawing.Size(834, 37);
            this.namacari_txt.TabIndex = 41;
            // 
            // nominal_txt
            // 
            this.nominal_txt.Location = new System.Drawing.Point(297, 76);
            this.nominal_txt.Multiline = true;
            this.nominal_txt.Name = "nominal_txt";
            this.nominal_txt.Size = new System.Drawing.Size(218, 41);
            this.nominal_txt.TabIndex = 43;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(297, 29);
            this.id_txt.Multiline = true;
            this.id_txt.Name = "id_txt";
            this.id_txt.ReadOnly = true;
            this.id_txt.Size = new System.Drawing.Size(218, 41);
            this.id_txt.TabIndex = 44;
            this.id_txt.Visible = false;
            // 
            // c_id
            // 
            this.c_id.DataPropertyName = "id";
            this.c_id.HeaderText = "id";
            this.c_id.MinimumWidth = 8;
            this.c_id.Name = "c_id";
            this.c_id.Width = 150;
            // 
            // c_kode
            // 
            this.c_kode.DataPropertyName = "nominal";
            this.c_kode.HeaderText = "NOMINAL";
            this.c_kode.MinimumWidth = 8;
            this.c_kode.Name = "c_kode";
            this.c_kode.Width = 170;
            // 
            // c_nama
            // 
            this.c_nama.DataPropertyName = "keterangan";
            this.c_nama.HeaderText = "KETERANGAN";
            this.c_nama.MinimumWidth = 8;
            this.c_nama.Name = "c_nama";
            this.c_nama.Width = 250;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nama_sumdana";
            this.Column1.HeaderText = "SUMBER DANA";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(937, 794);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.nominal_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.namacari_txt);
            this.Controls.Add(this.pemasukan_dgv);
            this.Controls.Add(this.hapusbtn);
            this.Controls.Add(this.simpanbtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.namajur_cmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ket_txt);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pemasukan_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox namajur_cmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ket_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button hapusbtn;
        private System.Windows.Forms.Button simpanbtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView pemasukan_dgv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox namacari_txt;
        private System.Windows.Forms.TextBox nominal_txt;
        public System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

