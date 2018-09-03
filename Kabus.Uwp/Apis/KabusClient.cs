using SexyHttp;

namespace Kabus.Uwp.Apis
{
    public class KabusClient
    {
        public static IKabusApi Create()
        {
            return HttpApiClient<IKabusApi>.Create("http://localhost:55594/api");
        }
    }
}