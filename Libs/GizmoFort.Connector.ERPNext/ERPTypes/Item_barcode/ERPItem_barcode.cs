using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_barcode
{
    public class ERPItem_barcode : ERPNextObjectBase
    {
        public ERPItem_barcode() : this(new ERPObject(DocType.Item_barcode)) { }
        public ERPItem_barcode(ERPObject obj) : base(obj) { }

        public static ERPItem_barcode Create(string barcode, Barcodetype barcodetype)

        {
            ERPItem_barcode obj = new ERPItem_barcode();
            obj.barcode = barcode;
            obj.barcode_type = barcodetype;
            return obj;
        }

        public string barcode
        {
            get { return data.barcode; }
            set
            {
                data.barcode = value;
                data.name = value;
            }

        }

        public Barcodetype barcode_type
        {
            get { return parseEnum<Barcodetype>(data.barcode_type); }
            set { data.barcode_type = value.ToString(); }
        }


    }

    //Enums go here
    public enum Barcodetype
    {
        [Description("EAN")]
        EAN,
        [Description("UPC-A")]
        UPCA,
    }


}