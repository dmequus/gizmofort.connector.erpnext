using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_maintenance_task
{
    public class ERPAsset_maintenance_task : ERPNextObjectBase
    {
        public ERPAsset_maintenance_task() : this(new ERPObject(DocType.Asset_maintenance_task)) { }
        public ERPAsset_maintenance_task(ERPObject obj) : base(obj) { }

        public static ERPAsset_maintenance_task Create(string maintenancetask, Maintenancetype maintenancetype, Maintenancestatus maintenancestatus, string startdate, Periodicity periodicity, string enddate, int certificaterequired, string assignto, string assigntoname, string nextduedate, string lastcompletiondate, string description)

        {
            ERPAsset_maintenance_task obj = new ERPAsset_maintenance_task();
            obj.maintenance_task = maintenancetask;
            obj.maintenance_type = maintenancetype;
            obj.maintenance_status = maintenancestatus;
            obj.start_date = startdate;
            obj.periodicity = periodicity;
            obj.end_date = enddate;
            obj.certificate_required = certificaterequired;
            obj.assign_to = assignto;
            obj.assign_to_name = assigntoname;
            obj.next_due_date = nextduedate;
            obj.last_completion_date = lastcompletiondate;
            obj.description = description;
            return obj;
        }

        public string maintenance_task
        {
            get { return data.maintenance_task; }
            set
            {
                data.maintenance_task = value;
                data.name = value;
            }

        }

        public Maintenancetype maintenance_type
        {
            get { return parseEnum<Maintenancetype>(data.maintenance_type); }
            set { data.maintenance_type = value.ToString(); }
        }

        public Maintenancestatus maintenance_status
        {
            get { return parseEnum<Maintenancestatus>(data.maintenance_status); }
            set { data.maintenance_status = value.ToString(); }
        }

        public string start_date
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        public Periodicity periodicity
        {
            get { return parseEnum<Periodicity>(data.periodicity); }
            set { data.periodicity = value.ToString(); }
        }

        public string end_date
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }

        private int _certificate_required = 0;
        public int certificate_required
        {
            get { return data._certificate_required; }
            set { data._certificate_required = value; }
        }

        public string assign_to
        {
            get { return data.assign_to; }
            set { data.assign_to = value; }
        }

        public string assign_to_name
        {
            get { return data.assign_to_name; }
            set { data.assign_to_name = value; }
        }

        public string next_due_date
        {
            get { return data.next_due_date; }
            set { data.next_due_date = value; }
        }

        public string last_completion_date
        {
            get { return data.last_completion_date; }
            set { data.last_completion_date = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }


    }

    //Enums go here
    public enum Maintenancetype
    {
        [Description("Preventive Maintenance")]
        PreventiveMaintenance,
        [Description("Calibration")]
        Calibration,
    }

    public enum Maintenancestatus
    {
        [Description("Planned")]
        Planned,
        [Description("Overdue")]
        Overdue,
        [Description("Cancelled")]
        Cancelled,
    }

    public enum Periodicity
    {
        [Description("Daily")]
        Daily,
        [Description("Weekly")]
        Weekly,
        [Description("Monthly")]
        Monthly,
        [Description("Quarterly")]
        Quarterly,
        [Description("Yearly")]
        Yearly,
        [Description("2 Yearly")]
        TwoYearly,
    }


}