using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Plant_analysis_criteria
{
    public class ERPPlant_analysis_criteria : ERPNextObjectBase
    {
        public ERPPlant_analysis_criteria() : this(new ERPObject(DocType.Plant_analysis_criteria)) { }
        public ERPPlant_analysis_criteria(ERPObject obj) : base(obj) { }

        public static ERPPlant_analysis_criteria Create(string title, string value, string minimumpermissiblevalue, string maximumpermissiblevalue)

        {
            ERPPlant_analysis_criteria obj = new ERPPlant_analysis_criteria();
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