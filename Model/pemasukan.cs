using project_pbo.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_pbo.Model
{
    internal class pemasukan
    {
        private string _nominal;
        private string _keterangan;
        private string _sumber_dana;

        ConnectionCls server;
        DataTable temp;
        string query;


        public pemasukan()
        {
            _nominal = "";
            _keterangan = "";
            _sumber_dana = "";
            server = new ConnectionCls();
            temp = new DataTable();
            query = "";
        }

        public string setNominal
        {
            set { _nominal = value; }
        }

        public string setKeterangan
        {
            set { _keterangan = value; }
        }


        public string setSumberDana
        {
            set { _sumber_dana = value; }
        }

        public bool ApakahAda(string id)
        {
            bool cek = false;
            query = "select * from pemasukan where nominal = '" + id + "'";

            temp = server.Query(query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public DataTable TampilkanSemua()
        {
            query = "SELECT p.id, p.nominal, p.keterangan, j.nama_sumdana FROM pemasukan p JOIN sumber_dana j ON p.id_sumdana = j.id";
            return server.Query(query);
        }

        public int simpanData()
        {
            int result = -1;
            int id_sumdana = GetIDSumberDana("dana iom");

            query = "insert into pemasukan (nominal, keterangan, id_sumdana) values ('" + _nominal + "', '" + _keterangan + "'," + id_sumdana +")";

            result = server.NonQuery(query);
            try
            {
                if (result < 0)
                {
                    throw new Exception("Gagal Menyimpan Data");
                }
            }
            catch (Exception e)
            {
            }
            return result;
        }

        public int ubahData(string id)
        {
            int result = -1;
            int id_sumdana = GetIDSumberDana(_sumber_dana);

            query = "UPDATE pemasukan SET keterangan ='"  + _keterangan + "',nominal='" + _nominal + "', id_sumdana='" + id_sumdana + "' WHERE id='" + id + "'";

            result = server.NonQuery(query);
            try
            {
                if (result < 0)
                {
                    throw new Exception("Gagal Menyimpan Data");
                }
            }
            catch (Exception e)
            {
            }
            return result;
        }


        public int HapusData(string id)
        {
            int result = -1;

            query = "delete from pemasukan where id = '" + id + "'";

            try
            {
                result = server.NonQuery(query);
                if (result < 0)
                {
                    throw new Exception("Gagal menghapus data.");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }


        public int GetIDSumberDana(string SumberDana)
        {
            int id = -1; // Nilai default jika tidak ada hasil yang ditemukan atau terjadi kesalahan

            query = "SELECT id FROM sumber_dana WHERE nama_sumdana = '" + SumberDana + "'";
            DataTable result = server.Query(query);

            if (result.Rows.Count > 0)
            {
                // Mengambil nilai dari kolom "id" sebagai integer
                id = Convert.ToInt32(result.Rows[0]["id"]);
            }

            return id;
        }

        public DataTable isiCombo()
        {
            query = "SELECT nama_sumdana FROM sumber_dana";
            return server.Query(query);
        }
        public DataTable CariDgNama(string keterangan)
        {
            query = "select p.nominal, p.keterangan, j.nama_sumdana from pemasukan p join sumber_dana j on p.id_sumdana = j.id where p.keterangan like '%" + keterangan + "%'";
            return server.Query(query);
        }
    }
}
