using Android.Runtime;
using System.Collections.Generic;
using System.Threading;

namespace Twilio.Conversations
{
    internal static class Utils
    {
        public static List<T> ConvertJavaList<T>(Java.Util.IList list) where T : class, IJavaObject
        {
            List<T> result = null;

            if (list != null)
            {
                result = new List<T>(list.Size());
                for (int i = 0; i < result.Capacity; i++)
                    result.Add(list.Get(i).JavaCast<T>());
            }

            return result;
        }

        public static Dictionary<string, string> ConvertJavaStringMap(Java.Util.IMap map)
        {
            if (map == null)
                return null;

            Dictionary<string, string> result = new();
            foreach (Java.Util.IMapEntry entry in map.EntrySet())
                result.Add(entry.Key.ToString(), entry.Value?.ToString());

            return result;
        }

        public static CancellationTokenRegistration CancelWith(this ICancellationToken twilioCancellationToken, CancellationToken cancellationToken)
        {
            return cancellationToken.Register(twilioCancellationToken.Cancel);
        }
    }
}