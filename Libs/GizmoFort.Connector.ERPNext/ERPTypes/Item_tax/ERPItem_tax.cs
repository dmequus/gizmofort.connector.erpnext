using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_tax
{
    public class ERPItem_tax : ERPNextObjectBase
    {
        public ERPItem_tax() : this(new ERPObject(DocType.Item_tax)) { }
        public ERPItem_tax(ERPObject obj) : base(obj) { }

        public static ERPItem_tax Create(string itemtaxtemplate)

        {
            ERPItem_tax obj = new ERPItem_tax();
            obj.item_tax_template = itemtaxtemplate;
            return obj;
        }

        public string item_tax_template
        {
            get { return data.item_tax_template; }
            set
            {
                data.item_tax_template = value;
                data.name = value;
            }

        }

        public string tax_category
        {
            get { return data.tax_category; }
            set { data.tax_category = value; }
        }

        public string valid_from
        {
            get { return data.valid_from; }
            set { data.valid_from = value; }
        }


    }

    //Enums go here

}