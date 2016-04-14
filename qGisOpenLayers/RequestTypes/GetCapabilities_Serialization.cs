
using System.Xml.Serialization;
using System.Collections.Generic;


namespace qGisOpenLayers.RequestTypes.Xml2CSharp
{
    [XmlRoot(ElementName = "KeywordList", Namespace = "http://www.opengis.net/wms")]
    public class KeywordList
    {
        [XmlElement(ElementName = "Keyword", Namespace = "http://www.opengis.net/wms")]
        public string Keyword { get; set; }
    }

    [XmlRoot(ElementName = "OnlineResource", Namespace = "http://www.opengis.net/wms")]
    public class OnlineResource
    {
        [XmlAttribute(AttributeName = "type", Namespace = "http://www.w3.org/1999/xlink")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "xlink", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xlink { get; set; }
        [XmlAttribute(AttributeName = "href", Namespace = "http://www.w3.org/1999/xlink")]
        public string Href { get; set; }
    }

    [XmlRoot(ElementName = "ContactPersonPrimary", Namespace = "http://www.opengis.net/wms")]
    public class ContactPersonPrimary
    {
        [XmlElement(ElementName = "ContactPerson", Namespace = "http://www.opengis.net/wms")]
        public string ContactPerson { get; set; }
        [XmlElement(ElementName = "ContactOrganization", Namespace = "http://www.opengis.net/wms")]
        public string ContactOrganization { get; set; }
    }

    [XmlRoot(ElementName = "ContactAddress", Namespace = "http://www.opengis.net/wms")]
    public class ContactAddress
    {
        [XmlElement(ElementName = "AddressType", Namespace = "http://www.opengis.net/wms")]
        public string AddressType { get; set; }
        [XmlElement(ElementName = "Address", Namespace = "http://www.opengis.net/wms")]
        public string Address { get; set; }
        [XmlElement(ElementName = "City", Namespace = "http://www.opengis.net/wms")]
        public string City { get; set; }
        [XmlElement(ElementName = "StateOrProvince", Namespace = "http://www.opengis.net/wms")]
        public string StateOrProvince { get; set; }
        [XmlElement(ElementName = "PostCode", Namespace = "http://www.opengis.net/wms")]
        public string PostCode { get; set; }
        [XmlElement(ElementName = "Country", Namespace = "http://www.opengis.net/wms")]
        public string Country { get; set; }
    }

    [XmlRoot(ElementName = "ContactInformation", Namespace = "http://www.opengis.net/wms")]
    public class ContactInformation
    {
        [XmlElement(ElementName = "ContactPersonPrimary", Namespace = "http://www.opengis.net/wms")]
        public ContactPersonPrimary ContactPersonPrimary { get; set; }
        [XmlElement(ElementName = "ContactAddress", Namespace = "http://www.opengis.net/wms")]
        public ContactAddress ContactAddress { get; set; }
        [XmlElement(ElementName = "ContactVoiceTelephone", Namespace = "http://www.opengis.net/wms")]
        public string ContactVoiceTelephone { get; set; }
        [XmlElement(ElementName = "ContactElectronicMailAddress", Namespace = "http://www.opengis.net/wms")]
        public string ContactElectronicMailAddress { get; set; }
    }

    [XmlRoot(ElementName = "Service", Namespace = "http://www.opengis.net/wms")]
    public class Service
    {
        [XmlElement(ElementName = "Name", Namespace = "http://www.opengis.net/wms")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Title", Namespace = "http://www.opengis.net/wms")]
        public string Title { get; set; }
        [XmlElement(ElementName = "Abstract", Namespace = "http://www.opengis.net/wms")]
        public string Abstract { get; set; }
        [XmlElement(ElementName = "KeywordList", Namespace = "http://www.opengis.net/wms")]
        public KeywordList KeywordList { get; set; }
        [XmlElement(ElementName = "OnlineResource", Namespace = "http://www.opengis.net/wms")]
        public OnlineResource OnlineResource { get; set; }
        [XmlElement(ElementName = "ContactInformation", Namespace = "http://www.opengis.net/wms")]
        public ContactInformation ContactInformation { get; set; }
        [XmlElement(ElementName = "Fees", Namespace = "http://www.opengis.net/wms")]
        public string Fees { get; set; }
        [XmlElement(ElementName = "AccessConstraints", Namespace = "http://www.opengis.net/wms")]
        public string AccessConstraints { get; set; }
        [XmlElement(ElementName = "LayerLimit", Namespace = "http://www.opengis.net/wms")]
        public string LayerLimit { get; set; }
    }

    [XmlRoot(ElementName = "Get", Namespace = "http://www.opengis.net/wms")]
    public class Get
    {
        [XmlElement(ElementName = "OnlineResource", Namespace = "http://www.opengis.net/wms")]
        public OnlineResource OnlineResource { get; set; }
    }

