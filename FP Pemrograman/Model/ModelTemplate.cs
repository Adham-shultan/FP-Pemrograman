using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace FP_Pemrograman.Model
{
    class ModelTemplate
    {
        private static SqlConnection conn;
        private SqlCommand commad;
        private bool result;
        public static SqlConnection GetConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source = LAPTOP-7ULPQ249\\SQLEXPRESS;" +
                                    "Initial Catalog = FP;" +
                                    "Integrated Security = True";

            return conn;
        }

        public void cekKoneksi()
        {
            GetConnection();
            try
            {
                conn.Open();
                MessageBox.Show("Koneksi Sukses");

            }
            catch(SqlException se)
            {
                MessageBox.Show("Koneksi Gagal" + se);
            }
        }
    }
}
