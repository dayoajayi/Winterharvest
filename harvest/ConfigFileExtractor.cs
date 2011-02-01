using System.Collections.Generic;
using System.Configuration;

namespace harvest
{
    public class ConfigFileExtractor : IExtractor
    {
        public IEnumerable<MetaDataElement> Extract(ExtractionPoint extractionPoint)
        {
            var o = ConfigurationManager.OpenExeConfiguration(@".\test.config");
            string[] blah = o.AppSettings.Settings.AllKeys;

            foreach (var key in blah)
            {
                var val = o.AppSettings.Settings[key];

                yield return new ConfigurationMetaDataElement(){Key = key, Value = val.Value};
            }
            
        }

        public string GetKey()
        {
            return "stinky";
        }
    }
}