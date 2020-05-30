using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_alternative
{
    public class ERPItem_alternative : ERPNextObjectBase
    {
        public ERPItem_alternative() : this(new ERPObject(DocType.Item_alternative)) { }
        public ERPItem_alternative(ERPObject obj) : base(obj) { }

        public static ERPItem_alternative Create(string itemcode, string alternativeitemcode, long twoway, string itemname, string alternativeitemname)

        {
            ERPItem_alternative obj = new ERPItem_alternative();
            obj.item_code = itemcode;
            obj.alternative_item_code = alternativeitemcode;
            obj.two_way = twoway;
            obj.item_name = itemname;
            obj.alternative_item_name = alternativeitemname;
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

        public string alternative_item_code
        {
            get { return data.alternative_item_code; }
            set { data.alternative_item_code = value; }
        }

        public long two_way
        {
            get { return data.two_way; }
            set { data.two_way = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string alternative_item_name
        {
            get { return data.alternative_item_name; }
            set { data.alternative_item_name = value; }
        }


    }

    //Enums go here

}