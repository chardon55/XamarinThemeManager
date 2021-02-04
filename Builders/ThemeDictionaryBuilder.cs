using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Chardon.XamarinThemeManager.Builders
{
    /// <summary>
    /// Theme dictionary builder
    /// 
    /// <para>TKey - Type of key</para>
    /// </summary>
    public class ThemeDictionaryBuilder<TKey> : ICloneable
    {
        private readonly Dictionary<TKey, ResourceDictionary> dict;

        /// <summary>
        /// Constructor of ThemeDictionaryBuilder
        /// </summary>
        public ThemeDictionaryBuilder()
        {
            dict = new Dictionary<TKey, ResourceDictionary>();
        }


        /// <summary>
        /// Constructor of ThemeDictionaryBuilder
        /// </summary>
        /// <param name="dictionary">Input dictionary (Indicated reference)</param>
        /// <param name="copy">Whether copy the instance or use the reference directly, default: true</param>
        public ThemeDictionaryBuilder(Dictionary<TKey, ResourceDictionary> dictionary, bool copy = true)
        {
            if (copy)
            {
                dict = new Dictionary<TKey, ResourceDictionary>(dictionary);
            }
            else
            {
                dict = dictionary;
            }
        }

        /// <summary>
        /// Count of pairs in the dictionary
        /// </summary>
        public int Count => dict.Count;

        /// <summary>
        /// Add a new pair to the dictionary
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        /// <returns>Current builder</returns>
        public ThemeDictionaryBuilder<TKey> Append(TKey key, ResourceDictionary value)
        {
            dict.Add(key, value);
            return this;
        }

        /// <summary>
        /// Add a new pair to the dictionary
        /// </summary>
        /// <param name="pair">Key-value pair</param>
        /// <returns>Current builder</returns>
        public ThemeDictionaryBuilder<TKey> Append(KeyValuePair<TKey, ResourceDictionary> pair)
        {
            dict.Add(pair.Key, pair.Value);
            return this;
        }

        /// <summary>
        /// Add pairs from a existent dictionary to built dictionary
        /// </summary>
        /// <param name="inputDict">Dictionary</param>
        /// <returns>Current builder</returns>
        public ThemeDictionaryBuilder<TKey> Append(Dictionary<TKey, ResourceDictionary> inputDict)
        {
            foreach (var pair in inputDict)
            {
                dict.Add(pair.Key, pair.Value);
            }

            return this;
        }

        /// <summary>
        /// Add a new pair to the dictionary
        /// without transmitting the builder instance.
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public void Add(TKey key, ResourceDictionary value) => dict.Add(key, value);

        /// <summary>
        /// Remove added pair from the dictionary if it exists
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>Current builder</returns>
        public ThemeDictionaryBuilder<TKey> Remove(TKey key)
        {
            dict.Remove(key);
            return this;
        }

        /// <summary>
        /// Remove all pairs from the dictionary
        /// </summary>
        /// <returns>Current builder</returns>
        public ThemeDictionaryBuilder<TKey> Clear()
        {
            dict.Clear();
            return this;
        }

        /// <summary>
        /// Get built dictionary instance
        /// </summary>
        /// <returns>Built dictionary</returns>
        public Dictionary<TKey, ResourceDictionary> GetDictionary() => dict;

        public object Clone()
        {
            return new ThemeDictionaryBuilder<TKey>(dict, copy: true);
        }
    }
}
