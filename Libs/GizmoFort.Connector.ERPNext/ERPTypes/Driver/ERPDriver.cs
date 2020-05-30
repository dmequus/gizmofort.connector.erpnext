using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Driver
{
    public class ERPDriver : ERPNextObjectBase
    {
        public ERPDriver() : this(new ERPObject(DocType.Driver)) { }
        public ERPDriver(ERPObject obj) : base(obj) { }

        public static ERPDriver Create(string fullname, Status status)

        {
            ERPDriver obj = new ERPDriver();
            obj.full_name = fullname;
            obj.status = status;
            return obj;
        }

        public string full_name
        {
            get { return data.full_name; }
            set
            {
                data.full_name = value;
                data.name = value;
            }

        }

        public Status status
        {
            get { return parseEnum<Status>(data.status); }
            set { data.status = value.ToString(); }
        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string transporter
        {
            get { return data.transporter; }
            set { data.transporter = value; }
        }

        public string employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        public string cell_number
        {
            get { return data.cell_number; }
            set { data.cell_number = value; }
        }

        public string license_number
        {
            get { return data.license_number; }
            set { data.license_number = value; }
        }

        public string issuing_date
        {
            get { return data.issuing_date; }
            set { data.issuing_date = value; }
        }

        public string expiry_date
        {
            get { return data.expiry_date; }
            set { data.expiry_date = value; }
        }

        public string driving_license_category
        {
            get { return data.driving_license_category; }
            set { data.driving_license_category = value; }
        }

        public string address
        {
            get { return data.address; }
            set { data.address = value; }
        }


    }

    //Enums go here
    public enum Status
    {
        [Description("Active")]
        Active,
        [Description("Suspended")]
        Suspended,
        [Description("Left")]
        Left,
    }


}