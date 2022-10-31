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

        #region Student
        public static Student SelectStudent(int id)
        {
            Student result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT Student.*, Room.NumbRoom, Dormitory.IdDormitory, Directions.Direction, Groups.Course FROM Directions INNER JOIN(Groups INNER JOIN (Dormitory INNER JOIN (Room INNER JOIN Student ON Room.IdRoom = Student.IdRoom) ON Dormitory.IdDormitory = Room.IdDormitory) ON Groups.IdGroup = Student.IdGroup) ON Directions.IdDirection = Groups.IdDirection WHERE IdStudent";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[Student] [IdStudent]" , id);
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
        public static List<Student> SelectStudentX()
        {
            List<Student> result = new List<Student>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT Student.*, Room.NumbRoom, Dormitory.IdDormitory, Directions.Direction, Groups.Course FROM Directions INNER JOIN(Groups INNER JOIN (Dormitory INNER JOIN (Room INNER JOIN Student ON Room.IdRoom = Student.IdRoom) ON Dormitory.IdDormitory = Room.IdDormitory) ON Groups.IdGroup = Student.IdGroup) ON Directions.IdDirection = Groups.IdDirection";
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
                    cmd.CommandText = "DELETE FROM [Student] WHERE [IdStudent]";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdStudent]", id);
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
                    cmd.CommandText = "UPDATE [Student] SET [SecondName]=?, [FirstName]=?, [Surname]=?, [DateOfRegistr]=?, [DateOfBirth]=?, [PhoneNumb]=?, [HAdderss]=?, WHERE [IdStudent]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[SecondName]", entity.SecondName);
                    cmd.Parameters.AddWithValue("[FirstName]", entity.FirstName);
                    cmd.Parameters.AddWithValue("[Surname]", entity.Surname);
                    cmd.Parameters.AddWithValue("[DateOfRegistr]", entity.DateOfRegistr);
                    cmd.Parameters.AddWithValue("[DateOfBirth]", entity.DateOfBirth);
                    cmd.Parameters.AddWithValue("[PhoneNumb]", entity.PhoneNumb);
                    cmd.Parameters.AddWithValue("[HAdderss]", entity.HAdderss);
                    cmd.Parameters.AddWithValue("[IdStudent]", entity.IdStudent);
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
                    cmd.CommandText = "INSERT INTO [Student] ([SecondName], [FirstName], [Surname], [DateOfRegistr], [DateOfBirth], [PhoneNumb], [HAdderss])" + "VALUES (?,?,?,?,?,?,?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[SecondName]", entity.SecondName);
                    cmd.Parameters.AddWithValue("[FirstName]", entity.FirstName);
                    cmd.Parameters.AddWithValue("[Surname]", entity.Surname);
                    cmd.Parameters.AddWithValue("[DateOfRegistr]", entity.DateOfRegistr);
                    cmd.Parameters.AddWithValue("[DateOfBirth]", entity.DateOfBirth);
                    cmd.Parameters.AddWithValue("[PhoneNumb]", entity.PhoneNumb);
                    cmd.Parameters.AddWithValue("[HAdderss]", entity.HAdderss);
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
        #endregion Student

        #region Room
        public static Room SelectRoom(int id)
        {
            Room result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "Select [Room].[IdRoom], [Room].* FROM [Room] WHERE [Room].[IdRoom]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdRoom]", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = Room.Map(dataTable.Rows[0]);
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
        public static List<Room> SelectRoomX()
        {
            List<Room> result = new List<Room>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT Room.* FROM Room";
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
                    result.Add(Room.Map(row, i));
                    i++;
                }
            }
            return result;
        }
        public static void DeleteRoom(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM [Room] WHERE [IdRoom]";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdRoom]", id);
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
        public static void UpdateRoom(Room entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE [Room] SET [IdDormitory]=?, [RoomStatusNotation]=?, [NumberOfResidents]=?, [MaxNumberOfResidents]=?, [NumbRoom]=?, WHERE [IdRoom]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdDormitory]", entity.IdDormitory);
                    cmd.Parameters.AddWithValue("[RoomStatusNotation]", entity.RoomStatusNotation);
                    cmd.Parameters.AddWithValue("[NumberOfResidents]", entity.NumberOfResidents);
                    cmd.Parameters.AddWithValue("[MaxNumberOfResidents]", entity.MaxNumberOfResidents);
                    cmd.Parameters.AddWithValue("[NumbRoom]", entity.NumbRoom);
                    cmd.Parameters.AddWithValue("[IdRoom]", entity.IdRoom);
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
        public static int InsertRoom(Room entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO [Room] ([IdDormitory], [RoomStatusNotation], [NumberOfResidents], [MaxNumberOfResidents], [NumbRoom])" + "VALUES (?,?,?,?,?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdDormitory]", entity.IdDormitory);
                    cmd.Parameters.AddWithValue("[RoomStatusNotation]", entity.RoomStatusNotation);
                    cmd.Parameters.AddWithValue("[NumberOfResidents]", entity.NumberOfResidents);
                    cmd.Parameters.AddWithValue("[MaxNumberOfResidents]", entity.MaxNumberOfResidents);
                    cmd.Parameters.AddWithValue("[NumbRoom]", entity.NumbRoom);
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
        #endregion Room

        #region Groups
        public static Groups SelectGroups(int id)
        {
            Groups result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "Select [Groups].[IdGroup], [Groups].* FROM [Groups] WHERE [Groups].[IdGroup]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdGroup]", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = Groups.Map(dataTable.Rows[0]);
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
        public static List<Groups> SelectGroupsX()
        {
            List<Groups> result = new List<Groups>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT Groups.* FROM Groups";
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
                    result.Add(Groups.Map(row, i));
                    i++;
                }
            }
            return result;
        }
        public static void DeleteGroups(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM [Groups] WHERE [IdGroup]";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdGroup]", id);
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
        public static void UpdateGroups(Groups entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE [Groups] SET [IdDirection]=?, [Course]=?, [CodeGroup]=?, [MaxNumberOfResidents]=?, [NumbRoom]=?, WHERE [IdGroup]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdDirection]", entity.IdDirection);
                    cmd.Parameters.AddWithValue("[Course]", entity.Course);
                    cmd.Parameters.AddWithValue("[CodeGroup]", entity.CodeGroup);
                    cmd.Parameters.AddWithValue("[IdGroup]", entity.IdGroup);
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
        public static int InsertGroups(Groups entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO [Groups] ([IdDirection], [Course], [CodeGroup])" + "VALUES (?,?,?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdDirection]", entity.IdDirection);
                    cmd.Parameters.AddWithValue("[Course]", entity.Course);
                    cmd.Parameters.AddWithValue("[CodeGroup]", entity.CodeGroup);
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
        #endregion Group

        #region Dormitory
        public static Dormitory SelectDormitory(int id)
        {
            Dormitory result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "Select [Dormitory].[IdDormitory], [Dormitory].* FROM [Dormitory] WHERE [Dormitory].[IdDormitory]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdDormitory]", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = Dormitory.Map(dataTable.Rows[0]);
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
        public static List<Dormitory> SelectDormitoryX()
        {
            List<Dormitory> result = new List<Dormitory>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT Dormitory.* FROM Dormitory";
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
                    result.Add(Dormitory.Map(row, i));
                    i++;
                }
            }
            return result;
        }
        public static void DeleteDormitory(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM [Dormitory] WHERE [IdDormitory]";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdDormitory]", id);
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
        public static void UpdateDormitory(Dormitory entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE [Dormitory] SET [PhoneNumbD]=?, [Adress]=?, [NumbOfRooms]=?, WHERE [IdDormitory]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[PhoneNumbD]", entity.PhoneNumbD);
                    cmd.Parameters.AddWithValue("[Adress]", entity.Adress);
                    cmd.Parameters.AddWithValue("[NumbOfRooms]", entity.NumbOfRooms);
                    cmd.Parameters.AddWithValue("[IdDormitory]", entity.IdDormitory);
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
        public static int InsertDormitory(Dormitory entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO [Dormitory] ([PhoneNumbD], [Adress], [NumbOfRooms])" + "VALUES (?,?,?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[PhoneNumbD]", entity.PhoneNumbD);
                    cmd.Parameters.AddWithValue("[Adress]", entity.Adress);
                    cmd.Parameters.AddWithValue("[NumbOfRooms]", entity.NumbOfRooms);
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
        #endregion Dormitory

        #region Directions
        public static Directions SelectDirections(int id)
        {
            Directions result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "Select [Directions].[IdDormitory], [Dormitory].* FROM [Dormitory] WHERE [Dormitory].[IdDirection]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdDirection]", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = Directions.Map(dataTable.Rows[0]);
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
        public static List<Directions> SelectDirectionsX()
        {
            List<Directions> result = new List<Directions>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT Directions.* FROM Directions";
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
                    result.Add(Directions.Map(row, i));
                    i++;
                }
            }
            return result;
        }
        public static void DeleteDirections(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM [Directions] WHERE [Directions]";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdDirection]", id);
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
        public static void UpdateDirections(Directions entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE [Directions] SET [Direction]=?, [CodeDirection]=?, WHERE [IdDirection]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[Direction]", entity.Direction);
                    cmd.Parameters.AddWithValue("[CodeDirection]", entity.CodeDirection);
                    cmd.Parameters.AddWithValue("[IdDirection]", entity.IdDirection);
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
        public static int InsertDirections(Directions entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO [Directions] ([Direction], [CodeDirection])" + "VALUES (?,?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[Direction]", entity.Direction);
                    cmd.Parameters.AddWithValue("[CodeDirection]", entity.CodeDirection);
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
        #endregion Direction
    }
}