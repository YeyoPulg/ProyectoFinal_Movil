using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal_Movil.Model;
using SQLite;

namespace ProyectoFinal_Movil.DataBase
{
    public class DataBaseSQL
    {
        readonly SQLiteAsyncConnection _conn;

        public DataBaseSQL(string dbpath)
        {
            _conn = new SQLiteAsyncConnection(dbpath);
            _conn.CreateTableAsync<UserModel>().Wait();
        }

        public Task<int> RegisterUserModelAsync(UserModel user)
        {
            if (user.UserId != 0)
            {
                return _conn.UpdateAsync(user);
            }
            else
            {
                return _conn.InsertAsync(user);
            }
        }
        public Task<List<UserModel>> GetUserModel()
        {
            return _conn.Table<UserModel>().ToListAsync();
        }

        public Task<List<UserModel>> QueryUserModel(string query)
        {
            return _conn.QueryAsync<UserModel>(query);
        }
    }
}
