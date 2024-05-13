namespace project_pbo.Interface
{
    partial class SumberDana
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
            this.gridView = new System.Windows.Forms.DataGridView();
            this.sumberTxt = new System.Windows.Forms.TextBox();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cariTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.batalBtn = new System.Windows.Forms.Button();
            this.tutupBtn = new System.Windows.Forms.Button();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.sumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sumber});
            this.gridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridView.Location = new System.Drawing.Point(0, 431);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersWidth = 62;
            this.gridView.RowTemplate.Height = 28;
            this.gridView.Size = new System.Drawing.Size(1155, 387);
            this.gridView.TabIndex = 0;
            // 
  
            // simpanBtn
            // 
            this.simpanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpanBtn.Location = new System.Drawing.Point(0, 196);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(252, 63);
            this.simpanBtn.TabIndex = 3;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = true;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sumber  Dana";
            // 
            // cariTxt
            // 
            this.cariTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariTxt.Location = new System.Drawing.Point(76, 325);
            this.cariTxt.Name = "cariTxt";
            this.cariTxt.Size = new System.Drawing.Size(1079, 39);
            this.cariTxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-5, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cari";
            // 
            // hapusBtn
            // 
            this.hapusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapusBtn.Location = new System.Drawing.Point(298, 196);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(252, 63);
            this.hapusBtn.TabIndex = 10;
            this.hapusBtn.Text = "Hapus";
            this.hapusBtn.UseVisualStyleBackColor = true;
            // 
            // batalBtn
            // 
            this.batalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batalBtn.Location = new System.Drawing.Point(597, 196);
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(252, 63);
            this.batalBtn.TabIndex = 11;
            this.batalBtn.Text = "Batal";
            this.batalBtn.UseVisualStyleBackColor = true;
            // 
            // tutupBtn
            // 
            this.tutupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutupBtn.Location = new System.Drawing.Point(903, 196);
            this.tutupBtn.Name = "tutupBtn";
            this.tutupBtn.Size = new System.Drawing.Size(252, 63);
            this.tutupBtn.TabIndex = 12;
            this.tutupBtn.Text = "Tutup";
            this.tutupBtn.UseVisualStyleBackColor = true;
            // 
            // idTxt
            // 
            this.idTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxt.HideSelection = false;
            this.idTxt.Location = new System.Drawing.Point(191, 32);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(964, 39);
            this.idTxt.TabIndex = 13;
            this.idTxt.Visible = false;
            // 
            // sumber
            // 
            this.sumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sumber.DataPropertyName = "sumber";
            this.sumber.HeaderText = "SumberDana";
            this.sumber.MinimumWidth = 8;
            this.sumber.Name = "sumber";
            this.sumber.ReadOnly = true;
            // 
            // SumberDana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 818);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.tutupBtn);
            this.Controls.Add(this.batalBtn);
            this.Controls.Add(this.hapusBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cariTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.sumberTxt);
            this.Controls.Add(this.gridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SumberDana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SumberDana";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.TextBox sumberTxt;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cariTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hapusBtn;
        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.Button tutupBtn;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumber;
    }
}