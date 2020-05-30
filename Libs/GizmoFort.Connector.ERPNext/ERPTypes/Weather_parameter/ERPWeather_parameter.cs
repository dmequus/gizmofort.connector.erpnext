using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Weather_parameter
{
    public class ERPWeather_parameter : ERPNextObjectBase
    {
        public ERPWeather_parameter() : this(new ERPObject(DocType.Weather_parameter)) { }
        public ERPWeather_parameter(ERPObject obj) : base(obj) { }

        public static ERPWeather_parameter Create(string title, string value, string minimumpermissiblevalue, string maximumpermissiblevalue)

        {
            ERPWeather_parameter obj = new ERPWeather_parameter();
            obj.title = title;
            obj.value = value;
            obj.minimum_permissible_value = minimumpermissiblevalue;
            obj.maximum_permissible_value = maximumpermissiblevalue;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string value
        {
            get { return data.value; }
            set { data.value = value; }
        }

        public string minimum_permissible_value
        {
            get { return data.minimum_permissible_value; }
            set { data.minimum_permissible_value = value; }
        }

        public string maximum_permissible_value
        {
            get { return data.maximum_permissible_value; }
            set { data.maximum_permissible_value = value; }
        }


    }

    //Enums go here

}