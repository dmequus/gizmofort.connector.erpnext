using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Installation_note
{
    public class ERPInstallation_note : ERPNextObjectBase
    {
        public ERPInstallation_note() : this(new ERPObject(DocType.Installation_note)) { }
        public ERPInstallation_note(ERPObject obj) : base(obj) { }

        public static ERPInstallation_note Create(string customername, string namingseries, string customer, string customeraddress, string contactperson, string addressdisplay, string contactdisplay, string contactmobile, string contactemail, string territory, string customergroup, string instdate, string insttime, Status status, string company, string amendedfrom, string remarks, string items)

        {
            ERPInstallation_note obj = new ERPInstallation_note();
            obj.customer_name = customername;
            obj.naming_series = namingseries;
            obj.customer = customer;
            obj.customer_address = customeraddress;
            obj.contact_person = contactperson;
            obj.address_display = addressdisplay;
            obj.contact_display = contactdisplay;
            obj.contact_mobile = contactmobile;
            obj.contact_email = contactemail;
            obj.territory = territory;
            obj.customer_group = customergroup;
            obj.inst_date = instdate;
            obj.inst_time = insttime;
            obj.status = status;
            obj.company = company;
            obj.amended_from = amendedfrom;
            obj.remarks = remarks;
            obj.items = items;
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

        public string inst_date
        {
            get { return data.inst_date; }
            set { data.inst_date = value; }
        }

        public string inst_time
        {
            get { return data.inst_time; }
            set { data.inst_time = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
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

        public string remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        public string items
        {
            get { return data.items; }
            set { data.items = value; }
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