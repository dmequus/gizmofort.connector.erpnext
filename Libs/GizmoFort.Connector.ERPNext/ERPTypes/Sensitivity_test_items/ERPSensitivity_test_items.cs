using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sensitivity_test_items
{
    public class ERPSensitivity_test_items : ERPNextObjectBase
    {
        public ERPSensitivity_test_items() : this(new ERPObject(DocType.Sensitivity_test_items)) { }
        public ERPSensitivity_test_items(ERPObject obj) : base(obj) { }

        public static ERPSensitivity_test_items Create(string antibiotic, string antibioticsensitivity)

        {
            ERPSensitivity_test_items obj = new ERPSensitivity_test_items();
            obj.antibiotic = antibiotic;
            obj.antibiotic_sensitivity = antibioticsensitivity;
            return obj;
        }

        public string antibiotic
        {
            get { return data.antibiotic; }
            set
            {
                data.antibiotic = value;
                data.name = value;
            }

        }

        public string antibiotic_sensitivity
        {
            get { return data.antibiotic_sensitivity; }
            set { data.antibiotic_sensitivity = value; }
        }


    }

    //Enums go here

}