    [XmlRoot(ElementName = "HTTP", Namespace = "http://www.opengis.net/wms")]
    public class HTTP
    {
        [XmlElement(ElementName = "Get", Namespace = "http://www.opengis.net/wms")]
        public Get Get { get; set; }
    }

    [XmlRoot(ElementName = "DCPType", Namespace = "http://www.opengis.net/wms")]
    public class DCPType
    {
        [XmlElement(ElementName = "HTTP", Namespace = "http://www.opengis.net/wms")]
        public HTTP HTTP { get; set; }
    }

    [XmlRoot(ElementName = "GetCapabilities", Namespace = "http://www.opengis.net/wms")]
    public class GetCapabilities
    {
        [XmlElement(ElementName = "Format", Namespace = "http://www.opengis.net/wms")]
        public string Format { get; set; }
        [XmlElement(ElementName = "DCPType", Namespace = "http://www.opengis.net/wms")]
        public DCPType DCPType { get; set; }
    }

    [XmlRoot(ElementName = "GetMap", Namespace = "http://www.opengis.net/wms")]
    public class GetMap
    {
        [XmlElement(ElementName = "Format", Namespace = "http://www.opengis.net/wms")]
        public List<string> Format { get; set; }
        [XmlElement(ElementName = "DCPType", Namespace = "http://www.opengis.net/wms")]
        public DCPType DCPType { get; set; }
    }

    [XmlRoot(ElementName = "GetFeatureInfo", Namespace = "http://www.opengis.net/wms")]
    public class GetFeatureInfo
    {
        [XmlElement(ElementName = "Format", Namespace = "http://www.opengis.net/wms")]
        public List<string> Format { get; set; }
        [XmlElement(ElementName = "DCPType", Namespace = "http://www.opengis.net/wms")]
        public DCPType DCPType { get; set; }
    }

    [XmlRoot(ElementName = "GetLegendGraphic", Namespace = "http://www.opengis.net/sld")]
    public class GetLegendGraphic
    {
        [XmlElement(ElementName = "Format", Namespace = "http://www.opengis.net/wms")]
        public List<string> Format { get; set; }
        [XmlElement(ElementName = "DCPType", Namespace = "http://www.opengis.net/wms")]
        public DCPType DCPType { get; set; }
    }

    [XmlRoot(ElementName = "DescribeLayer", Namespace = "http://www.opengis.net/sld")]
    public class DescribeLayer
    {
        [XmlElement(ElementName = "Format", Namespace = "http://www.opengis.net/wms")]
        public string Format { get; set; }
        [XmlElement(ElementName = "DCPType", Namespace = "http://www.opengis.net/wms")]
        public DCPType DCPType { get; set; }
    }

    [XmlRoot(ElementName = "GetStyles", Namespace = "http://www.qgis.org/wms")]
    public class GetStyles
    {
        [XmlElement(ElementName = "Format", Namespace = "http://www.opengis.net/wms")]
        public string Format { get; set; }
        [XmlElement(ElementName = "DCPType", Namespace = "http://www.opengis.net/wms")]
        public DCPType DCPType { get; set; }
    }

    [XmlRoot(ElementName = "Request", Namespace = "http://www.opengis.net/wms")]
    public class Request
    {
        [XmlElement(ElementName = "GetCapabilities", Namespace = "http://www.opengis.net/wms")]
        public GetCapabilities GetCapabilities { get; set; }
        [XmlElement(ElementName = "GetMap", Namespace = "http://www.opengis.net/wms")]
        public GetMap GetMap { get; set; }
        [XmlElement(ElementName = "GetFeatureInfo", Namespace = "http://www.opengis.net/wms")]
        public GetFeatureInfo GetFeatureInfo { get; set; }
        [XmlElement(ElementName = "GetLegendGraphic", Namespace = "http://www.opengis.net/sld")]
        public GetLegendGraphic GetLegendGraphic { get; set; }
        [XmlElement(ElementName = "DescribeLayer", Namespace = "http://www.opengis.net/sld")]
        public DescribeLayer DescribeLayer { get; set; }
        [XmlElement(ElementName = "GetStyles", Namespace = "http://www.qgis.org/wms")]
        public GetStyles GetStyles { get; set; }
    }

    [XmlRoot(ElementName = "Exception", Namespace = "http://www.opengis.net/wms")]
    public class Exception
    {
        [XmlElement(ElementName = "Format", Namespace = "http://www.opengis.net/wms")]
        public string Format { get; set; }
    }

    [XmlRoot(ElementName = "UserDefinedSymbolization", Namespace = "http://www.opengis.net/sld")]
    public class UserDefinedSymbolization
    {
        [XmlAttribute(AttributeName = "RemoteWFS")]
        public string RemoteWFS { get; set; }
        [XmlAttribute(AttributeName = "RemoteWCS")]
        public string RemoteWCS { get; set; }
        [XmlAttribute(AttributeName = "InlineFeature")]
        public string InlineFeature { get; set; }
        [XmlAttribute(AttributeName = "UserStyle")]
        public string UserStyle { get; set; }
        [XmlAttribute(AttributeName = "SupportSLD")]
        public string SupportSLD { get; set; }
        [XmlAttribute(AttributeName = "UserLayer")]
        public string UserLayer { get; set; }
    }

