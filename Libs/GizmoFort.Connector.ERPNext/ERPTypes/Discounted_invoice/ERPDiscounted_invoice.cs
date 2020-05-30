using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Discounted_invoice
{
    public class ERPDiscounted_invoice : ERPNextObjectBase
    {
        public ERPDiscounted_invoice() : this(new ERPObject(DocType.Discounted_invoice)) { }
        public ERPDiscounted_invoice(ERPObject obj) : base(obj) { }

        public static ERPDiscounted_invoice Create(string salesinvoice)

        {
            ERPDiscounted_invoice obj = new ERPDiscounted_invoice();
            obj.sales_invoice = salesinvoice;
            return obj;
        }

        public string sales_invoice
        {
            get { return data.sales_invoice; }
            set
            {
                data.sales_invoice = value;
                data.name = value;
            }

        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string posting_date
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        private double _outstanding_amount = 0.0;
        public double outstanding_amount
        {
            get { return data._outstanding_amount; }
            set { data._outstanding_amount = value; }
        }

        public string debit_to
        {
            get { return data.debit_to; }
            set { data.debit_to = value; }
        }


    }

    //Enums go here

}