using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_customer_detail
{
    public class ERPItem_customer_detail : ERPNextObjectBase
    {
        public ERPItem_customer_detail() : this(new ERPObject(DocType.Item_customer_detail)) { }
        public ERPItem_customer_detail(ERPObject obj) : base(obj) { }

        public static ERPItem_customer_detail Create(string customername, string customergroup, string refcode)

        {
            ERPItem_customer_detail obj = new ERPItem_customer_detail();
            obj.customer_name = customername;
            obj.customer_group = customergroup;
            obj.ref_code = refcode;
            return obj;
        }

        public string customer_name
        {
            get { return data.customer_name; }
            set
            {
                data.customer_name = value;
                data.name = value;
            }

        }

        public string customer_group
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        public string ref_code
        {
            get { return data.ref_code; }
            set { data.ref_code = value; }
        }


    }

    //Enums go here

}