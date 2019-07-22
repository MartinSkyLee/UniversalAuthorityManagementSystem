using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DHSurvey.Common.Helper
{
    public class GaodeHelper
    {
        //高德平台申请的秘钥
        public static string SecretKey = "3c27306e2ad037fd712a76beec4c3b55";

        /// <summary>
        /// 获取经纬度
        /// </summary>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <returns></returns>
        public static string GetGeocode(string address, string city)
        {
            string geocodeUrl = "http://restapi.amap.com/v3/geocode/geo?address={Address}&city={City}&output=json&key={SecretKey}"
                .Replace("{SecretKey}", SecretKey)
                .Replace("{Address}", address)
                .Replace("{City}", city);

            string geocode = WebClientDownloadInfoToString(geocodeUrl);
            geocode = GetLatitudeAndLongitude(geocode);
            return geocode;
        }

        /// <summary>
        /// 获取城市之间的距离
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="beginCity"></param>
        /// <param name="end"></param>
        /// <param name="endCity"></param>
        /// <returns></returns>
        public static string GetDistance(string begin, string beginCity, string end, string endCity)
        {
            string origin = GetGeocode(begin, beginCity);
            string destination = GetGeocode(end, endCity);
            string driveUri = "http://restapi.amap.com/v3/direction/driving?key={SecretKey}&origin={Origin}&destination={Destination}"
                .Replace("{SecretKey}", SecretKey)
                .Replace("{Origin}", origin)
                .Replace("{Destination}", destination);

            string result = WebClientDownloadInfo(driveUri);
            //var gd = Newtonsoft.Json.JsonConvert.DeserializeObject<GaodeReturn>(result);
            return result;
        }

        /// <summary>
        /// 坐标转换
        /// </summary>
        /// <param name="locations">位置信息 例:116.481499,39.990475</param>
        /// <param name="coordsys">转换前的坐标系 可选值:gps;mapbar;baidu;autonavi(不进行转换)</param>
        /// <returns></returns>
        public static decimal[] TranGaodeCoordinate(decimal lon,decimal lat,string coordsys)
        {
            string locations = lon.ToString() + "," + lat.ToString();
            string geoUrl = "http://restapi.amap.com/v3/assistant/coordinate/convert?locations={Location}&coordsys={Coordsys}&output=json&key={SecretKey}"
                .Replace("{SecretKey}", SecretKey)
                .Replace("{Location}", locations)
                .Replace("{Coordsys}", coordsys);
            GaodeLocationModel model = JsonConvertor.Deserialize<GaodeLocationModel>(WebClientDownloadInfo(geoUrl)) ;
            if(DataConvert.ToInt32(model.status) == 1)
            {
                string[] str = model.locations.Split(',');
                decimal[] result = { DataConvert.ToDecimal(str[0]), DataConvert.ToDecimal(str[1]) };
                return result;
            }
            return null;            
        }

        private static string WebClientDownloadInfo(string uri)
        {
            string result = string.Empty;
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/xml;charset=UTF-8";
                result = wc.DownloadString(uri);
            }
            return result;
        }

        /// <summary>
        /// 模拟请求
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        private static string WebClientDownloadInfoToString(string uri)
        {
            string result = string.Empty;
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/xml;charset=UTF-8";
                result = wc.DownloadString(uri);
            }
            return result;
        }

        /// <summary>
        /// 解析返回的经纬度信息
        /// </summary>
        /// <param name="GeocodeJsonFormat"></param>
        /// <returns></returns>
        private static string GetLatitudeAndLongitude(string GeocodeJsonFormat)
        {
            JObject o = JObject.Parse(GeocodeJsonFormat);
            string geocodes = (string)o["geocodes"][0]["location"];
            return geocodes;
        }
    }

    public class GaodeLocationModel
    {
        public string status { get; set; }
        public string info { get; set; }
        public string infocode { get; set; }
        public string locations { get; set; }
    }
}
