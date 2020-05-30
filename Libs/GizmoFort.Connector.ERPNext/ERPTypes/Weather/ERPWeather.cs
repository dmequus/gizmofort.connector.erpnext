using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Weather
{
    public class ERPWeather : ERPNextObjectBase
    {
        public ERPWeather() : this(new ERPObject(DocType.Weather)) { }
        public ERPWeather(ERPObject obj) : base(obj) { }

        public static ERPWeather Create(string location, string date, string source, string weatherparameter)

        {
            ERPWeather obj = new ERPWeather();
            obj.location = location;
            obj.date = date;
            obj.source = source;
            obj.weather_parameter = weatherparameter;
            return obj;
        }

        public string location
        {
            get { return data.location; }
            set
            {
                data.location = value;
                data.name = value;
            }

        }

        public string date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        public string source
        {
            get { return data.source; }
            set { data.source = value; }
        }

        public string weather_parameter
        {
            get { return data.weather_parameter; }
            set { data.weather_parameter = value; }
        }


    }

    //Enums go here

}