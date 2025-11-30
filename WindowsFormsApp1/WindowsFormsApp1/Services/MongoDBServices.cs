using MongoDB.Driver;

namespace ClinicalBookingSystem.Services
{
	public class MongoDBService
	{
		private readonly IMongoDatabase _database;

		public MongoDBService()
		{
			var connectionString = "mongodb://localhost:27017"; // default server
			var client = new MongoClient(connectionString);

			_database = client.GetDatabase("ClinicalBookingSystem");

		}

		public IMongoCollection<T> GetCollection<T>(string collectionName)
		{
			return _database.GetCollection<T>(collectionName);
		}
	}
}