using FormsAssistControl.Storage.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;
using Xamarin.Forms;
using FormsAssistControl.iOS;

[assembly:Dependency(typeof(SQLiteIos))]
namespace FormsAssistControl.iOS
{
    public class SQLiteIos : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqlLiteFileName = "TodoSQLite.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath, "..","Library");

            var path = Path.Combine(libraryPath, sqlLiteFileName);

            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}
