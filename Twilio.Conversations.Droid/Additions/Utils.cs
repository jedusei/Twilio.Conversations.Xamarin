using Android.Runtime;
using System.Collections.Generic;

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
    }
}