using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_manufacturer
{
    public class ERPItem_manufacturer : ERPNextObjectBase
    {
        public ERPItem_manufacturer() : this(new ERPObject(DocType.Item_manufacturer)) { }
        public ERPItem_manufacturer(ERPObject obj) : base(obj) { }

        public static ERPItem_manufacturer Create(string itemcode, string manufacturer, string manufacturerpartno)

        {
            ERPItem_manufacturer obj = new ERPItem_manufacturer();
            obj.item_code = itemcode;
            obj.manufacturer = manufacturer;
            obj.manufacturer_part_no = manufacturerpartno;
            return obj;
        }

        public string item_code
        {
            get { return data.item_code; }
            set
            {
                data.item_code = value;
                data.name = value;
            }

        }

        public string manufacturer
        {
            get { return data.manufacturer; }
            set { data.manufacturer = value; }
        }

        public string manufacturer_part_no
        {
            get { return data.manufacturer_part_no; }
            set { data.manufacturer_part_no = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        private int _is_default = 0;
        public int is_default
        {
            get { return data._is_default; }
            set { data._is_default = value; }
        }


    }

    //Enums go here

}