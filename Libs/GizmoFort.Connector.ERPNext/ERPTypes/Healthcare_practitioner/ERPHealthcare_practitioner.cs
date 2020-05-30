using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Healthcare_practitioner
{
    public class ERPHealthcare_practitioner : ERPNextObjectBase
    {
        public ERPHealthcare_practitioner() : this(new ERPObject(DocType.Healthcare_practitioner)) { }
        public ERPHealthcare_practitioner(ERPObject obj) : base(obj) { }

        public static ERPHealthcare_practitioner Create(string practitionername, string firstname, Status status)

        {
            ERPHealthcare_practitioner obj = new ERPHealthcare_practitioner();
            obj.practitioner_name = practitionername;
            obj.first_name = firstname;
            obj.status = status;
            return obj;
        }

        public string practitioner_name
        {
            get { return data.practitioner_name; }
            set
            {
                data.practitioner_name = value;
                data.name = value;
            }

        }

        public string first_name
        {
            get { return data.first_name; }
            set { data.first_name = value; }
        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string middle_name
        {
            get { return data.middle_name; }
            set { data.middle_name = value; }
        }

        public string last_name
        {
            get { return data.last_name; }
            set { data.last_name = value; }
        }

        public string image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string user_id
        {
            get { return data.user_id; }
            set { data.user_id = value; }
        }

        public string designation
        {
            get { return data.designation; }
            set { data.designation = value; }
        }

        public string department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        public string hospital
        {
            get { return data.hospital; }
            set { data.hospital = value; }
        }

        public string mobile_phone
        {
            get { return data.mobile_phone; }
            set { data.mobile_phone = value; }
        }

        public string residence_phone
        {
            get { return data.residence_phone; }
            set { data.residence_phone = value; }
        }

        public string office_phone
        {
            get { return data.office_phone; }
            set { data.office_phone = value; }
        }

        public string practitioner_schedules
        {
            get { return data.practitioner_schedules; }
            set { data.practitioner_schedules = value; }
        }

        public string op_consulting_charge_item
        {
            get { return data.op_consulting_charge_item; }
            set { data.op_consulting_charge_item = value; }
        }

        private double _op_consulting_charge = 0.0;
        public double op_consulting_charge
        {
            get { return data._op_consulting_charge; }
            set { data._op_consulting_charge = value; }
        }

        public string inpatient_visit_charge_item
        {
            get { return data.inpatient_visit_charge_item; }
            set { data.inpatient_visit_charge_item = value; }
        }

        private double _inpatient_visit_charge = 0.0;
        public double inpatient_visit_charge
        {
            get { return data._inpatient_visit_charge; }
            set { data._inpatient_visit_charge = value; }
        }

        public string address_html
        {
            get { return data.address_html; }
            set { data.address_html = value; }
        }

        public string contact_html
        {
            get { return data.contact_html; }
            set { data.contact_html = value; }
        }

        public string accounts
        {
            get { return data.accounts; }
            set { data.accounts = value; }
        }

        public string default_currency
        {
            get { return data.default_currency; }
            set { data.default_currency = value; }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string gender
        {
            get { return data.gender; }
            set { data.gender = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Active")]
        Active,
        [Description("Disabled")]
        Disabled,
    }


}