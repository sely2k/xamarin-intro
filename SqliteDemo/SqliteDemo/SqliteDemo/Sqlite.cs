using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SqliteDemo.Models;

namespace SqliteDemo
{
    public class Sqlite
    {
        public static string createDatabase(string path)
        {

            var connection = new SQLiteConnection(path);
            var tableResult = connection.CreateTable<Person>();

            return "Database created";

        }

        public static string insertUpdateData(Person data, string path)
        {
            try
            {
                var db = new SQLiteConnection(path);
                if ( db.Insert(data) != 0)
                    db.Update(data);
                return "Single data file inserted or updated";
            }
            catch (SQLiteException ex)
            {
                return ex.Message;
            }
        }

        public static int findNumberRecords(string path)
        {
            try
            {
                var db = new SQLiteConnection(path);
                // this counts all records in the database, it can be slow depending on the size of the database
                var count = db.ExecuteScalar<int>("SELECT Count(*) FROM Person");

                // for a non-parameterless query
                // var count = db.ExecuteScalar<int>("SELECT Count(*) FROM Person WHERE FirstName="Amy");

                return count;
            }
            catch (SQLiteException ex)
            {
                return -1;
            }
        }
    }
}
