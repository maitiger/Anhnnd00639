using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeYami.DataAcess
{
    class DataAccess
    {
        public static string SQL_connection_string = "Filename=SongData.db";
        public static void InitializeDatabase()
        {
            using (SqliteConnection db =
                new SqliteConnection(SQL_connection_string))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS SongAnime (id  INTEGER PRIMARY KEY, " +
                    "songthumnail NVARCHAR(2048) ,songname NVARCHAR(2048) ," +
                    "songt NVARCHAR(50) ,singer NVARCHAR(50) )";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
    }
}
