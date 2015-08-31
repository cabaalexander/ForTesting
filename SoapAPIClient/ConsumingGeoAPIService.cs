using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoapAPIClient.GeoIPService;

namespace SoapAPIClient
{
    public class ConsumingGeoAPIService
    {
        private string ip;

        public ConsumingGeoAPIService(string ip)
        {
            this.ip = ip;
        }

        private GeoIP getResponse()
        {
            GeoIPServiceSoapClient client = new GeoIPServiceSoapClient();
            GeoIP response = client.GetGeoIP(ip);
            return response;
        }

        public string IP
        {
            get
            {
                return getResponse().IP;
            }
        }

        public string CountryName
        {
            get
            {
                return getResponse().CountryName;
            }
        }

        public string CountryCode
        {
            get
            {
                return getResponse().CountryCode;
            }
        }

        public int ReturnCode
        {
            get
            {
                return getResponse().ReturnCode;
            }
        }

        public string ReturnCodeDetails
        {
            get
            {
                return getResponse().ReturnCodeDetails;
            }
        }
    }
}
