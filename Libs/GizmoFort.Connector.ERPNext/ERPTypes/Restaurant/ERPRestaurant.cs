using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Restaurant
{
    public class ERPRestaurant : ERPNextObjectBase
    {
        public ERPRestaurant() : this(new ERPObject(DocType.Restaurant)) { }
        public ERPRestaurant(ERPObject obj) : base(obj) { }

        public static ERPRestaurant Create(string image, string company, string defaultcustomer, string invoiceseriesprefix, string activemenu, string defaulttaxtemplate, string address)

        {
            ERPRestaurant obj = new ERPRestaurant();
            obj.image = image;
            obj.company = company;
            obj.default_customer = defaultcustomer;
            obj.invoice_series_prefix = invoiceseriesprefix;
            obj.active_menu = activemenu;
            obj.default_tax_template = defaulttaxtemplate;
            obj.address = address;
            return obj;
        }

        public string image
        {
            get { return data.image; }
            set
            {
                data.image = value;
                data.name = value;
            }

        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string default_customer
        {
            get { return data.default_customer; }
            set { data.default_customer = value; }
        }

        public string invoice_series_prefix
        {
            get { return data.invoice_series_prefix; }
            set { data.invoice_series_prefix = value; }
        }

        public string active_menu
        {
            get { return data.active_menu; }
            set { data.active_menu = value; }
        }

        public string default_tax_template
        {
            get { return data.default_tax_template; }
            set { data.default_tax_template = value; }
        }

        public string address
        {
            get { return data.address; }
            set { data.address = value; }
        }


    }

    //Enums go here

}