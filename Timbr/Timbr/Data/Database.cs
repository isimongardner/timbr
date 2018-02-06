using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Timbr.Interfaces;
using Timbr.Resources;

namespace Timbr.Data
{
    public class Database : IDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(IFileHelper fileHelper)
        {
            _database = new SQLiteAsyncConnection(fileHelper.GetLocalFilePath("Timbr.db3"));
            _database.CreateTableAsync<Timbr.Entities.Project>().Wait();
            _database.CreateTableAsync<Timbr.Entities.Task>().Wait();
        }

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
            var query = string.Format(DatabaseQueries.SelectPendingProjects, now);
            return _database.QueryAsync<Timbr.Entities.Project>(query);
        }

        public Task<int> CreateProject(Timbr.Entities.Project project)
        {
            if (project.Id != 0)
            {
                return _database.UpdateAsync(project);
            }
            else
            {
                return _database.InsertAsync(project);
            }

        }

        public Task<int> CreateTask(Timbr.Entities.Task task)
        {
            if (task.Id != 0)
            {
                return _database.UpdateAsync(task);
            }
            else
            {
                return _database.InsertAsync(task);
            }
        }

        public Task<int> DeleteProject(Timbr.Entities.Project project)
        {
            return _database.DeleteAsync(project);
        }

        public Task<int> DeleteProject(Timbr.Entities.Task task)
        {
            return _database.DeleteAsync(task);
        }
    }
}