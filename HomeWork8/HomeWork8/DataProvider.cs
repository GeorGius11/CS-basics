using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork8
{
    class DataProvider
    {
        static Dictionary<string, string> urls;

        static DataProvider()
        {
            urls = new Dictionary<string, string>()
            {
                { "Odesa", @"https://xml.meteoservice.ru/export/gismeteo/point/55.xml" },
                { "Kyiv", @"https://xml.meteoservice.ru/export/gismeteo/point/25.xml" }
            };

        }

        HttpClient httpClient;

        public DataProvider()
        {
            httpClient = new HttpClient();
        }

        public ObservableCollection<WeatherModel> GetWeatherModels()
        {
            ObservableCollection<WeatherModel> temp = new ObservableCollection<WeatherModel>();

            foreach (var url in urls)
            {
                var req = httpClient.GetStringAsync(url.Value).Result;

                var colWeather = XDocument.Parse(req)
                                    .Descendants("MMWEATHER")
                                    .Descendants("REPORT")
                                    .Descendants("TOWN")
                                    .Descendants("FORECAST")
                                    .ToList();
                foreach (var FORECAST in colWeather)
                {
                    temp.Add(
                        new WeatherModel()
                        {
                            City = url.Key,
                            DAY = FORECAST.Attribute("day").Value,
                            MONTH = FORECAST.Attribute("month").Value,
                            YEAR = FORECAST.Attribute("year").Value,
                            HOUR = FORECAST.Attribute("hour").Value,
                            TEMPERATURE = FORECAST.Element("TEMPERATURE").Attribute("max").Value,
                            WIND = FORECAST.Element("WIND").Attribute("max").Value
                            
                        }
                        ) ;
                }


                
            }

            return temp;
        }
    }
}
