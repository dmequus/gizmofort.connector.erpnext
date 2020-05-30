using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_tax_template
{
    public class ERPItem_tax_template : ERPNextObjectBase
    {
        public ERPItem_tax_template() : this(new ERPObject(DocType.Item_tax_template)) { }
        public ERPItem_tax_template(ERPObject obj) : base(obj) { }

        public static ERPItem_tax_template Create(string title, string taxes)

        {
            ERPItem_tax_template obj = new ERPItem_tax_template();
            obj.title = title;
            obj.taxes = taxes;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string taxes
        {
            get { return data.taxes; }
            set { data.taxes = value; }
        }


    }

    //Enums go here

}