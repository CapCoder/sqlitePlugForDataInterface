using System;
using DataInterface;
using System.Data.SQLite;

namespace SQLitePlug
{
    public class DatabaseContext : IDBcon
    {
        private string connectionString;
        private SQLiteConnection con = null;
        private IDataCommandFactory commandFactory;
        private IDataQueryFactory queryFactory;
        
        public DatabaseContext(string ConnectionString)
        {
            connectionString = ConnectionString;
            connect(connectionString);
        }
        public void connect(string conString)
        {
            con = new SQLiteConnection(conString);
            if(con == null)
            {
                SQLiteConnection.CreateFile(conString);
                con = new SQLiteConnection(conString);
            }
        }

        public void pushData()
        {
            
        }

        public bool testConnection()
        {
            return true;
        }

        public IDataCommandFactory getDataCommandFactory()
        {
            return commandFactory;
        }

        public IDataQueryFactory getDataQueryFactory()
        {
            return queryFactory;
        }

        public IActionExecutor getActionExecutor()
        {

        }
    }
}
