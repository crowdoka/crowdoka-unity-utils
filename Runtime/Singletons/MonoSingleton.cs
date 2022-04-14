namespace Crowdoka.Utils.Runtime.Singletons
{
    using System;
    using UnityEngine;

    public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T singletonInstance;

        public static T Instance
        {
            get
            {
                if (singletonInstance == null)
                {
                    throw new Exception(
                        $"{nameof(MonoSingleton<T>)} used before initialization. Please use {nameof(InitInstance)} before using the singleton instance");
                }

                return singletonInstance;
            }
        }

        protected void InitInstance(T instance)
        {
            singletonInstance =
                instance ? instance : throw new Exception($"Instance of type {nameof(T)} cannot be null");
        }
    }
}