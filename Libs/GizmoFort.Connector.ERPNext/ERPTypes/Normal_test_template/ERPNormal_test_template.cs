using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Normal_test_template
{
    public class ERPNormal_test_template : ERPNextObjectBase
    {
        public ERPNormal_test_template() : this(new ERPObject(DocType.Normal_test_template)) { }
        public ERPNormal_test_template(ERPObject obj) : base(obj) { }

        public static ERPNormal_test_template Create(string labtestevent, string labtestuom, string normalrange)

        {
            ERPNormal_test_template obj = new ERPNormal_test_template();
            obj.lab_test_event = labtestevent;
            obj.lab_test_uom = labtestuom;
            obj.normal_range = normalrange;
            return obj;
        }

        public string lab_test_event
        {
            get { return data.lab_test_event; }
            set
            {
                data.lab_test_event = value;
                data.name = value;
            }

        }

        public string lab_test_uom
        {
            get { return data.lab_test_uom; }
            set { data.lab_test_uom = value; }
        }

        public string normal_range
        {
            get { return data.normal_range; }
            set { data.normal_range = value; }
        }


    }

    //Enums go here

}