    [XmlRoot(ElementName = "EX_GeographicBoundingBox", Namespace = "http://www.opengis.net/wms")]
    public class EX_GeographicBoundingBox
    {
        [XmlElement(ElementName = "westBoundLongitude", Namespace = "http://www.opengis.net/wms")]
        public string WestBoundLongitude { get; set; }
        [XmlElement(ElementName = "eastBoundLongitude", Namespace = "http://www.opengis.net/wms")]
        public string EastBoundLongitude { get; set; }
        [XmlElement(ElementName = "southBoundLatitude", Namespace = "http://www.opengis.net/wms")]
        public string SouthBoundLatitude { get; set; }
        [XmlElement(ElementName = "northBoundLatitude", Namespace = "http://www.opengis.net/wms")]
        public string NorthBoundLatitude { get; set; }
    }

    [XmlRoot(ElementName = "BoundingBox", Namespace = "http://www.opengis.net/wms")]
    public class BoundingBox
    {
        [XmlAttribute(AttributeName = "CRS")]
        public string CRS { get; set; }
        [XmlAttribute(AttributeName = "maxx")]
        public string Maxx { get; set; }
        [XmlAttribute(AttributeName = "minx")]
        public string Minx { get; set; }
        [XmlAttribute(AttributeName = "maxy")]
        public string Maxy { get; set; }
        [XmlAttribute(AttributeName = "miny")]
        public string Miny { get; set; }
    }

    [XmlRoot(ElementName = "LegendURL", Namespace = "http://www.opengis.net/wms")]
    public class LegendURL
    {
        [XmlElement(ElementName = "Format", Namespace = "http://www.opengis.net/wms")]
        public string Format { get; set; }
        [XmlElement(ElementName = "OnlineResource", Namespace = "http://www.opengis.net/wms")]
        public OnlineResource OnlineResource { get; set; }
    }

    [XmlRoot(ElementName = "Style", Namespace = "http://www.opengis.net/wms")]
    public class Style
    {
        [XmlElement(ElementName = "Name", Namespace = "http://www.opengis.net/wms")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Title", Namespace = "http://www.opengis.net/wms")]
        public string Title { get; set; }
        [XmlElement(ElementName = "LegendURL", Namespace = "http://www.opengis.net/wms")]
        public LegendURL LegendURL { get; set; }
    }

    [XmlRoot(ElementName = "Layer", Namespace = "http://www.opengis.net/wms")]
    public class Layer
    {
        [XmlElement(ElementName = "Name", Namespace = "http://www.opengis.net/wms")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Title", Namespace = "http://www.opengis.net/wms")]
        public string Title { get; set; }
        [XmlElement(ElementName = "CRS", Namespace = "http://www.opengis.net/wms")]
        public List<string> CRS { get; set; }
        [XmlElement(ElementName = "EX_GeographicBoundingBox", Namespace = "http://www.opengis.net/wms")]
        public EX_GeographicBoundingBox EX_GeographicBoundingBox { get; set; }
        [XmlElement(ElementName = "BoundingBox", Namespace = "http://www.opengis.net/wms")]
        public List<BoundingBox> BoundingBox { get; set; }
        [XmlElement(ElementName = "Style", Namespace = "http://www.opengis.net/wms")]
        public Style Style { get; set; }
        [XmlAttribute(AttributeName = "queryable")]
        public string Queryable { get; set; }
    }

    [XmlRoot(ElementName = "Capability", Namespace = "http://www.opengis.net/wms")]
    public class Capability
    {
        [XmlElement(ElementName = "Request", Namespace = "http://www.opengis.net/wms")]
        public Request Request { get; set; }
        [XmlElement(ElementName = "Exception", Namespace = "http://www.opengis.net/wms")]
        public Exception Exception { get; set; }
        [XmlElement(ElementName = "UserDefinedSymbolization", Namespace = "http://www.opengis.net/sld")]
        public UserDefinedSymbolization UserDefinedSymbolization { get; set; }
        [XmlElement(ElementName = "Layer", Namespace = "http://www.opengis.net/wms")]
        public Layer Layer { get; set; }
    }

    [XmlRoot(ElementName = "WMS_Capabilities", Namespace = "http://www.opengis.net/wms")]
    public class WMS_Capabilities
    {
        [XmlElement(ElementName = "Service", Namespace = "http://www.opengis.net/wms")]
        public Service Service { get; set; }
        [XmlElement(ElementName = "Capability", Namespace = "http://www.opengis.net/wms")]
        public Capability Capability { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }
        [XmlAttribute(AttributeName = "sld", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Sld { get; set; }
        [XmlAttribute(AttributeName = "qgs", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Qgs { get; set; }
    }

}
