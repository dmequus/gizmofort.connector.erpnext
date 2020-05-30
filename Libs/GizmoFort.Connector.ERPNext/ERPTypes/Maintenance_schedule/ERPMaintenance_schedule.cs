using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_schedule
{
    public class ERPMaintenance_schedule : ERPNextObjectBase
    {
        public ERPMaintenance_schedule() : this(new ERPObject(DocType.Maintenance_schedule)) { }
        public ERPMaintenance_schedule(ERPObject obj) : base(obj) { }

        public static ERPMaintenance_schedule Create(string namingseries, string customer, Status status, string transactiondate, string items, string schedules, string customername, string contactperson, string contactmobile, string contactemail, string contactdisplay, string customeraddress, string addressdisplay, string territory, string customergroup, string company, string amendedfrom)

        {
            ERPMaintenance_schedule obj = new ERPMaintenance_schedule();
            obj.naming_series = namingseries;
            obj.customer = customer;
            obj.status = status;
            obj.transaction_date = transactiondate;
            obj.items = items;
            obj.schedules = schedules;
            obj.customer_name = customername;
            obj.contact_person = contactperson;
            obj.contact_mobile = contactmobile;
            obj.contact_email = contactemail;
            obj.contact_display = contactdisplay;
            obj.customer_address = customeraddress;
            obj.address_display = addressdisplay;
            obj.territory = territory;
            obj.customer_group = customergroup;
            obj.company = company;
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

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string transaction_date
        {
            get { return data.transaction_date; }
            set { data.transaction_date = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
        }

        public string schedules
        {
            get { return data.schedules; }
            set { data.schedules = value; }
        }

        public string customer_name
        {
            get { return data.customer_name; }
            set { data.customer_name = value; }
        }

        public string contact_person
        {
            get { return data.contact_person; }
            set { data.contact_person = value; }
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

        public string contact_display
        {
            get { return data.contact_display; }
            set { data.contact_display = value; }
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

        public string company
        {
            get { return data.company; }
            set { data.company = value; }
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