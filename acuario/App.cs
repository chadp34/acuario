using System;

namespace acuario
{
    public class App
    {
        public static bool UseMockDataStore = false;
        public static string BackendUrl = "http://noti.heliohost.org/mghalynho/wikimap.json";
//        public static string BackendUrl = "https://s3-us-west-1.amazonaws.com/wikimap/wikimap.json";

        public static void Initialize()
        {
            if (UseMockDataStore)
                ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
            else
                ServiceLocator.Instance.Register<IDataStore<Item>, CloudDataStore>();
        }
    }
}
