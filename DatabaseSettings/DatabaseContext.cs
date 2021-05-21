using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSettings
{
    class DatabaseContext
    {
        private static SQLiteConnection sqliteConnection;

        public DatabaseContext()
        {

        }
        /// <summary>
        /// Returns a connection to the SQLite database;
        /// </summary>
        /// <returns></returns>
        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("DataSource = D:\\Documents\\GitHub\\IBS\\database.sqlite; Version=3");
            sqliteConnection.Open();
            return sqliteConnection;
        }
        /// <summary>
        /// Create an SQLite database with the name and in the specified location;
        /// </summary>
        public static void NewDatabase()
        {
            try
            {
                SQLiteConnection.CreateFile(@"D:\Documents\GitHub\IBS\database\database.sqlite");
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Creates tables in the SQLite database with the given name;
        /// </summary>
        public static void NewPlayerTable()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Player(level int, attack int, defense int, magicattack int, magicdefense int, speed int, hitpoints int)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Returns all data from the Player table;
        /// </summary>
        /// <returns></returns>
        public static DataTable GetPlayer()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Player";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Returns row by their level;
        /// </summary>
        /// <returns></returns>
        public static DataTable GetPlayer(int level)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Player Where level=" + level;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Adds a row to the Player table;
        /// </summary>
        /// <param name="status"></param>
        public static void Add(Player status)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Player(" +
                        "level," +
                        "attack," +
                        "defense," +
                        "magic_attack," +
                        "magic_defense," +
                        "speed," +
                        "hit_points" +
                        ")" +
                        "" +
                        "values(" +
                        "@level," +
                        "@attack," +
                        "@defense," +
                        "@magic_attack," +
                        "@magic_defense," +
                        "@speed," +
                        "@hit_points" +
                        ")";
                    cmd.Parameters.AddWithValue("@level", status.level);
                    cmd.Parameters.AddWithValue("@attack", status.attack);
                    cmd.Parameters.AddWithValue("@defense", status.defense);
                    cmd.Parameters.AddWithValue("@magic_attack", status.magic_attack);
                    cmd.Parameters.AddWithValue("@magic_defense", status.magic_defense);
                    cmd.Parameters.AddWithValue("@speed", status.speed);
                    cmd.Parameters.AddWithValue("@hit_points", status.hit_points);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Updates the data of an existing row;
        /// </summary>
        /// <param name="status"></param>
        public static void Update(Player status)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "UPDATE Clientes SET " +
                        "attack=@attack," +
                        "defense=@defense," +
                        "magic_attack=@magic_attack," +
                        "magic_defense=@magic_defense," +
                        "speed=@speed," +
                        "hit_points=@hit_points" +
                        "" +
                        "WHERE level=@level";
                    cmd.Parameters.AddWithValue("@level", status.level);
                    cmd.Parameters.AddWithValue("@attack", status.attack);
                    cmd.Parameters.AddWithValue("@defense", status.defense);
                    cmd.Parameters.AddWithValue("@magic_attack", status.magic_attack);
                    cmd.Parameters.AddWithValue("@magic_defense", status.magic_defense);
                    cmd.Parameters.AddWithValue("@speed", status.speed);
                    cmd.Parameters.AddWithValue("@hit_points", status.hit_points);
                    cmd.ExecuteNonQuery();
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(int level)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM Player Where level=@level";
                    cmd.Parameters.AddWithValue("@Id", level);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
