using MongoDB.Driver;

namespace DAO
{
    public class DataProvider
    {
        MongoClient client;

        public DataProvider ()
        {
            client = new MongoClient(
                "mongodb://localhost:27017/TourManagement"
            );
        }

        //public static DataProvider GetInstance()
        //{
        //    //var database = client.GetDatabase("Locations");

        //    return new DataProvider();
        //}
    }
}
