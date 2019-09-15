using System;

namespace Optional
{
    internal static class Required
    {
        internal static T RequireNonNull<T>(this T input, string message = default)
        {
            try
            {
                if (!input.Equals(null) || !input.Equals(default))
                    return input;
            }
            catch (NullReferenceException e)
            {
                throw new NullReferenceException($"{e.Message}\n, {message}");
            }
            return default; //return NaN
        }
    }
}
