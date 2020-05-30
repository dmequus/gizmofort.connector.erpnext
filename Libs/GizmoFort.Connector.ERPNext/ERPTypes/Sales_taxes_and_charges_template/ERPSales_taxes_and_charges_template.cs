using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Sales_taxes_and_charges_template
{
    public class ERPSales_taxes_and_charges_template : ERPNextObjectBase
    {
        public ERPSales_taxes_and_charges_template() : this(new ERPObject(DocType.Sales_taxes_and_charges_template)) { }
        public ERPSales_taxes_and_charges_template(ERPObject obj) : base(obj) { }

        public static ERPSales_taxes_and_charges_template Create(string title, string company)

        {
            ERPSales_taxes_and_charges_template obj = new ERPSales_taxes_and_charges_template();
            obj.title = title;
            obj.company = company;
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

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        private int _is_default = 0;
        public int is_default
        {
            get { return data._is_default; }
            set { data._is_default = value; }
        }

        private int _disabled = 0;
        public int disabled
        {
            get { return data._disabled; }
            set { data._disabled = value; }
        }

        public string taxes
        {
            get { return data.taxes; }
            set { data.taxes = value; }
        }

        public string tax_category
        {
            get { return data.tax_category; }
            set { data.tax_category = value; }
        }


    }

    //Enums go here

}