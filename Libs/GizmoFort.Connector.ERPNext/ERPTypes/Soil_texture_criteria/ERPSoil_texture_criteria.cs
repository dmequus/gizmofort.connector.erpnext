using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Soil_texture_criteria
{
    public class ERPSoil_texture_criteria : ERPNextObjectBase
    {
        public ERPSoil_texture_criteria() : this(new ERPObject(DocType.Soil_texture_criteria)) { }
        public ERPSoil_texture_criteria(ERPObject obj) : base(obj) { }

        public static ERPSoil_texture_criteria Create(string title, string value, string minimumpermissiblevalue, string maximumpermissiblevalue)

        {
            ERPSoil_texture_criteria obj = new ERPSoil_texture_criteria();
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