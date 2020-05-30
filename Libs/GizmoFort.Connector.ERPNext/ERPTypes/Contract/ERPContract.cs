using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Contract
{
    public class ERPContract : ERPNextObjectBase
    {
        public ERPContract() : this(new ERPObject(DocType.Contract)) { }
        public ERPContract(ERPObject obj) : base(obj) { }

        public static ERPContract Create(Partytype partytype, string partyname, string contractterms)

        {
            ERPContract obj = new ERPContract();
            obj.party_type = partytype;
            obj.party_name = partyname;
            obj.contract_terms = contractterms;
            return obj;
        }

        public Partytype party_type
        {
            get { return parseEnum<Partytype>(data.party_type); }
            set { data.party_type = value.ToString(); }
        }

        public string party_name
        {
            get { return data.party_name; }
            set { data.party_name = value; }
        }

        public string contract_terms
        {
            get { return data.contract_terms; }
            set { data.contract_terms = value; }
        }

        public long is_signed
        {
            get { return data.is_signed; }
            set { data.is_signed = value; }
        }

        public string party_user
        {
            get { return data.party_user; }
            set { data.party_user = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public Fulfilmentstatus fulfilment_status
        {
            get { return parseEnum<Fulfilmentstatus>(data.fulfilment_status); }
            set { data.fulfilment_status = value.ToString(); }
        }

        public string start_date
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        public string end_date
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }

        public string signee
        {
            get { return data.signee; }
            set { data.signee = value; }
        }

        public string signed_on
        {
            get { return data.signed_on; }
            set { data.signed_on = value; }
        }

        public string ip_address
        {
            get { return data.ip_address; }
            set { data.ip_address = value; }
        }

        public string contract_template
        {
            get { return data.contract_template; }
            set { data.contract_template = value; }
        }

        public long requires_fulfilment
        {
            get { return data.requires_fulfilment; }
            set { data.requires_fulfilment = value; }
        }

        public string fulfilment_deadline
        {
            get { return data.fulfilment_deadline; }
            set { data.fulfilment_deadline = value; }
        }

        public string fulfilment_terms
        {
            get { return data.fulfilment_terms; }
            set { data.fulfilment_terms = value; }
        }

        public Documenttype document_type
        {
            get { return parseEnum<Documenttype>(data.document_type); }
            set { data.document_type = value.ToString(); }
        }

        public string document_name
        {
            get { return data.document_name; }
            set { data.document_name = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Partytype
    {
        [Description("Customer")]
        Customer,
        [Description("Supplier")]
        Supplier,
        [Description("Employee")]
        Employee,
    }

    public enum Status
    {
        [Description("Unsigned")]
        Unsigned,
        [Description("Active")]
        Active,
        [Description("Inactive")]
        Inactive,
    }

    public enum Fulfilmentstatus
    {
        [Description("N/A")]
        NA,
        [Description("Unfulfilled")]
        Unfulfilled,
        [Description("Partially Fulfilled")]
        PartiallyFulfilled,
        [Description("Fulfilled")]
        Fulfilled,
        [Description("Lapsed")]
        Lapsed,
    }

    public enum Documenttype
    {
        [Description("Quotation")]
        Quotation,
        [Description("Project")]
        Project,
        [Description("Sales Order")]
        SalesOrder,
        [Description("Purchase Order")]
        PurchaseOrder,
        [Description("Sales Invoice")]
        SalesInvoice,
        [Description("Purchase Invoice")]
        PurchaseInvoice,
    }


}