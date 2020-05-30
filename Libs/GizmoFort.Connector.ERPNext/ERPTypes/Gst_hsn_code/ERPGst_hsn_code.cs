using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Gst_hsn_code
{
    public class ERPGst_hsn_code : ERPNextObjectBase
    {
        public ERPGst_hsn_code() : this(new ERPObject(DocType.Gst_hsn_code)) { }
        public ERPGst_hsn_code(ERPObject obj) : base(obj) { }

        public static ERPGst_hsn_code Create(string hsncode)

        {
            ERPGst_hsn_code obj = new ERPGst_hsn_code();
            obj.hsn_code = hsncode;
            return obj;
        }

        public string hsn_code
        {
            get { return data.hsn_code; }
            set
            {
                data.hsn_code = value;
                data.name = value;
            }

        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string taxes
        {
            get { return data.taxes; }
            set { data.taxes = value; }
        }


    }

    //Enums go here

}