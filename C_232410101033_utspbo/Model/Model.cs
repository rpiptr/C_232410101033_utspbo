using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_232410101033_utspbo.Model
{
    public abstract class Connection
    {
        private readonly string addres = "Host=localhost;Username=postgres;Password=raffyputra12;Database=uts_pbo";
        protected NpgsqlConnection conn;
        protected bool Execute_No_Return(string query)
        {
            conn = new NpgsqlConnection(addres);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }

        protected NpgsqlDataReader Execute_With_Return(string query)
        {
            conn = new NpgsqlConnection(addres);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            NpgsqlDataReader data = cmd.ExecuteReader();
            return data;
        }
    }
    internal class Model
    {
    }
}
