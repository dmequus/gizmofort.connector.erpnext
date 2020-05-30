using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Warranty_claim
{
    public class ERPWarranty_claim : ERPNextObjectBase
    {
        public ERPWarranty_claim() : this(new ERPObject(DocType.Warranty_claim)) { }
        public ERPWarranty_claim(ERPObject obj) : base(obj) { }

        public static ERPWarranty_claim Create(string customername, string namingseries, Status status, string complaintdate, string customer, string complaint, string company)

        {
            ERPWarranty_claim obj = new ERPWarranty_claim();
            obj.customer_name = customername;
            obj.naming_series = namingseries;
            obj.status = status;
            obj.complaint_date = complaintdate;
            obj.customer = customer;
            obj.complaint = complaint;
            obj.company = company;
            return obj;
        }

        public string customer_name
        {
            get { return data.customer_name; }
            set
            {
                data.customer_name = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string complaint_date
        {
            get { return data.complaint_date; }
            set { data.complaint_date = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string complaint
        {
            get { return data.complaint; }
            set { data.complaint = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string serial_no
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        public string item_code
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        public string item_name
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public Warrantyamcstatus warranty_amc_status
        {
            get { return parseEnum<Warrantyamcstatus>(data.warranty_amc_status); }
            set { data.warranty_amc_status = value.ToString(); }
        }

        public string warranty_expiry_date
        {
            get { return data.warranty_expiry_date; }
            set { data.warranty_expiry_date = value; }
        }

        public string amc_expiry_date
        {
            get { return data.amc_expiry_date; }
            set { data.amc_expiry_date = value; }
        }

        public string resolution_date
        {
            get { return data.resolution_date; }
            set { data.resolution_date = value; }
        }

        public string resolved_by
        {
            get { return data.resolved_by; }
            set { data.resolved_by = value; }
        }

        public string resolution_details
        {
            get { return data.resolution_details; }
            set { data.resolution_details = value; }
        }

        public string contact_person
        {
            get { return data.contact_person; }
            set { data.contact_person = value; }
        }

        public string contact_display
        {
            get { return data.contact_display; }
            set { data.contact_display = value; }
        }

        public string contact_mobile
        {
            get { return data.contact_mobile; }
            set { data.contact_mobile = value; }
        }

        public string contact_email
        {
            get { return data.contact_email; }
            set { data.contact_email = value; }
        }

        public string territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        public string customer_group
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        public string customer_address
        {
            get { return data.customer_address; }
            set { data.customer_address = value; }
        }

        public string address_display
        {
            get { return data.address_display; }
            set { data.address_display = value; }
        }

        public string service_address
        {
            get { return data.service_address; }
            set { data.service_address = value; }
        }

        public string complaint_raised_by
        {
            get { return data.complaint_raised_by; }
            set { data.complaint_raised_by = value; }
        }

        public string from_company
        {
            get { return data.from_company; }
            set { data.from_company = value; }
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
        [Description("Open")]
        Open,
        [Description("Closed")]
        Closed,
        [Description("Work In Progress")]
        WorkInProgress,
        [Description("Cancelled")]
        Cancelled,
    }

    public enum Warrantyamcstatus
    {
        [Description("Under Warranty")]
        UnderWarranty,
        [Description("Out of Warranty")]
        OutofWarranty,
        [Description("Under AMC")]
        UnderAMC,
        [Description("Out of AMC")]
        OutofAMC,
    }


}