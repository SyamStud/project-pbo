using project_pbo.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_pbo.Model
{
    internal class sumberDana
    {
        private string sumber;

        // CONNECTION ATTRIBUTE
        private ConnectionCls conn;

        private DataTable temp;
        private string query;

        public sumberDana()
        {
            sumber = "";

            conn = new ConnectionCls();
            temp = new DataTable();
            query = "";
        }

        public string Sumber
        {
            set { sumber = value; }
        }

        public bool isExist(string sumber)
        {
            query = "SELECT * FROM sumber-dana WHERE sumber = '" + sumber + "'";
            temp = conn.Query(query);

            if (temp.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int store()
        {
            int result = -1;
            query = "INSERT INTO sumber-dana VALUES ('" + sumber + "')";

            try
            {
                result = conn.NonQuery(query);

                if (result > 0)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Data Gagal Disimpan");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int update(int id)
        {
            int result = -1;
            query = "UPDATE sumber-dana SET sumber = '" + sumber + "' WHERE id = '" + id + "'";

            try
            {
                result = conn.NonQuery(query);

                if (result > 0)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Data Gagal Diubah");
                }
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int delete(int id)
        {
            int result = -1;
            query = "DELETE FROM sumber-dana WHERE id = '" + id + "'";
            try
            {
                result = conn.NonQuery(query);

                if (result > 0)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Data Gagal Dihapus");
                }
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public DataTable showAll()
        {
            DataTable data = new DataTable();
            query = "SELECT * FROM sumber-dana";
            data = conn.Query(query);
            return data;
        }

        public DataTable search(string sumber)
        {
            DataTable data = new DataTable();
            query = "SELECT * FROM sumber-dana WHERE sumber LIKE '%" + sumber + "%'";
            data = conn.Query(query);
            return data;
        }
    }
}