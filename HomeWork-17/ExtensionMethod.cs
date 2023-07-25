using System.Collections;

namespace HomeWork_17
{
    public static class ExtensionMethod
    {
        public static T GetMax<T>(this IEnumerable e, Func<T, float> getParameter) where T : class
        {
            T? MaxT = default(T);
            float f = float.MinValue;

            foreach (T i in e)
            {
                var d = getParameter(i);
                if (d > f)
                {
                    MaxT = i;
                    f = d;
                }
            }
            return MaxT;
        }
    }
}
