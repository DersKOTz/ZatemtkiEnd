using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ZatemtkiEnd
{
    public class ZametkiSQL
    {
        SQLiteConnection database;
        public ZametkiSQL(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<ZametkiVAR>();
        }
        public IEnumerable<ZametkiVAR> GetItems()
        {
            return database.Table<ZametkiVAR>().ToList();
        }
        public ZametkiVAR GetItem(int id)
        {
            return database.Get<ZametkiVAR>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<ZametkiVAR>(id);
        }
        public int SaveItem(ZametkiVAR item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
