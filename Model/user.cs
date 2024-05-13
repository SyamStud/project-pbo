using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using project_pbo.Configuration;

namespace project_pbo.Model
{
    internal class user
    {
        private string _user;
        private string _password;
        ConnectionCls koneksi;
        DataTable temp;
        string Query;
        public user()
        {
            koneksi = new ConnectionCls();
            temp = new DataTable();
            Query = "";
        }

        public string user_id
        {
            set { _user = value; }
            get { return _user; }

        }

        public string password
        {
            set { password = value; }
        }
        public bool CekLogin(string username, string password)
        {
            bool cek = false;
            //Query = "select * from pengguna where user_id='" + username + "'and password= '"+password+"'";
            Query = "select * from pengguna where username='" + username + "'and password= '" + password + "'";
            temp = koneksi.Query(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public string ambilNamaPengguna(string username, string password)
        {
            string nama = "";
            Query = "select nama_pengguna from pengguna " +
                "where user_id='" + username + "' and password='" +
                password + "'";
            temp = koneksi.Query(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow row in temp.Rows)
                {
                    nama = row[0].ToString();
                }
            }
            return nama;
        }
    }
}
