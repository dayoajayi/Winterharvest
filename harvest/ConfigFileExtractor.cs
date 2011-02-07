using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace harvest
{
    public class ConfigFileExtractor : IExtractor
    {
        public ConfigFileExtractor()
        {
            string n = "Nope";
        }

        public IEnumerable<MetaDataElement> Extract(ExtractionPoint extractionPoint)
        {
            List<MetaDataElement> results = new List<MetaDataElement>();

            string appPathAndName = Path.Combine(@"C:\Development\WinterHarvest\Winterharvest.tests", "test.exe");
            string appPath = Environment.CurrentDirectory;

            var configuration = ConfigurationManager.OpenExeConfiguration(appPathAndName);
           
            string[] keyCollection = configuration.AppSettings.Settings.AllKeys;

            foreach (var key in keyCollection)
            {
                var val = configuration.AppSettings.Settings[key];

                //yield return new ConfigurationMetaDataElement() {Key = key, Value = val.Value};
                results.Add(new ConfigurationMetaDataElement() {Key = key, Value = val.Value});
            }
            return results;
        }

        public string GetKey()
        {
            return "stinky";
        }
    }
}