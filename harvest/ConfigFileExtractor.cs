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
            var appPathAndName = Path.Combine(@"C:\Development\WinterHarvest\Winterharvest.tests", "test.exe");

            if (!File.Exists(appPathAndName))
            {
                throw new FileNotFoundException("You were hoping to find '{0}' but it does not exist...", appPathAndName);
            }

            var configuration = ConfigurationManager.OpenExeConfiguration(appPathAndName);

            string[] keyCollection = configuration.AppSettings.Settings.AllKeys;

            foreach (string key in keyCollection)
            {
                var val = configuration.AppSettings.Settings[key];

                yield return new ConfigurationMetaDataElement() {Key = key, Value = val.Value};
            }
        }

    }
}