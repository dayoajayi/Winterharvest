using System.Collections.Generic;

namespace harvest
{
    public class ConfigFileExtractor : IExtractor
    {
        public IEnumerable<MetaDataElement> Extract(ExtractionPoint extractionPoint)
        {
         yield return new MetaDataElement();//throw new NotImplementedException();
        }
    }
}