using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace WeatherAPI.Services
{
    public class WeatherResponse
    {

        public class Rootobject
        {
            public string openapi { get; set; }
            public Info info { get; set; }
            public Server[] servers { get; set; }
            public Externaldocs externalDocs { get; set; }
            public Paths paths { get; set; }
            public Components components { get; set; }
        }

        public class Info
        {
            public string title { get; set; }
            public string description { get; set; }
            public string version { get; set; }
        }

        public class Externaldocs
        {
            public string description { get; set; }
            public string url { get; set; }
        }

        public class Paths
        {
            public Alerts alerts { get; set; }
            public AlertsActive alertsactive { get; set; }
            public AlertsTypes alertstypes { get; set; }
            public AlertsId alertsid { get; set; }
            public AlertsActiveCount alertsactivecount { get; set; }
            public AlertsActiveZoneZoneid alertsactivezonezoneId { get; set; }
            public AlertsActiveAreaArea alertsactiveareaarea { get; set; }
            public AlertsActiveRegionRegion alertsactiveregionregion { get; set; }
            public Glossary glossary { get; set; }
            public GridpointsWfoXY gridpointswfoxy { get; set; }
            public GridpointsWfoXYForecast gridpointswfoxyforecast { get; set; }
            public GridpointsWfoXYForecastHourly gridpointswfoxyforecasthourly { get; set; }
            public GridpointsWfoXYStations gridpointswfoxystations { get; set; }
            public IconsSetTimeofdayFirstSecond iconssettimeOfDayfirstsecond { get; set; }
            public Icons icons { get; set; }
            public ThumbnailsSatelliteArea thumbnailssatellitearea { get; set; }
            public StationsStationidObservations stationsstationIdobservations { get; set; }
            public StationsStationidObservationsLatest stationsstationIdobservationslatest { get; set; }
            public StationsStationidObservationsCurrent stationsstationIdobservationscurrent { get; set; }
            public StationsStationidObservationsTime stationsstationIdobservationstime { get; set; }
            public Stations stations { get; set; }
            public StationsStationid stationsstationId { get; set; }
            public OfficesOfficeid officesofficeId { get; set; }
            public OfficesOfficeidHeadlinesHeadlineid officesofficeIdheadlinesheadlineId { get; set; }
            public OfficesOfficeidHeadlines officesofficeIdheadlines { get; set; }
            public PointsPoint pointspoint { get; set; }
            public PointsPointStations pointspointstations { get; set; }
            public PointsPointForecast pointspointforecast { get; set; }
            public PointsPointForecastHourly pointspointforecasthourly { get; set; }
            public RadarServers radarservers { get; set; }
            public RadarServersId radarserversid { get; set; }
            public RadarStations radarstations { get; set; }
            public RadarStationsStationid radarstationsstationId { get; set; }
            public RadarStationsStationidAlarms radarstationsstationIdalarms { get; set; }
            public RadarQueuesHost radarqueueshost { get; set; }
            public RadarProfilersStationid radarprofilersstationId { get; set; }
            public Products products { get; set; }
            public ProductsLocations productslocations { get; set; }
            public ProductsTypes productstypes { get; set; }
            public ProductsProductid productsproductId { get; set; }
            public ProductsTypesTypeid productstypestypeId { get; set; }
            public ProductsTypesTypeidLocations productstypestypeIdlocations { get; set; }
            public ProductsLocationsLocationidTypes productslocationslocationIdtypes { get; set; }
            public ProductsTypesTypeidLocationsLocationid productstypestypeIdlocationslocationId { get; set; }
            public Zones zones { get; set; }
            public ZonesType zonestype { get; set; }
            public ZonesTypeZoneid zonestypezoneId { get; set; }
            public ZonesTypeZoneidForecast zonestypezoneIdforecast { get; set; }
            public ZonesForecastZoneidObservations zonesforecastzoneIdobservations { get; set; }
            public ZonesForecastZoneidStations zonesforecastzoneIdstations { get; set; }
        }

        public class Alerts
        {
            public Get get { get; set; }
        }

        public class Get
        {
            public string description { get; set; }
            public Parameter[] parameters { get; set; }
            public Responses responses { get; set; }
        }

        public class Responses
        {
            public _200 _200 { get; set; }
            public Default _default { get; set; }
        }

        public class _200
        {
            public string description { get; set; }
            public Content content { get; set; }
        }

        public class Content
        {
            public ApplicationGeoJson applicationgeojson { get; set; }
            public ApplicationLdJson applicationldjson { get; set; }
            public ApplicationAtomXml applicationatomxml { get; set; }
        }

        public class ApplicationGeoJson
        {
        }

        public class ApplicationLdJson
        {
        }

        public class ApplicationAtomXml
        {
        }

        public class Default
        {
            public string _ref { get; set; }
        }

        public class Parameter
        {
            public string name { get; set; }
            public string _in { get; set; }
            public string description { get; set; }
            public Schema schema { get; set; }
            public string style { get; set; }
            public bool explode { get; set; }
        }

        public class Schema
        {
            public string type { get; set; }
            public string format { get; set; }
            public Items items { get; set; }
            public string[] _enum { get; set; }
            public int minimum { get; set; }
            public int maximum { get; set; }
        }

        public class Items
        {
            public string type { get; set; }
            public string[] _enum { get; set; }
            public string format { get; set; }
        }

        public class AlertsActive
        {
            public Get1 get { get; set; }
        }

        public class Get1
        {
            public string description { get; set; }
            public Parameter1[] parameters { get; set; }
            public Responses1 responses { get; set; }
        }

        public class Responses1
        {
            public _2001 _200 { get; set; }
            public Default1 _default { get; set; }
        }

        public class _2001
        {
            public string description { get; set; }
            public Content1 content { get; set; }
        }

        public class Content1
        {
            public ApplicationGeoJson1 applicationgeojson { get; set; }
            public ApplicationLdJson1 applicationldjson { get; set; }
            public ApplicationAtomXml1 applicationatomxml { get; set; }
        }

        public class ApplicationGeoJson1
        {
        }

        public class ApplicationLdJson1
        {
        }

        public class ApplicationAtomXml1
        {
        }

        public class Default1
        {
            public string _ref { get; set; }
        }

        public class Parameter1
        {
            public string name { get; set; }
            public string _in { get; set; }
            public string description { get; set; }
            public Schema1 schema { get; set; }
            public string style { get; set; }
            public bool explode { get; set; }
        }

        public class Schema1
        {
            public string type { get; set; }
            public Items1 items { get; set; }
            public string[] _enum { get; set; }
            public string format { get; set; }
            public int minimum { get; set; }
            public int maximum { get; set; }
        }

        public class Items1
        {
            public string type { get; set; }
            public string[] _enum { get; set; }
            public string format { get; set; }
        }

        public class AlertsTypes
        {
            public Get2 get { get; set; }
        }

        public class Get2
        {
            public string description { get; set; }
            public Responses2 responses { get; set; }
        }

        public class Responses2
        {
            public _2002 _200 { get; set; }
            public Default2 _default { get; set; }
        }

        public class _2002
        {
            public string description { get; set; }
            public Content2 content { get; set; }
        }

        public class Content2
        {
            public ApplicationLdJson2 applicationldjson { get; set; }
        }

        public class ApplicationLdJson2
        {
        }

        public class Default2
        {
            public string _ref { get; set; }
        }

        public class AlertsId
        {
            public Get3 get { get; set; }
        }

        public class Get3
        {
            public string description { get; set; }
            public Parameter2[] parameters { get; set; }
            public Responses3 responses { get; set; }
        }

        public class Responses3
        {
            public _2003 _200 { get; set; }
            public Default3 _default { get; set; }
        }

        public class _2003
        {
            public string description { get; set; }
            public Content3 content { get; set; }
        }

        public class Content3
        {
            public ApplicationGeoJson2 applicationgeojson { get; set; }
            public ApplicationLdJson3 applicationldjson { get; set; }
            public ApplicationCapXml applicationcapxml { get; set; }
        }

        public class ApplicationGeoJson2
        {
        }

        public class ApplicationLdJson3
        {
        }

        public class ApplicationCapXml
        {
        }

        public class Default3
        {
            public string _ref { get; set; }
        }

        public class Parameter2
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema2 schema { get; set; }
        }

        public class Schema2
        {
            public string type { get; set; }
        }

        public class AlertsActiveCount
        {
            public Get4 get { get; set; }
        }

        public class Get4
        {
            public string description { get; set; }
            public Responses4 responses { get; set; }
        }

        public class Responses4
        {
            public _2004 _200 { get; set; }
            public Default4 _default { get; set; }
        }

        public class _2004
        {
            public string description { get; set; }
            public Content4 content { get; set; }
        }

        public class Content4
        {
            public ApplicationLdJson4 applicationldjson { get; set; }
        }

        public class ApplicationLdJson4
        {
        }

        public class Default4
        {
            public string _ref { get; set; }
        }

        public class AlertsActiveZoneZoneid
        {
            public Get5 get { get; set; }
        }

        public class Get5
        {
            public string description { get; set; }
            public Parameter3[] parameters { get; set; }
            public Responses5 responses { get; set; }
        }

        public class Responses5
        {
            public _2005 _200 { get; set; }
            public Default5 _default { get; set; }
        }

        public class _2005
        {
            public string description { get; set; }
            public Content5 content { get; set; }
        }

        public class Content5
        {
            public ApplicationGeoJson3 applicationgeojson { get; set; }
            public ApplicationLdJson5 applicationldjson { get; set; }
            public ApplicationAtomXml2 applicationatomxml { get; set; }
        }

        public class ApplicationGeoJson3
        {
        }

        public class ApplicationLdJson5
        {
        }

        public class ApplicationAtomXml2
        {
        }

        public class Default5
        {
            public string _ref { get; set; }
        }

        public class Parameter3
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema3 schema { get; set; }
        }

        public class Schema3
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class AlertsActiveAreaArea
        {
            public Get6 get { get; set; }
        }

        public class Get6
        {
            public string description { get; set; }
            public Parameter4[] parameters { get; set; }
            public Responses6 responses { get; set; }
        }

        public class Responses6
        {
            public _2006 _200 { get; set; }
            public Default6 _default { get; set; }
        }

        public class _2006
        {
            public string description { get; set; }
            public Content6 content { get; set; }
        }

        public class Content6
        {
            public ApplicationGeoJson4 applicationgeojson { get; set; }
            public ApplicationLdJson6 applicationldjson { get; set; }
            public ApplicationAtomXml3 applicationatomxml { get; set; }
        }

        public class ApplicationGeoJson4
        {
        }

        public class ApplicationLdJson6
        {
        }

        public class ApplicationAtomXml3
        {
        }

        public class Default6
        {
            public string _ref { get; set; }
        }

        public class Parameter4
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema4 schema { get; set; }
        }

        public class Schema4
        {
            public string type { get; set; }
            public string[] _enum { get; set; }
        }

        public class AlertsActiveRegionRegion
        {
            public Get7 get { get; set; }
        }

        public class Get7
        {
            public string description { get; set; }
            public Parameter5[] parameters { get; set; }
            public Responses7 responses { get; set; }
        }

        public class Responses7
        {
            public _2007 _200 { get; set; }
            public Default7 _default { get; set; }
        }

        public class _2007
        {
            public string description { get; set; }
            public Content7 content { get; set; }
        }

        public class Content7
        {
            public ApplicationGeoJson5 applicationgeojson { get; set; }
            public ApplicationLdJson7 applicationldjson { get; set; }
            public ApplicationAtomXml4 applicationatomxml { get; set; }
        }

        public class ApplicationGeoJson5
        {
        }

        public class ApplicationLdJson7
        {
        }

        public class ApplicationAtomXml4
        {
        }

        public class Default7
        {
            public string _ref { get; set; }
        }

        public class Parameter5
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema5 schema { get; set; }
        }

        public class Schema5
        {
            public string type { get; set; }
            public string[] _enum { get; set; }
        }

        public class Glossary
        {
            public Get8 get { get; set; }
        }

        public class Get8
        {
            public string description { get; set; }
            public Responses8 responses { get; set; }
        }

        public class Responses8
        {
            public _2008 _200 { get; set; }
            public Default8 _default { get; set; }
        }

        public class _2008
        {
            public string description { get; set; }
            public Content8 content { get; set; }
        }

        public class Content8
        {
            public ApplicationLdJson8 applicationldjson { get; set; }
        }

        public class ApplicationLdJson8
        {
        }

        public class Default8
        {
            public string _ref { get; set; }
        }

        public class GridpointsWfoXY
        {
            public Get9 get { get; set; }
        }

        public class Get9
        {
            public string description { get; set; }
            public Parameter6[] parameters { get; set; }
            public Responses9 responses { get; set; }
        }

        public class Responses9
        {
            public _2009 _200 { get; set; }
            public Default9 _default { get; set; }
        }

        public class _2009
        {
            public string description { get; set; }
            public Content9 content { get; set; }
        }

        public class Content9
        {
            public ApplicationGeoJson6 applicationgeojson { get; set; }
            public ApplicationLdJson9 applicationldjson { get; set; }
        }

        public class ApplicationGeoJson6
        {
        }

        public class ApplicationLdJson9
        {
        }

        public class Default9
        {
            public string _ref { get; set; }
        }

        public class Parameter6
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema6 schema { get; set; }
        }

        public class Schema6
        {
            public string type { get; set; }
            public string format { get; set; }
            public int minimum { get; set; }
        }

        public class GridpointsWfoXYForecast
        {
            public Get10 get { get; set; }
        }

        public class Get10
        {
            public string description { get; set; }
            public Parameter7[] parameters { get; set; }
            public Responses10 responses { get; set; }
        }

        public class Responses10
        {
            public _20010 _200 { get; set; }
            public Default10 _default { get; set; }
        }

        public class _20010
        {
            public string description { get; set; }
            public Content10 content { get; set; }
        }

        public class Content10
        {
            public ApplicationGeoJson7 applicationgeojson { get; set; }
            public ApplicationLdJson10 applicationldjson { get; set; }
            public ApplicationVndNoaaDwmlXml applicationvndnoaadwmlxml { get; set; }
        }

        public class ApplicationGeoJson7
        {
        }

        public class ApplicationLdJson10
        {
        }

        public class ApplicationVndNoaaDwmlXml
        {
        }

        public class Default10
        {
            public string _ref { get; set; }
        }

        public class Parameter7
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema7 schema { get; set; }
            public string style { get; set; }
            public bool explode { get; set; }
        }

        public class Schema7
        {
            public string type { get; set; }
            public string format { get; set; }
            public int minimum { get; set; }
            public Items2 items { get; set; }
            public string[] _enum { get; set; }
            public string _default { get; set; }
        }

        public class Items2
        {
            public string type { get; set; }
            public string[] _enum { get; set; }
        }

        public class GridpointsWfoXYForecastHourly
        {
            public Get11 get { get; set; }
        }

        public class Get11
        {
            public string description { get; set; }
            public Parameter8[] parameters { get; set; }
            public Responses11 responses { get; set; }
        }

        public class Responses11
        {
            public _20011 _200 { get; set; }
            public Default11 _default { get; set; }
        }

        public class _20011
        {
            public string description { get; set; }
            public Content11 content { get; set; }
        }

        public class Content11
        {
            public ApplicationGeoJson8 applicationgeojson { get; set; }
            public ApplicationLdJson11 applicationldjson { get; set; }
            public ApplicationVndNoaaDwmlXml1 applicationvndnoaadwmlxml { get; set; }
        }

        public class ApplicationGeoJson8
        {
        }

        public class ApplicationLdJson11
        {
        }

        public class ApplicationVndNoaaDwmlXml1
        {
        }

        public class Default11
        {
            public string _ref { get; set; }
        }

        public class Parameter8
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema8 schema { get; set; }
            public string style { get; set; }
            public bool explode { get; set; }
        }

        public class Schema8
        {
            public string type { get; set; }
            public string format { get; set; }
            public int minimum { get; set; }
            public Items3 items { get; set; }
            public string[] _enum { get; set; }
            public string _default { get; set; }
        }

        public class Items3
        {
            public string type { get; set; }
            public string[] _enum { get; set; }
        }

        public class GridpointsWfoXYStations
        {
            public Get12 get { get; set; }
        }

        public class Get12
        {
            public string description { get; set; }
            public Parameter9[] parameters { get; set; }
            public Responses12 responses { get; set; }
        }

        public class Responses12
        {
            public _20012 _200 { get; set; }
            public Default12 _default { get; set; }
        }

        public class _20012
        {
            public string description { get; set; }
            public Content12 content { get; set; }
        }

        public class Content12
        {
            public ApplicationGeoJson9 applicationgeojson { get; set; }
            public ApplicationLdJson12 applicationldjson { get; set; }
        }

        public class ApplicationGeoJson9
        {
        }

        public class ApplicationLdJson12
        {
        }

        public class Default12
        {
            public string _ref { get; set; }
        }

        public class Parameter9
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema9 schema { get; set; }
        }

        public class Schema9
        {
            public string type { get; set; }
            public string format { get; set; }
            public int minimum { get; set; }
        }

        public class IconsSetTimeofdayFirstSecond
        {
            public Get13 get { get; set; }
        }

        public class Get13
        {
            public string description { get; set; }
            public Parameter10[] parameters { get; set; }
            public Responses13 responses { get; set; }
        }

        public class Responses13
        {
            public _20013 _200 { get; set; }
            public Default13 _default { get; set; }
        }

        public class _20013
        {
            public string description { get; set; }
            public Content13 content { get; set; }
        }

        public class Content13
        {
            public ImagePng imagepng { get; set; }
        }

        public class ImagePng
        {
        }

        public class Default13
        {
            public string _ref { get; set; }
        }

        public class Parameter10
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema10 schema { get; set; }
        }

        public class Schema10
        {
            public string type { get; set; }
            public Anyof[] anyOf { get; set; }
            public int minimum { get; set; }
            public int maximum { get; set; }
        }

        public class Anyof
        {
            public string type { get; set; }
            public string[] _enum { get; set; }
            public int minimum { get; set; }
            public int maximum { get; set; }
        }

        public class Icons
        {
            public Get14 get { get; set; }
        }

        public class Get14
        {
            public string description { get; set; }
            public Responses14 responses { get; set; }
        }

        public class Responses14
        {
            public _20014 _200 { get; set; }
            public Default14 _default { get; set; }
        }

        public class _20014
        {
            public string description { get; set; }
            public Content14 content { get; set; }
        }

        public class Content14
        {
            public ApplicationLdJson13 applicationldjson { get; set; }
        }

        public class ApplicationLdJson13
        {
        }

        public class Default14
        {
            public string _ref { get; set; }
        }

        public class ThumbnailsSatelliteArea
        {
            public Get15 get { get; set; }
        }

        public class Get15
        {
            public string description { get; set; }
            public Parameter11[] parameters { get; set; }
            public Responses15 responses { get; set; }
        }

        public class Responses15
        {
            public _20015 _200 { get; set; }
            public Default15 _default { get; set; }
        }

        public class _20015
        {
            public string description { get; set; }
            public Content15 content { get; set; }
        }

        public class Content15
        {
            public ImageJpeg imagejpeg { get; set; }
        }

        public class ImageJpeg
        {
        }

        public class Default15
        {
            public string _ref { get; set; }
        }

        public class Parameter11
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema11 schema { get; set; }
        }

        public class Schema11
        {
            public string type { get; set; }
        }

        public class StationsStationidObservations
        {
            public Get16 get { get; set; }
        }

        public class Get16
        {
            public string description { get; set; }
            public Parameter12[] parameters { get; set; }
            public Responses16 responses { get; set; }
        }

        public class Responses16
        {
            public _20016 _200 { get; set; }
            public Default16 _default { get; set; }
        }

        public class _20016
        {
            public string description { get; set; }
            public Content16 content { get; set; }
        }

        public class Content16
        {
            public ApplicationGeoJson10 applicationgeojson { get; set; }
            public ApplicationLdJson14 applicationldjson { get; set; }
        }

        public class ApplicationGeoJson10
        {
        }

        public class ApplicationLdJson14
        {
        }

        public class Default16
        {
            public string _ref { get; set; }
        }

        public class Parameter12
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema12 schema { get; set; }
            public string style { get; set; }
            public bool explode { get; set; }
        }

        public class Schema12
        {
            public string type { get; set; }
            public Items4 items { get; set; }
            public string format { get; set; }
            public int minimum { get; set; }
            public int maximum { get; set; }
        }

        public class Items4
        {
            public string type { get; set; }
        }

        public class StationsStationidObservationsLatest
        {
            public Get17 get { get; set; }
        }

        public class Get17
        {
            public string description { get; set; }
            public Parameter13[] parameters { get; set; }
            public Responses17 responses { get; set; }
        }

        public class Responses17
        {
            public _20017 _200 { get; set; }
            public Default17 _default { get; set; }
        }

        public class _20017
        {
            public string description { get; set; }
            public Content17 content { get; set; }
        }

        public class Content17
        {
            public ApplicationGeoJson11 applicationgeojson { get; set; }
            public ApplicationLdJson15 applicationldjson { get; set; }
            public ApplicationVndNoaaObsXml applicationvndnoaaobsxml { get; set; }
        }

        public class ApplicationGeoJson11
        {
        }

        public class ApplicationLdJson15
        {
        }

        public class ApplicationVndNoaaObsXml
        {
        }

        public class Default17
        {
            public string _ref { get; set; }
        }

        public class Parameter13
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema13 schema { get; set; }
        }

        public class Schema13
        {
            public string type { get; set; }
        }

        public class StationsStationidObservationsCurrent
        {
            public Get18 get { get; set; }
        }

        public class Get18
        {
            public string description { get; set; }
            public bool deprecated { get; set; }
            public Parameter14[] parameters { get; set; }
            public Responses18 responses { get; set; }
        }

        public class Responses18
        {
            public _20018 _200 { get; set; }
            public Default18 _default { get; set; }
        }

        public class _20018
        {
            public string description { get; set; }
            public Content18 content { get; set; }
        }

        public class Content18
        {
            public ApplicationGeoJson12 applicationgeojson { get; set; }
            public ApplicationLdJson16 applicationldjson { get; set; }
            public ApplicationVndNoaaObsXml1 applicationvndnoaaobsxml { get; set; }
        }

        public class ApplicationGeoJson12
        {
        }

        public class ApplicationLdJson16
        {
        }

        public class ApplicationVndNoaaObsXml1
        {
        }

        public class Default18
        {
            public string _ref { get; set; }
        }

        public class Parameter14
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema14 schema { get; set; }
        }

        public class Schema14
        {
            public string type { get; set; }
        }

        public class StationsStationidObservationsTime
        {
            public Get19 get { get; set; }
        }

        public class Get19
        {
            public string description { get; set; }
            public Parameter15[] parameters { get; set; }
            public Responses19 responses { get; set; }
        }

        public class Responses19
        {
            public _20019 _200 { get; set; }
            public Default19 _default { get; set; }
        }

        public class _20019
        {
            public string description { get; set; }
            public Content19 content { get; set; }
        }

        public class Content19
        {
            public ApplicationGeoJson13 applicationgeojson { get; set; }
            public ApplicationLdJson17 applicationldjson { get; set; }
            public ApplicationVndNoaaObsXml2 applicationvndnoaaobsxml { get; set; }
        }

        public class ApplicationGeoJson13
        {
        }

        public class ApplicationLdJson17
        {
        }

        public class ApplicationVndNoaaObsXml2
        {
        }

        public class Default19
        {
            public string _ref { get; set; }
        }

        public class Parameter15
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema15 schema { get; set; }
        }

        public class Schema15
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class Stations
        {
            public Get20 get { get; set; }
        }

        public class Get20
        {
            public string description { get; set; }
            public Parameter16[] parameters { get; set; }
            public Responses20 responses { get; set; }
        }

        public class Responses20
        {
            public _20020 _200 { get; set; }
            public Default20 _default { get; set; }
        }

        public class _20020
        {
            public string description { get; set; }
            public Content20 content { get; set; }
        }

        public class Content20
        {
            public ApplicationGeoJson14 applicationgeojson { get; set; }
            public ApplicationLdJson18 applicationldjson { get; set; }
        }

        public class ApplicationGeoJson14
        {
        }

        public class ApplicationLdJson18
        {
        }

        public class Default20
        {
            public string _ref { get; set; }
        }

        public class Parameter16
        {
            public string name { get; set; }
            public string _in { get; set; }
            public string description { get; set; }
            public Schema16 schema { get; set; }
            public string style { get; set; }
            public bool explode { get; set; }
        }

        public class Schema16
        {
            public string type { get; set; }
            public Items5 items { get; set; }
            public int minimum { get; set; }
            public int maximum { get; set; }
        }

        public class Items5
        {
            public string type { get; set; }
            public string[] _enum { get; set; }
        }

        public class StationsStationid
        {
            public Get21 get { get; set; }
        }

        public class Get21
        {
            public string description { get; set; }
            public Parameter17[] parameters { get; set; }
            public Responses21 responses { get; set; }
        }

        public class Responses21
        {
            public _20021 _200 { get; set; }
            public Default21 _default { get; set; }
        }

        public class _20021
        {
            public string description { get; set; }
            public Content21 content { get; set; }
        }

        public class Content21
        {
            public ApplicationGeoJson15 applicationgeojson { get; set; }
            public ApplicationLdJson19 applicationldjson { get; set; }
        }

        public class ApplicationGeoJson15
        {
        }

        public class ApplicationLdJson19
        {
        }

        public class Default21
        {
            public string _ref { get; set; }
        }

        public class Parameter17
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema17 schema { get; set; }
        }

        public class Schema17
        {
            public string type { get; set; }
        }

        public class OfficesOfficeid
        {
            public Get22 get { get; set; }
        }

        public class Get22
        {
            public string description { get; set; }
            public Parameter18[] parameters { get; set; }
            public Responses22 responses { get; set; }
        }

        public class Responses22
        {
            public _20022 _200 { get; set; }
            public Default22 _default { get; set; }
        }

        public class _20022
        {
            public string description { get; set; }
            public Content22 content { get; set; }
        }

        public class Content22
        {
            public ApplicationLdJson20 applicationldjson { get; set; }
        }

        public class ApplicationLdJson20
        {
        }

        public class Default22
        {
            public string _ref { get; set; }
        }

        public class Parameter18
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema18 schema { get; set; }
        }

        public class Schema18
        {
            public string type { get; set; }
        }

        public class OfficesOfficeidHeadlinesHeadlineid
        {
            public Get23 get { get; set; }
        }

        public class Get23
        {
            public string description { get; set; }
            public Parameter19[] parameters { get; set; }
            public Responses23 responses { get; set; }
        }

        public class Responses23
        {
            public _20023 _200 { get; set; }
            public Default23 _default { get; set; }
        }

        public class _20023
        {
            public string description { get; set; }
            public Content23 content { get; set; }
        }

        public class Content23
        {
            public ApplicationLdJson21 applicationldjson { get; set; }
        }

        public class ApplicationLdJson21
        {
        }

        public class Default23
        {
            public string _ref { get; set; }
        }

        public class Parameter19
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema19 schema { get; set; }
        }

        public class Schema19
        {
            public string type { get; set; }
        }

        public class OfficesOfficeidHeadlines
        {
            public Get24 get { get; set; }
        }

        public class Get24
        {
            public string description { get; set; }
            public Parameter20[] parameters { get; set; }
            public Responses24 responses { get; set; }
        }

        public class Responses24
        {
            public _20024 _200 { get; set; }
            public Default24 _default { get; set; }
        }

        public class _20024
        {
            public string description { get; set; }
            public Content24 content { get; set; }
        }

        public class Content24
        {
            public ApplicationLdJson22 applicationldjson { get; set; }
        }

        public class ApplicationLdJson22
        {
        }

        public class Default24
        {
            public string _ref { get; set; }
        }

        public class Parameter20
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema20 schema { get; set; }
        }

        public class Schema20
        {
            public string type { get; set; }
        }

        public class PointsPoint
        {
            public Get25 get { get; set; }
        }

        public class Get25
        {
            public string description { get; set; }
            public Parameter21[] parameters { get; set; }
            public Responses25 responses { get; set; }
        }

        public class Responses25
        {
            public _20025 _200 { get; set; }
            public Default25 _default { get; set; }
        }

        public class _20025
        {
            public string description { get; set; }
            public Content25 content { get; set; }
        }

        public class Content25
        {
            public ApplicationGeoJson16 applicationgeojson { get; set; }
            public ApplicationLdJson23 applicationldjson { get; set; }
        }

        public class ApplicationGeoJson16
        {
        }

        public class ApplicationLdJson23
        {
        }

        public class Default25
        {
            public string _ref { get; set; }
        }

        public class Parameter21
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema21 schema { get; set; }
        }

        public class Schema21
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class PointsPointStations
        {
            public Get26 get { get; set; }
        }

        public class Get26
        {
            public string description { get; set; }
            public Parameter22[] parameters { get; set; }
            public Responses26 responses { get; set; }
        }

        public class Responses26
        {
            public _20026 _200 { get; set; }
            public Default26 _default { get; set; }
        }

        public class _20026
        {
            public string description { get; set; }
            public Content26 content { get; set; }
        }

        public class Content26
        {
            public ApplicationGeoJson17 applicationgeojson { get; set; }
            public ApplicationLdJson24 applicationldjson { get; set; }
        }

        public class ApplicationGeoJson17
        {
        }

        public class ApplicationLdJson24
        {
        }

        public class Default26
        {
            public string _ref { get; set; }
        }

        public class Parameter22
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema22 schema { get; set; }
        }

        public class Schema22
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class PointsPointForecast
        {
            public Get27 get { get; set; }
        }

        public class Get27
        {
            public string description { get; set; }
            public bool deprecated { get; set; }
            public Parameter23[] parameters { get; set; }
            public Responses27 responses { get; set; }
        }

        public class Responses27
        {
            public _20027 _200 { get; set; }
            public Default27 _default { get; set; }
        }

        public class _20027
        {
            public string description { get; set; }
            public Content27 content { get; set; }
        }

        public class Content27
        {
            public ApplicationGeoJson18 applicationgeojson { get; set; }
            public ApplicationLdJson25 applicationldjson { get; set; }
            public ApplicationVndNoaaDwmlXml2 applicationvndnoaadwmlxml { get; set; }
        }

        public class ApplicationGeoJson18
        {
        }

        public class ApplicationLdJson25
        {
        }

        public class ApplicationVndNoaaDwmlXml2
        {
        }

        public class Default27
        {
            public string _ref { get; set; }
        }

        public class Parameter23
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema23 schema { get; set; }
        }

        public class Schema23
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class PointsPointForecastHourly
        {
            public Get28 get { get; set; }
        }

        public class Get28
        {
            public string description { get; set; }
            public bool deprecated { get; set; }
            public Parameter24[] parameters { get; set; }
            public Responses28 responses { get; set; }
        }

        public class Responses28
        {
            public _20028 _200 { get; set; }
            public Default28 _default { get; set; }
        }

        public class _20028
        {
            public string description { get; set; }
            public Content28 content { get; set; }
        }

        public class Content28
        {
            public ApplicationGeoJson19 applicationgeojson { get; set; }
            public ApplicationLdJson26 applicationldjson { get; set; }
            public ApplicationVndNoaaDwmlXml3 applicationvndnoaadwmlxml { get; set; }
        }

        public class ApplicationGeoJson19
        {
        }

        public class ApplicationLdJson26
        {
        }

        public class ApplicationVndNoaaDwmlXml3
        {
        }

        public class Default28
        {
            public string _ref { get; set; }
        }

        public class Parameter24
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema24 schema { get; set; }
        }

        public class Schema24
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class RadarServers
        {
            public Get29 get { get; set; }
        }

        public class Get29
        {
            public string description { get; set; }
            public Parameter25[] parameters { get; set; }
            public Responses29 responses { get; set; }
        }

        public class Responses29
        {
            public _20029 _200 { get; set; }
            public Default29 _default { get; set; }
        }

        public class _20029
        {
            public string description { get; set; }
            public Content29 content { get; set; }
        }

        public class Content29
        {
            public ApplicationLdJson27 applicationldjson { get; set; }
        }

        public class ApplicationLdJson27
        {
        }

        public class Default29
        {
            public string _ref { get; set; }
        }

        public class Parameter25
        {
            public string name { get; set; }
            public string _in { get; set; }
            public string description { get; set; }
            public Schema25 schema { get; set; }
        }

        public class Schema25
        {
            public string type { get; set; }
        }

        public class RadarServersId
        {
            public Get30 get { get; set; }
        }

        public class Get30
        {
            public string description { get; set; }
            public Parameter26[] parameters { get; set; }
            public Responses30 responses { get; set; }
        }

        public class Responses30
        {
            public _20030 _200 { get; set; }
            public Default30 _default { get; set; }
        }

        public class _20030
        {
            public string description { get; set; }
            public Content30 content { get; set; }
        }

        public class Content30
        {
            public ApplicationLdJson28 applicationldjson { get; set; }
        }

        public class ApplicationLdJson28
        {
        }

        public class Default30
        {
            public string _ref { get; set; }
        }

        public class Parameter26
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema26 schema { get; set; }
        }

        public class Schema26
        {
            public string type { get; set; }
        }

        public class RadarStations
        {
            public Get31 get { get; set; }
        }

        public class Get31
        {
            public string description { get; set; }
            public Parameter27[] parameters { get; set; }
            public Responses31 responses { get; set; }
        }

        public class Responses31
        {
            public _20031 _200 { get; set; }
            public Default31 _default { get; set; }
        }

        public class _20031
        {
            public string description { get; set; }
            public Content31 content { get; set; }
        }

        public class Content31
        {
            public ApplicationGeoJson20 applicationgeojson { get; set; }
            public ApplicationLdJson29 applicationldjson { get; set; }
        }

        public class ApplicationGeoJson20
        {
        }

        public class ApplicationLdJson29
        {
        }

        public class Default31
        {
            public string _ref { get; set; }
        }

        public class Parameter27
        {
            public string name { get; set; }
            public string _in { get; set; }
            public string description { get; set; }
            public Schema27 schema { get; set; }
            public string style { get; set; }
            public bool explode { get; set; }
        }

        public class Schema27
        {
            public string type { get; set; }
            public Items6 items { get; set; }
        }

        public class Items6
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class RadarStationsStationid
        {
            public Get32 get { get; set; }
        }

        public class Get32
        {
            public string description { get; set; }
            public Parameter28[] parameters { get; set; }
            public Responses32 responses { get; set; }
        }

        public class Responses32
        {
            public _20032 _200 { get; set; }
            public Default32 _default { get; set; }
        }

        public class _20032
        {
            public string description { get; set; }
            public Content32 content { get; set; }
        }

        public class Content32
        {
            public ApplicationGeoJson21 applicationgeojson { get; set; }
            public ApplicationLdJson30 applicationldjson { get; set; }
        }

        public class ApplicationGeoJson21
        {
        }

        public class ApplicationLdJson30
        {
        }

        public class Default32
        {
            public string _ref { get; set; }
        }

        public class Parameter28
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema28 schema { get; set; }
        }

        public class Schema28
        {
            public string type { get; set; }
        }

        public class RadarStationsStationidAlarms
        {
            public Get33 get { get; set; }
        }

        public class Get33
        {
            public string description { get; set; }
            public Parameter29[] parameters { get; set; }
            public Responses33 responses { get; set; }
        }

        public class Responses33
        {
            public _20033 _200 { get; set; }
            public Default33 _default { get; set; }
        }

        public class _20033
        {
            public string description { get; set; }
            public Content33 content { get; set; }
        }

        public class Content33
        {
            public ApplicationLdJson31 applicationldjson { get; set; }
        }

        public class ApplicationLdJson31
        {
        }

        public class Default33
        {
            public string _ref { get; set; }
        }

        public class Parameter29
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema29 schema { get; set; }
        }

        public class Schema29
        {
            public string type { get; set; }
        }

        public class RadarQueuesHost
        {
            public Get34 get { get; set; }
        }

        public class Get34
        {
            public string description { get; set; }
            public Parameter30[] parameters { get; set; }
            public Responses34 responses { get; set; }
        }

        public class Responses34
        {
            public _20034 _200 { get; set; }
            public Default34 _default { get; set; }
        }

        public class _20034
        {
            public string description { get; set; }
            public Content34 content { get; set; }
        }

        public class Content34
        {
            public ApplicationLdJson32 applicationldjson { get; set; }
        }

        public class ApplicationLdJson32
        {
        }

        public class Default34
        {
            public string _ref { get; set; }
        }

        public class Parameter30
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema30 schema { get; set; }
        }

        public class Schema30
        {
            public string type { get; set; }
            public int minimum { get; set; }
            public int maximum { get; set; }
            public string pattern { get; set; }
        }

        public class RadarProfilersStationid
        {
            public Get35 get { get; set; }
        }

        public class Get35
        {
            public string description { get; set; }
            public Parameter31[] parameters { get; set; }
            public Responses35 responses { get; set; }
        }

        public class Responses35
        {
            public _20035 _200 { get; set; }
            public Default35 _default { get; set; }
        }

        public class _20035
        {
            public string description { get; set; }
            public Content35 content { get; set; }
        }

        public class Content35
        {
            public ApplicationLdJson33 applicationldjson { get; set; }
        }

        public class ApplicationLdJson33
        {
        }

        public class Default35
        {
            public string _ref { get; set; }
        }

        public class Parameter31
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema31 schema { get; set; }
        }

        public class Schema31
        {
            public string type { get; set; }
            public string pattern { get; set; }
            public string format { get; set; }
        }

        public class Products
        {
            public Get36 get { get; set; }
        }

        public class Get36
        {
            public string description { get; set; }
            public Parameter32[] parameters { get; set; }
            public Responses36 responses { get; set; }
        }

        public class Responses36
        {
            public _20036 _200 { get; set; }
            public Default36 _default { get; set; }
        }

        public class _20036
        {
            public string description { get; set; }
            public Content36 content { get; set; }
        }

        public class Content36
        {
            public ApplicationLdJson34 applicationldjson { get; set; }
        }

        public class ApplicationLdJson34
        {
        }

        public class Default36
        {
            public string _ref { get; set; }
        }

        public class Parameter32
        {
            public string name { get; set; }
            public string _in { get; set; }
            public string description { get; set; }
            public Schema32 schema { get; set; }
            public string style { get; set; }
            public bool explode { get; set; }
        }

        public class Schema32
        {
            public string type { get; set; }
            public Items7 items { get; set; }
            public string format { get; set; }
            public int minimum { get; set; }
            public int maximum { get; set; }
        }

        public class Items7
        {
            public string type { get; set; }
            public string format { get; set; }
        }

        public class ProductsLocations
        {
            public Get37 get { get; set; }
        }

        public class Get37
        {
            public string description { get; set; }
            public Responses37 responses { get; set; }
        }

        public class Responses37
        {
            public _20037 _200 { get; set; }
            public Default37 _default { get; set; }
        }

        public class _20037
        {
            public string description { get; set; }
            public Content37 content { get; set; }
        }

        public class Content37
        {
            public ApplicationLdJson35 applicationldjson { get; set; }
        }

        public class ApplicationLdJson35
        {
        }

        public class Default37
        {
            public string _ref { get; set; }
        }

        public class ProductsTypes
        {
            public Get38 get { get; set; }
        }

        public class Get38
        {
            public string description { get; set; }
            public Responses38 responses { get; set; }
        }

        public class Responses38
        {
            public _20038 _200 { get; set; }
            public Default38 _default { get; set; }
        }

        public class _20038
        {
            public string description { get; set; }
            public Content38 content { get; set; }
        }

        public class Content38
        {
            public ApplicationLdJson36 applicationldjson { get; set; }
        }

        public class ApplicationLdJson36
        {
        }

        public class Default38
        {
            public string _ref { get; set; }
        }

        public class ProductsProductid
        {
            public Get39 get { get; set; }
        }

        public class Get39
        {
            public string description { get; set; }
            public Parameter33[] parameters { get; set; }
            public Responses39 responses { get; set; }
        }

        public class Responses39
        {
            public _20039 _200 { get; set; }
            public Default39 _default { get; set; }
        }

        public class _20039
        {
            public string description { get; set; }
            public Content39 content { get; set; }
        }

        public class Content39
        {
            public ApplicationLdJson37 applicationldjson { get; set; }
        }

        public class ApplicationLdJson37
        {
        }

        public class Default39
        {
            public string _ref { get; set; }
        }

        public class Parameter33
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema33 schema { get; set; }
        }

        public class Schema33
        {
            public string type { get; set; }
        }

        public class ProductsTypesTypeid
        {
            public Get40 get { get; set; }
        }

        public class Get40
        {
            public string description { get; set; }
            public Parameter34[] parameters { get; set; }
            public Responses40 responses { get; set; }
        }

        public class Responses40
        {
            public _20040 _200 { get; set; }
            public Default40 _default { get; set; }
        }

        public class _20040
        {
            public string description { get; set; }
            public Content40 content { get; set; }
        }

        public class Content40
        {
            public ApplicationLdJson38 applicationldjson { get; set; }
        }

        public class ApplicationLdJson38
        {
        }

        public class Default40
        {
            public string _ref { get; set; }
        }

        public class Parameter34
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema34 schema { get; set; }
        }

        public class Schema34
        {
            public string type { get; set; }
        }

        public class ProductsTypesTypeidLocations
        {
            public Get41 get { get; set; }
        }

        public class Get41
        {
            public string description { get; set; }
            public Parameter35[] parameters { get; set; }
            public Responses41 responses { get; set; }
        }

        public class Responses41
        {
            public _20041 _200 { get; set; }
            public Default41 _default { get; set; }
        }

        public class _20041
        {
            public string description { get; set; }
            public Content41 content { get; set; }
        }

        public class Content41
        {
            public ApplicationLdJson39 applicationldjson { get; set; }
        }

        public class ApplicationLdJson39
        {
        }

        public class Default41
        {
            public string _ref { get; set; }
        }

        public class Parameter35
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema35 schema { get; set; }
        }

        public class Schema35
        {
            public string type { get; set; }
        }

        public class ProductsLocationsLocationidTypes
        {
            public Get42 get { get; set; }
        }

        public class Get42
        {
            public string description { get; set; }
            public Parameter36[] parameters { get; set; }
            public Responses42 responses { get; set; }
        }

        public class Responses42
        {
            public _20042 _200 { get; set; }
            public Default42 _default { get; set; }
        }

        public class _20042
        {
            public string description { get; set; }
            public Content42 content { get; set; }
        }

        public class Content42
        {
            public ApplicationLdJson40 applicationldjson { get; set; }
        }

        public class ApplicationLdJson40
        {
        }

        public class Default42
        {
            public string _ref { get; set; }
        }

        public class Parameter36
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema36 schema { get; set; }
        }

        public class Schema36
        {
            public string type { get; set; }
        }

        public class ProductsTypesTypeidLocationsLocationid
        {
            public Get43 get { get; set; }
        }

        public class Get43
        {
            public string description { get; set; }
            public Parameter37[] parameters { get; set; }
            public Responses43 responses { get; set; }
        }

        public class Responses43
        {
            public _20043 _200 { get; set; }
            public Default43 _default { get; set; }
        }

        public class _20043
        {
            public string description { get; set; }
            public Content43 content { get; set; }
        }

        public class Content43
        {
            public ApplicationLdJson41 applicationldjson { get; set; }
        }

        public class ApplicationLdJson41
        {
        }

        public class Default43
        {
            public string _ref { get; set; }
        }

        public class Parameter37
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema37 schema { get; set; }
        }

        public class Schema37
        {
            public string type { get; set; }
        }

        public class Zones
        {
            public Get44 get { get; set; }
        }

        public class Get44
        {
            public string description { get; set; }
            public Parameter38[] parameters { get; set; }
            public Responses44 responses { get; set; }
        }

        public class Responses44
        {
            public _20044 _200 { get; set; }
            public Default44 _default { get; set; }
        }

        public class _20044
        {
            public string description { get; set; }
            public Content44 content { get; set; }
        }

        public class Content44
        {
            public ApplicationGeoJson22 applicationgeojson { get; set; }
            public ApplicationLdJson42 applicationldjson { get; set; }
        }

        public class ApplicationGeoJson22
        {
        }

        public class ApplicationLdJson42
        {
        }

        public class Default44
        {
            public string _ref { get; set; }
        }

        public class Parameter38
        {
            public string name { get; set; }
            public string _in { get; set; }
            public string description { get; set; }
            public Schema38 schema { get; set; }
            public string style { get; set; }
            public bool explode { get; set; }
        }

        public class Schema38
        {
            public string type { get; set; }
            public Items8 items { get; set; }
            public string format { get; set; }
            public int minimum { get; set; }
        }

        public class Items8
        {
            public string type { get; set; }
            public string format { get; set; }
            public string[] _enum { get; set; }
        }

        public class ZonesType
        {
            public Get45 get { get; set; }
        }

        public class Get45
        {
            public string description { get; set; }
            public Parameter39[] parameters { get; set; }
            public Responses45 responses { get; set; }
        }

        public class Responses45
        {
            public _20045 _200 { get; set; }
            public Default45 _default { get; set; }
        }

        public class _20045
        {
            public string description { get; set; }
            public Content45 content { get; set; }
        }

        public class Content45
        {
            public ApplicationGeoJson23 applicationgeojson { get; set; }
            public ApplicationLdJson43 applicationldjson { get; set; }
        }

        public class ApplicationGeoJson23
        {
        }

        public class ApplicationLdJson43
        {
        }

        public class Default45
        {
            public string _ref { get; set; }
        }

        public class Parameter39
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema39 schema { get; set; }
            public string style { get; set; }
            public bool explode { get; set; }
        }

        public class Schema39
        {
            public string type { get; set; }
            public string[] _enum { get; set; }
            public Items9 items { get; set; }
            public string format { get; set; }
            public int minimum { get; set; }
        }

        public class Items9
        {
            public string type { get; set; }
            public string format { get; set; }
            public string[] _enum { get; set; }
        }

        public class ZonesTypeZoneid
        {
            public Get46 get { get; set; }
        }

        public class Get46
        {
            public string description { get; set; }
            public Parameter40[] parameters { get; set; }
            public Responses46 responses { get; set; }
        }

        public class Responses46
        {
            public _20046 _200 { get; set; }
            public Default46 _default { get; set; }
        }

        public class _20046
        {
            public string description { get; set; }
            public Content46 content { get; set; }
        }

        public class Content46
        {
            public ApplicationGeoJson24 applicationgeojson { get; set; }
            public ApplicationLdJson44 applicationldjson { get; set; }
        }

        public class ApplicationGeoJson24
        {
        }

        public class ApplicationLdJson44
        {
        }

        public class Default46
        {
            public string _ref { get; set; }
        }

        public class Parameter40
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema40 schema { get; set; }
        }

        public class Schema40
        {
            public string type { get; set; }
            public string[] _enum { get; set; }
            public string format { get; set; }
        }

        public class ZonesTypeZoneidForecast
        {
            public Get47 get { get; set; }
        }

        public class Get47
        {
            public string description { get; set; }
            public Parameter41[] parameters { get; set; }
            public Responses47 responses { get; set; }
        }

        public class Responses47
        {
            public _20047 _200 { get; set; }
            public Default47 _default { get; set; }
        }

        public class _20047
        {
            public string description { get; set; }
            public Content47 content { get; set; }
        }

        public class Content47
        {
            public ApplicationGeoJson25 applicationgeojson { get; set; }
            public ApplicationLdJson45 applicationldjson { get; set; }
        }

        public class ApplicationGeoJson25
        {
        }

        public class ApplicationLdJson45
        {
        }

        public class Default47
        {
            public string _ref { get; set; }
        }

        public class Parameter41
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema41 schema { get; set; }
        }

        public class Schema41
        {
            public string type { get; set; }
        }

        public class ZonesForecastZoneidObservations
        {
            public Get48 get { get; set; }
        }

        public class Get48
        {
            public string description { get; set; }
            public Parameter42[] parameters { get; set; }
            public Responses48 responses { get; set; }
        }

        public class Responses48
        {
            public _20048 _200 { get; set; }
            public Default48 _default { get; set; }
        }

        public class _20048
        {
            public string description { get; set; }
            public Content48 content { get; set; }
        }

        public class Content48
        {
            public ApplicationGeoJson26 applicationgeojson { get; set; }
            public ApplicationLdJson46 applicationldjson { get; set; }
        }

        public class ApplicationGeoJson26
        {
        }

        public class ApplicationLdJson46
        {
        }

        public class Default48
        {
            public string _ref { get; set; }
        }

        public class Parameter42
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema42 schema { get; set; }
        }

        public class Schema42
        {
            public string type { get; set; }
            public string format { get; set; }
            public int minimum { get; set; }
            public int maximum { get; set; }
        }

        public class ZonesForecastZoneidStations
        {
            public Get49 get { get; set; }
        }

        public class Get49
        {
            public string description { get; set; }
            public Parameter43[] parameters { get; set; }
            public Responses49 responses { get; set; }
        }

        public class Responses49
        {
            public _20049 _200 { get; set; }
            public Default49 _default { get; set; }
        }

        public class _20049
        {
            public string description { get; set; }
            public Content49 content { get; set; }
        }

        public class Content49
        {
            public ApplicationGeoJson27 applicationgeojson { get; set; }
            public ApplicationLdJson47 applicationldjson { get; set; }
        }

        public class ApplicationGeoJson27
        {
        }

        public class ApplicationLdJson47
        {
        }

        public class Default49
        {
            public string _ref { get; set; }
        }

        public class Parameter43
        {
            public string name { get; set; }
            public string _in { get; set; }
            public bool required { get; set; }
            public string description { get; set; }
            public Schema43 schema { get; set; }
        }

        public class Schema43
        {
            public string type { get; set; }
        }

        public class Components
        {
            public Schemas schemas { get; set; }
            public Responses50 responses { get; set; }
        }

        public class Schemas
        {
            public Error Error { get; set; }
        }

        public class Error
        {
            public string description { get; set; }
            public string type { get; set; }
            public Properties properties { get; set; }
            public string[] required { get; set; }
            public bool additionalProperties { get; set; }
            public Example example { get; set; }
        }

        public class Properties
        {
            public Type type { get; set; }
            public Title title { get; set; }
            public Status status { get; set; }
            public Detail detail { get; set; }
            public Instance instance { get; set; }
            public Correlationid correlationId { get; set; }
        }

        public class Type
        {
            public string type { get; set; }
            public string format { get; set; }
            public string _default { get; set; }
            public string description { get; set; }
        }

        public class Title
        {
            public string type { get; set; }
            public string description { get; set; }
        }

        public class Status
        {
            public string type { get; set; }
            public int minimum { get; set; }
            public int maximum { get; set; }
            public string description { get; set; }
        }

        public class Detail
        {
            public string type { get; set; }
            public string description { get; set; }
        }

        public class Instance
        {
            public string type { get; set; }
            public string format { get; set; }
            public string description { get; set; }
        }

        public class Correlationid
        {
            public string type { get; set; }
            public string format { get; set; }
            public string description { get; set; }
        }

        public class Example
        {
            public string title { get; set; }
            public string type { get; set; }
            public int status { get; set; }
            public string detail { get; set; }
            public string instance { get; set; }
            public string correlationId { get; set; }
        }

        public class Responses50
        {
            public Error1 Error { get; set; }
        }

        public class Error1
        {
            public string description { get; set; }
            public Content50 content { get; set; }
        }

        public class Content50
        {
            public ApplicationProblemJson applicationproblemjson { get; set; }
        }

        public class ApplicationProblemJson
        {
            public Schema44 schema { get; set; }
        }

        public class Schema44
        {
            public string _ref { get; set; }
        }

        public class Server
        {
            public string url { get; set; }
            public string description { get; set; }
        }

    }
}
