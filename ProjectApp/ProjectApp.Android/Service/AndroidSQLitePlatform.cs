using System.IO;
using SQLite;
using ProjectApp.Droid.Services;
using ProjectApp.Service;
[assembly: Xamarin.Forms.Dependency(typeof(AndroidSQLitePlatform))]
namespace ProjectApp.Droid.Services
{
    public class AndroidSQLitePlatform : ISQLitePlatform
    {
        private string GetPath()
        {
            var dbName = "sqlite.db3";
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