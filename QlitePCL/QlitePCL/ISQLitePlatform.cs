using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace QlitePCL
{
   public interface ISQLitePlatform
    {
        SQLiteConnection GetConnection();
        SQLiteAsyncConnection GetConnectionAsync();
        String GetPath();
    }
}
