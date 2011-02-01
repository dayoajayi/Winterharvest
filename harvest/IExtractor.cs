namespace harvest
{
    public interface IExtractor
    {
        //config file extractor
        MetaDataElement Extract(ExtractionPoint extractionPoint);
    }
}