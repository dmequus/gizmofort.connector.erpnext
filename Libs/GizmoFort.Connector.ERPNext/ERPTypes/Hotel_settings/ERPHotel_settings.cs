using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Hotel_settings
{
    public class ERPHotel_settings : ERPNextObjectBase
    {
        public ERPHotel_settings() : this(new ERPObject(DocType.Hotel_settings)) { }
        public ERPHotel_settings(ERPObject obj) : base(obj) { }

        public static ERPHotel_settings Create(string defaultcustomer, string defaulttaxesandcharges, string defaultinvoicenamingseries)

        {
            ERPHotel_settings obj = new ERPHotel_settings();
            obj.default_customer = defaultcustomer;
            obj.default_taxes_and_charges = defaulttaxesandcharges;
            obj.default_invoice_naming_series = defaultinvoicenamingseries;
            return obj;
        }

        public string default_customer
        {
            get { return data.default_customer; }
            set
            {
                data.default_customer = value;
                data.name = value;
            }

        }

        public string default_taxes_and_charges
        {
            get { return data.default_taxes_and_charges; }
            set { data.default_taxes_and_charges = value; }
        }

        public string default_invoice_naming_series
        {
            get { return data.default_invoice_naming_series; }
            set { data.default_invoice_naming_series = value; }
        }


    }

    //Enums go here

}