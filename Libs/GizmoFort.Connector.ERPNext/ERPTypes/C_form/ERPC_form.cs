using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.C_form
{
    public class ERPC_form : ERPNextObjectBase
    {
        public ERPC_form() : this(new ERPObject(DocType.C_form)) { }
        public ERPC_form(ERPObject obj) : base(obj) { }

        public static ERPC_form Create(string namingseries, string cformno, string receiveddate, string customer, string company, Quarter quarter, double totalamount, string state, string invoices, double totalinvoicedamount, string amendedfrom)

        {
            ERPC_form obj = new ERPC_form();
            obj.naming_series = namingseries;
            obj.c_form_no = cformno;
            obj.received_date = receiveddate;
            obj.customer = customer;
            obj.company = company;
            obj.quarter = quarter;
            obj.total_amount = totalamount;
            obj.state = state;
            obj.invoices = invoices;
            obj.total_invoiced_amount = totalinvoicedamount;
            obj.amended_from = amendedfrom;
            return obj;
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set
            {
                data.naming_series = value;
                data.name = value;
            }

        }

        public string c_form_no
        {
            get { return data.c_form_no; }
            set { data.c_form_no = value; }
        }

        public string received_date
        {
            get { return data.received_date; }
            set { data.received_date = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public Quarter quarter
        {
            get { return parseEnum<Quarter>(data.quarter); }
            set { data.quarter = value.ToString(); }
        }

        private double _total_amount = 0.0;
        public double total_amount
        {
            get { return data._total_amount; }
            set { data._total_amount = value; }
        }

        public string state
        {
            get { return data.state; }
            set { data.state = value; }
        }

        public string invoices
        {
            get { return data.invoices; }
            set { data.invoices = value; }
        }

        private double _total_invoiced_amount = 0.0;
        public double total_invoiced_amount
        {
            get { return data._total_invoiced_amount; }
            set { data._total_invoiced_amount = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Quarter
    {
        [Description("I")]
        I,
        [Description("II")]
        II,
        [Description("III")]
        III,
        [Description("IV")]
        IV,
    }


}