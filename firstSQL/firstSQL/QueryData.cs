using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace firstSQL
{
	class QueryData<T> where T : class
	{
		private string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FirstServer;Integrated Security=True";
		private SqlConnection connect;
		private string _table;

		public QueryData(string table)
		{
			connect = new SqlConnection(connStr);
			_table = table;
		}

		public async Task<IEnumerable<T>> ReadAll()
		{
			string sql = $@"SELECT * FROM {_table}";
			IEnumerable <T> persons = await connect.QueryAsync<T>(sql);
			return persons;
		}

		public async Task<int> AddData(string firstName, string lastName, int? birthYear = null, int? deathYear = null)
		{
			string sql = @"INSERT INTO Person (FirstName, LastName, BirthYear, DeathYear)
                           VALUES (@FirstName, @LastName, @BirthYear, @DeathYear)";
			int x = await connect.ExecuteAsync(sql, 
				new { FirstName = firstName, LastName = lastName, BirthYear = birthYear, DeathYear = deathYear });
			return x;
		}

		public async Task<int> DeleteData(int i)
		{
			string sql = @"DELETE FROM Person
							WHERE Id = @SId";
			int x = await connect.ExecuteAsync(sql, new { SId = i });
			return x;
		}

		public async Task<IEnumerable<T>> ReadById(int i)
		{
			string sql = @"SELECT * FROM Person
							WHERE Id = @SId";
			IEnumerable<T> x = await connect.QueryAsync<T>(sql, new { SId = i });
			return x;
		}
	}
}

