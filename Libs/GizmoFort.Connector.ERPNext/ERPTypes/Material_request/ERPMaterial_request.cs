using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Material_request
{
    public class ERPMaterial_request : ERPNextObjectBase
    {
        public ERPMaterial_request() : this(new ERPObject(DocType.Material_request)) { }
        public ERPMaterial_request(ERPObject obj) : base(obj) { }

        public static ERPMaterial_request Create(string title, string namingseries, Materialrequesttype materialrequesttype, string company, string items, string transactiondate)

        {
            ERPMaterial_request obj = new ERPMaterial_request();
            obj.title = title;
            obj.naming_series = namingseries;
            obj.material_request_type = materialrequesttype;
            obj.company = company;
            obj.items = items;
            obj.transaction_date = transactiondate;
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

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public Materialrequesttype material_request_type
        {
            get { return parseEnum<Materialrequesttype>(data.material_request_type); }
            set { data.material_request_type = value.ToString(); }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        public string transaction_date
        {
            get { return data.transaction_date; }
            set { data.transaction_date = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string schedule_date
        {
            get { return data.schedule_date; }
            set { data.schedule_date = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string scan_barcode
        {
            get { return data.scan_barcode; }
            set { data.scan_barcode = value; }
        }

        public string requested_by
        {
            get { return data.requested_by; }
            set { data.requested_by = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        private double _per_ordered = 0.0;
        public double per_ordered
        {
            get { return data._per_ordered; }
            set { data._per_ordered = value; }
        }

        private double _per_received = 0.0;
        public double per_received
        {
            get { return data._per_received; }
            set { data._per_received = value; }
        }

        public string letter_head
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        public string select_print_heading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = value; }
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

        public string job_card
        {
            get { return data.job_card; }
            set { data.job_card = value; }
        }

        public string set_warehouse
        {
            get { return data.set_warehouse; }
            set { data.set_warehouse = value; }
        }

        public string set_from_warehouse
        {
            get { return data.set_from_warehouse; }
            set { data.set_from_warehouse = value; }
        }


    }

    //Enums go here
    public enum Materialrequesttype
    {
        [Description("Purchase")]
        Purchase,
        [Description("Material Transfer")]
        MaterialTransfer,
        [Description("Material Issue")]
        MaterialIssue,
        [Description("Manufacture")]
        Manufacture,
        [Description("Customer Provided")]
        CustomerProvided,
    }

    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Submitted")]
        Submitted,
        [Description("Stopped")]
        Stopped,
        [Description("Cancelled")]
        Cancelled,
        [Description("Pending")]
        Pending,
        [Description("Partially Ordered")]
        PartiallyOrdered,
        [Description("Ordered")]
        Ordered,
        [Description("Issued")]
        Issued,
        [Description("Transferred")]
        Transferred,
        [Description("Received")]
        Received,
    }


}