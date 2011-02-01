using System.Collections.Generic;

namespace harvest
{
    public interface IExtractor
    {
        //config file extractor
       IEnumerable<MetaDataElement> Extract(ExtractionPoint extractionPoint);
    }
}