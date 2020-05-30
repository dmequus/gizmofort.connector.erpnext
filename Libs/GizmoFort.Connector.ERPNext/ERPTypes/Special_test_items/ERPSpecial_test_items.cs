using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Special_test_items
{
    public class ERPSpecial_test_items : ERPNextObjectBase
    {
        public ERPSpecial_test_items() : this(new ERPObject(DocType.Special_test_items)) { }
        public ERPSpecial_test_items(ERPObject obj) : base(obj) { }

        public static ERPSpecial_test_items Create(string labtestparticulars, string resultvalue, long requireresultvalue, string template)

        {
            ERPSpecial_test_items obj = new ERPSpecial_test_items();
            obj.lab_test_particulars = labtestparticulars;
            obj.result_value = resultvalue;
            obj.require_result_value = requireresultvalue;
            obj.template = template;
            return obj;
        }

        public string lab_test_particulars
        {
            get { return data.lab_test_particulars; }
            set
            {
                data.lab_test_particulars = value;
                data.name = value;
            }

        }

        public string result_value
        {
            get { return data.result_value; }
            set { data.result_value = value; }
        }

        public long require_result_value
        {
            get { return data.require_result_value; }
            set { data.require_result_value = value; }
        }

        public string template
        {
            get { return data.template; }
            set { data.template = value; }
        }


    }

    //Enums go here

}