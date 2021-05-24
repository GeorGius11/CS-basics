using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    class WeatherModel
    {
        int t, w; string h;
        public string TEMPERATURE { get { return $"Temperature: {t} ℃"; } set { int.TryParse(value, out t); } }
        public string WIND { get { return $"Wind speed: {w} m/s"; } set { int.TryParse(value, out w); } }
        
        public string DATE { get { return $"{DAY}.{MONTH}.{YEAR}"; } set { DATE = value; } }

        public string DAY { get; set; }
        public string MONTH { get; set; }
        public string YEAR { get; set; }
        public string HOUR { get { return $"Time: {h}:00"; } set { h = value; } }
        public string City { get; internal set; }
    }
}
