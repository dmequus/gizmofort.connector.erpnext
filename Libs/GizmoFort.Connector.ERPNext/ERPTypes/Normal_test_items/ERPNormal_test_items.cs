using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Normal_test_items
{
    public class ERPNormal_test_items : ERPNextObjectBase
    {
        public ERPNormal_test_items() : this(new ERPObject(DocType.Normal_test_items)) { }
        public ERPNormal_test_items(ERPObject obj) : base(obj) { }

        public static ERPNormal_test_items Create(string labtestname, string labtestevent, string resultvalue, string labtestuom, string normalrange, string labtestcomment, int requireresultvalue, string template)

        {
            ERPNormal_test_items obj = new ERPNormal_test_items();
            obj.lab_test_name = labtestname;
            obj.lab_test_event = labtestevent;
            obj.result_value = resultvalue;
            obj.lab_test_uom = labtestuom;
            obj.normal_range = normalrange;
            obj.lab_test_comment = labtestcomment;
            obj.require_result_value = requireresultvalue;
            obj.template = template;
            return obj;
        }

        public string lab_test_name
        {
            get { return data.lab_test_name; }
            set
            {
                data.lab_test_name = value;
                data.name = value;
            }

        }

        public string lab_test_event
        {
            get { return data.lab_test_event; }
            set { data.lab_test_event = value; }
        }

        public string result_value
        {
            get { return data.result_value; }
            set { data.result_value = value; }
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

        public string lab_test_comment
        {
            get { return data.lab_test_comment; }
            set { data.lab_test_comment = value; }
        }

        private int _require_result_value = 0;
        public int require_result_value
        {
            get { return data._require_result_value; }
            set { data._require_result_value = value; }
        }

        public string template
        {
            get { return data.template; }
            set { data.template = value; }
        }


    }

    //Enums go here

}