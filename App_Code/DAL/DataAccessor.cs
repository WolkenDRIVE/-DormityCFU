using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace DormityCFU.App_Code.DAL
{
    public class DataAccessor
    {
        private static OdbcConnection conn = null;
        public static OdbcConnection Conn
        {
            get
            {
                if (conn == null)
                {
                    conn = new OdbcConnection(Config.ConnectionString);
                }
                return conn;
            }
        }
        public static void CreateConnection(string connectionString)
        {
            conn = new OdbcConnection(connectionString);
        }

        private static OdbcCommand cmd = null;
        private static OdbcDataAdapter dataAdapter = null;

        public static Student SelectStudent(int id)
        {
            Student result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "Select ";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = Student.Map(dataTable.Rows[0]);
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                return result;
            }
        }
        public static List<Student> SelectStudent()
        {
            List<Student> result = new List<Student>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT .* FROM ";
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                int i = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    result.Add(Student.Map(row, i));
                    i++;
                }
            }
            return result;
        }
        public static void DeleteStudent(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM ";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[]", id);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public static void UpdateStudent(Student entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE ";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[]", entity.);
                    cmd.Parameters.AddWithValue("[]", entity.);
                    cmd.Parameters.AddWithValue("[]", entity.);
                    cmd.Parameters.AddWithValue("[]", entity.);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public static int InsertStudent(Student entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO ";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[]", entity.);
                    cmd.Parameters.AddWithValue("[]", entity.);
                    cmd.Parameters.AddWithValue("[]", entity.);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    object o = cmd.ExecuteScalar();
                    if (o != null)
                    {
                        result = int.Parse(o.ToString());
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
    }
}