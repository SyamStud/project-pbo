using project_pbo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_pbo.Interface
{
    public partial class Form1 : Form

    {
        pemasukan pemasukan = new pemasukan();
        public Form1()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bersihkan();
            tampilGrid();
            isiCombo();
            namajur_cmb.Items.Insert(0, "-Pilih Data-");
            namajur_cmb.SelectedIndex = 0;
        }

        void bersihkan()
        {
            nominal_txt.Clear();
            ket_txt.Clear();
            ket_txt.Focus();
        }

        private void hapusbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah data akan dihapus ?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                // Hapus data program studi
               pemasukan.HapusData(nominal_txt.Text);

            // Tampilkan data terbaru di DataGridView
            tampilGrid();

            // Bersihkan input
            bersihkan();
            namajur_cmb.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Bersihkan input
            bersihkan();
            // Membersihkan ComboBox
            namajur_cmb.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void isiCombo()
        {
            // Isi combo box dengan data nama jurusan
            DataTable dt = pemasukan.isiCombo();
            foreach (DataRow row in dt.Rows)
            {
                namajur_cmb.Items.Add(row["nama_sumdana"].ToString());
            }
        }

        void belangBelang(DataGridView dgv)
        {
            foreach (DataGridViewRow baris in dgv.Rows)
            {
                foreach (DataGridViewCell kolom in baris.Cells)
                {
                    if (baris.Index % 2 == 1)
                    {
                        kolom.Style.BackColor = Color.WhiteSmoke;
                    }
                    else
                        kolom.Style.BackColor = Color.LightGray;
                }
            }
        }

        void tampilGrid()
        {
            if (namacari_txt.Text == "")
            {
                pemasukan_dgv.DataSource = pemasukan.TampilkanSemua();
            }
            else
            {
                pemasukan_dgv.DataSource = pemasukan.CariDgNama(namacari_txt.Text);
            }
            belangBelang(pemasukan_dgv);
        }

        private void pemasukan_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void namajur_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void simpanbtn_Click(object sender, EventArgs e)
        {
            if (!pemasukan.ApakahAda(id_txt.Text))
            {
                pemasukan.setNominal = nominal_txt.Text;
                pemasukan.setKeterangan = ket_txt.Text; // Menggunakan namaProdi_txt.Text

                pemasukan.setSumberDana = namajur_cmb.Text;
                if (pemasukan.simpanData() > 0)
                {
                    MessageBox.Show("Data berhasil disimpan.",
                        "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    tampilGrid();
                    namajur_cmb.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Data gagal disimpan.",
                        "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    tampilGrid();
                    namajur_cmb.SelectedIndex = 0;
                }
            }
            else
            {
                if (MessageBox.Show("Apakah anda yakin akan mengubah data?", "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   pemasukan.setNominal = nominal_txt.Text;
                   pemasukan.setKeterangan = ket_txt.Text;
                   pemasukan.setSumberDana = namajur_cmb.Text;

                    if (pemasukan.ubahData(id_txt.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil diubah",
                        "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        tampilGrid();
                        namajur_cmb.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Data gagal diubah.",
                            "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        tampilGrid();
                        namajur_cmb.SelectedIndex = 0;
                    }
                }
            }
        }

        private void hapusbtn_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah data akan dihapus ?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                // Hapus data program studi
                pemasukan.HapusData(id_txt.Text);

            // Tampilkan data terbaru di DataGridView
            tampilGrid();

            // Bersihkan input
            bersihkan();
            namajur_cmb.SelectedIndex = 0;
        }

        private void pemasukan_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.pemasukan_dgv.Rows[e.RowIndex];
                id_txt.Text = baris.Cells[0].Value.ToString();
                nominal_txt.Text = baris.Cells[1].Value.ToString();
                ket_txt.Text = baris.Cells[2].Value.ToString();
            }
        }
    }
    }