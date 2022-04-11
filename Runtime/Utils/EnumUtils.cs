namespace Crowdoka.Utils.Utils
{
    using System;
    using System.Linq;

    public static class EnumUtils
    {
        public static T[] GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToArray();
        }
    }
}
