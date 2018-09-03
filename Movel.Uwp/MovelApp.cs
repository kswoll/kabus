using Movel.Utils;

namespace Movel.Uwp
{
    public class MovelApp
    {
        public static void Initialize()
        {
            MovelDispatcher.Instance = new UwpMovelDispatcher();
        }        
    }
}