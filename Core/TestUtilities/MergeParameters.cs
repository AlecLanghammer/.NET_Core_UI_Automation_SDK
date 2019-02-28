using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Core.TestUtilities
{
    class MergeParameters
    {
        public static Dictionary<string, string> BuildParameters()
        {
            return Merge(GetEnvDict(), FrameworkConfig.GetConfigDict());
        }

        /// <summary>
        /// Builds and returns a dictionary from the environment variables
        /// </summary>
        static Dictionary<string, string> GetEnvDict()
        {
            Dictionary<string, string> envDict = new Dictionary<string, string>();
            foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
            {
                envDict.Add(de.Key.ToString().ToLower(), de.Value.ToString().ToLower());
            }
            return envDict;
        }

        /// <summary>
        /// Merges the two dictionaries with envDict taking priority
        /// </summary>
        /// <param name="envDict">Dictionary built from environment variables</param>
        /// <param name="configDict">Dictionary built from app.config</param>
        public static Dictionary<string, string> Merge(Dictionary<string, string> envDict, Dictionary<string, string> configDict)
        {
            envDict.ToList().ForEach(x => configDict[x.Key] = x.Value);
            return configDict;
        }
    }
}
