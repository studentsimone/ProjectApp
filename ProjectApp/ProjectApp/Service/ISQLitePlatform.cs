using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProjectApp.Service
{
    public interface ISQLitePlatform
    {
        SQLiteConnection GetConnection();
        SQLiteAsyncConnection GetConnectionAsync();
    }




}
