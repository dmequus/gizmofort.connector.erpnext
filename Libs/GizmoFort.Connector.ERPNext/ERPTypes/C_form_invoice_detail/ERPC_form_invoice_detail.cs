using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.C_form_invoice_detail
{
    public class ERPC_form_invoice_detail : ERPNextObjectBase
    {
        public ERPC_form_invoice_detail() : this(new ERPObject(DocType.C_form_invoice_detail)) { }
        public ERPC_form_invoice_detail(ERPObject obj) : base(obj) { }

        public static ERPC_form_invoice_detail Create(string invoiceno, string invoicedate, string territory, double nettotal, double grandtotal)

        {
            ERPC_form_invoice_detail obj = new ERPC_form_invoice_detail();
            obj.invoice_no = invoiceno;
            obj.invoice_date = invoicedate;
            obj.territory = territory;
            obj.net_total = nettotal;
            obj.grand_total = grandtotal;
            return obj;
        }

        public string invoice_no
        {
            get { return data.invoice_no; }
            set
            {
                data.invoice_no = value;
                data.name = value;
            }

        }

        public string invoice_date
        {
            get { return data.invoice_date; }
            set { data.invoice_date = value; }
        }

        public string territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        private double _net_total = 0.0;
        public double net_total
        {
            get { return data._net_total; }
            set { data._net_total = value; }
        }

        private double _grand_total = 0.0;
        public double grand_total
        {
            get { return data._grand_total; }
            set { data._grand_total = value; }
        }


    }

    //Enums go here

}