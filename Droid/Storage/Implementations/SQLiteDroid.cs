using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FormsAssistControl.Storage.Interface;
using SQLite;
using System.IO;
using Xamarin.Forms;
using FormsAssistControl.Droid;

[assembly:Dependency(typeof(SQLiteDroid))]
namespace FormsAssistControl.Droid
{
    public class SQLiteDroid : ISQLite
    {
        public SQLiteDroid()
        {

        }
        public SQLiteConnection GetConnection()
        {
            SQLitePCL.Batteries.Init();
            var sqlLiteFileName = "TodoSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
            var path = Path.Combine(documentsPath, sqlLiteFileName);

            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}