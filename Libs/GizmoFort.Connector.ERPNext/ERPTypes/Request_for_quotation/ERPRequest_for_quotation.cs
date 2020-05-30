using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Request_for_quotation
{
    public class ERPRequest_for_quotation : ERPNextObjectBase
    {
        public ERPRequest_for_quotation() : this(new ERPObject(DocType.Request_for_quotation)) { }
        public ERPRequest_for_quotation(ERPObject obj) : base(obj) { }

        public static ERPRequest_for_quotation Create(string namingseries, string company, string transactiondate, string suppliers, string items, string messageforsupplier, Status status, string fiscalyear)

        {
            ERPRequest_for_quotation obj = new ERPRequest_for_quotation();
            obj.naming_series = namingseries;
            obj.company = company;
            obj.transaction_date = transactiondate;
            obj.suppliers = suppliers;
            obj.items = items;
            obj.message_for_supplier = messageforsupplier;
            obj.status = status;
            obj.fiscal_year = fiscalyear;
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

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string transaction_date
        {
            get { return data.transaction_date; }
            set { data.transaction_date = value; }
        }

        public string suppliers
        {
            get { return data.suppliers; }
            set { data.suppliers = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        public string message_for_supplier
        {
            get { return data.message_for_supplier; }
            set { data.message_for_supplier = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string fiscal_year
        {
            get { return data.fiscal_year; }
            set { data.fiscal_year = value; }
        }

        public string vendor
        {
            get { return data.vendor; }
            set { data.vendor = value; }
        }

        public string email_template
        {
            get { return data.email_template; }
            set { data.email_template = value; }
        }

        public string tc_name
        {
            get { return data.tc_name; }
            set { data.tc_name = value; }
        }

        public string terms
        {
            get { return data.terms; }
            set { data.terms = value; }
        }

        public string select_print_heading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = value; }
        }

        public string letter_head
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Submitted")]
        Submitted,
        [Description("Cancelled")]
        Cancelled,
    }


}