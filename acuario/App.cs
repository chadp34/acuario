using System;

namespace acuario
{
    public class App
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://s3-us-west-1.amazonaws.com/wikimap/wikimap.json";

        public static void Initialize()
        {
            if (UseMockDataStore)
                ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
            else
                ServiceLocator.Instance.Register<IDataStore<Item>, CloudDataStore>();
        }
    }
}
