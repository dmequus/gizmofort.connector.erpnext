using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_visit
{
    public class ERPMaintenance_visit : ERPNextObjectBase
    {
        public ERPMaintenance_visit() : this(new ERPObject(DocType.Maintenance_visit)) { }
        public ERPMaintenance_visit(ERPObject obj) : base(obj) { }

        public static ERPMaintenance_visit Create(string customername, string namingseries, string customer, string addressdisplay, string contactdisplay, string contactmobile, string contactemail, string mntcdate, string mntctime, Completionstatus completionstatus, Maintenancetype maintenancetype, string purposes, string customerfeedback, Status status, string amendedfrom, string company, string customeraddress, string contactperson, string territory, string customergroup)

        {
            ERPMaintenance_visit obj = new ERPMaintenance_visit();
            obj.customer_name = customername;
            obj.naming_series = namingseries;
            obj.customer = customer;
            obj.address_display = addressdisplay;
            obj.contact_display = contactdisplay;
            obj.contact_mobile = contactmobile;
            obj.contact_email = contactemail;
            obj.mntc_date = mntcdate;
            obj.mntc_time = mntctime;
            obj.completion_status = completionstatus;
            obj.maintenance_type = maintenancetype;
            obj.purposes = purposes;
            obj.customer_feedback = customerfeedback;
            obj.status = status;
            obj.amended_from = amendedfrom;
            obj.company = company;
            obj.customer_address = customeraddress;
            obj.contact_person = contactperson;
            obj.territory = territory;
            obj.customer_group = customergroup;
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

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string address_display
        {
            get { return data.address_display; }
            set { data.address_display = value; }
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

        public string mntc_date
        {
            get { return data.mntc_date; }
            set { data.mntc_date = value; }
        }

        public string mntc_time
        {
            get { return data.mntc_time; }
            set { data.mntc_time = value; }
        }

        public Completionstatus completion_status
        {
            get { return parseEnum<Completionstatus>(data.completion_status); }
            set { data.completion_status = value.ToString(); }
        }

        public Maintenancetype maintenance_type
        {
            get { return parseEnum<Maintenancetype>(data.maintenance_type); }
            set { data.maintenance_type = value.ToString(); }
        }

        public string purposes
        {
            get { return data.purposes; }
            set { data.purposes = value; }
        }

        public string customer_feedback
        {
            get { return data.customer_feedback; }
            set { data.customer_feedback = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        public string customer_address
        {
            get { return data.customer_address; }
            set { data.customer_address = value; }
        }

        public string contact_person
        {
            get { return data.contact_person; }
            set { data.contact_person = value; }
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


    }

    //Enums go here
    public enum Completionstatus
    {
        [Description("Partially Completed")]
        PartiallyCompleted,
        [Description("Fully Completed")]
        FullyCompleted,
    }

    public enum Maintenancetype
    {
        [Description("Scheduled")]
        Scheduled,
        [Description("Unscheduled")]
        Unscheduled,
        [Description("Breakdown")]
        Breakdown,
    }

    public enum Status
    {
        [Description("Draft")]
        Draft,
        [Description("Cancelled")]
        Cancelled,
        [Description("Submitted")]
        Submitted,
    }


}