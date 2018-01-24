using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Timbr.Data
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string databasePath)
        {
            _database = new SQLiteAsyncConnection(databasePath);
            _database.CreateTableAsync<Timbr.Entities.Project>().Wait();
            _database.CreateTableAsync<Timbr.Entities.Task>().Wait();
        }

        public Task<List<Timbr.Entities.Project>> FetchProjects()
        {
            return _database.Table<Timbr.Entities.Project>().ToListAsync();
        }

        public Task<List<Timbr.Entities.Task>> FetchTasks()
        {
            return _database.Table<Timbr.Entities.Task>().ToListAsync();
        }

        public Task<Timbr.Entities.Project> FetchProject(int id)
        {
            return _database.Table<Timbr.Entities.Project>().Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public Task<Timbr.Entities.Task> FetchTask(int id)
        {
            return _database.Table<Timbr.Entities.Task>().Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public Task<List<Timbr.Entities.Project>> FetchPendingProjects()
        {
            var now = DateTime.Now.ToString();
            var query = string.Format("SELECT * FROM [Project] WHERE StartDate > '{0}'", now);
            return _database.QueryAsync<Timbr.Entities.Project>(query);
        }
    }
}
