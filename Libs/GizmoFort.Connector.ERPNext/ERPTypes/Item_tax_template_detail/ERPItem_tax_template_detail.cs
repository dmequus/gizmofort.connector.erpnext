using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Item_tax_template_detail
{
    public class ERPItem_tax_template_detail : ERPNextObjectBase
    {
        public ERPItem_tax_template_detail() : this(new ERPObject(DocType.Item_tax_template_detail)) { }
        public ERPItem_tax_template_detail(ERPObject obj) : base(obj) { }

        public static ERPItem_tax_template_detail Create(string taxtype, double taxrate)

        {
            ERPItem_tax_template_detail obj = new ERPItem_tax_template_detail();
            obj.tax_type = taxtype;
            obj.tax_rate = taxrate;
            return obj;
        }

        public string tax_type
        {
            get { return data.tax_type; }
            set
            {
                data.tax_type = value;
                data.name = value;
            }

        }

        private double _tax_rate = 0.0;
        public double tax_rate
        {
            get { return data._tax_rate; }
            set { data._tax_rate = value; }
        }


    }

    //Enums go here

}