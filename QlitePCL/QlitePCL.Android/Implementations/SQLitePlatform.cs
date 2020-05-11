using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(QlitePCL.Droid.Implementations.SQLitePlatform))]
namespace QlitePCL.Droid.Implementations
{
    public class SQLitePlatform : ISQLitePlatform
    {
        public string GetPath()
        {
            var dbName = Constantes.DatabaseFileName;
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);

            return path;
        }

        public SQLiteConnection GetConnection()
        {

            return new SQLiteConnection(GetPath());
        }

        public SQLiteAsyncConnection GetConnectionAsync()
        {
            return new SQLiteAsyncConnection(GetPath());
        }
    }
}