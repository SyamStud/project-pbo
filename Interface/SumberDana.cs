using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_pbo.Model;

namespace project_pbo.Interface
{
    public partial class SumberDana : Form
    {
        private sumberDana sumber_dana = new sumberDana();

        public SumberDana()
        {
            InitializeComponent();
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            if (!sumber_dana.isExist(sumberTxt.Text))
            {
                if (sumberDana.store() > 0)
                {
                    MessageBox.Show("Data Berhasil disimpan.",
                        "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kodeTxt.Text = "";
                    sumberDanaTxt.Text = "";
                    jurusanDgv.DataSource = sumberDana.showAll();
                    kodeTxt.Text = sumberDana.createCode();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data.",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (MessageBox.Show("Apakah Data akan diubah?",
                    "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sumberDana.Kode_sumberDana = kodeTxt.Text;
                    sumberDana.Nama_sumberDana = sumberDanaTxt.Text;
                    sumberDana.Nama_Jurusan = jurusanCmb.Text;

                    if (sumberDana.update(kodeTxt.Text) > 0)
                    {
                        MessageBox.Show("Data Berhasil diubah.",
                            "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kodeTxt.Text = "";
                        sumberDanaTxt.Text = "";
                        jurusanDgv.DataSource = sumberDana.showAll();
                        kodeTxt.Text = sumberDana.createCode();
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengubah data.",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}