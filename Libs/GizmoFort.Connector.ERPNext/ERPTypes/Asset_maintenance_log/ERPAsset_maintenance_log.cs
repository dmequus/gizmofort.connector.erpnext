using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_maintenance_log
{
    public class ERPAsset_maintenance_log : ERPNextObjectBase
    {
        public ERPAsset_maintenance_log() : this(new ERPObject(DocType.Asset_maintenance_log)) { }
        public ERPAsset_maintenance_log(ERPObject obj) : base(obj) { }

        public static ERPAsset_maintenance_log Create(string assetmaintenance, string namingseries, string assetname, string itemcode, string itemname, string task, string maintenancetype, string periodicity, string assigntoname, string duedate, string completiondate, Maintenancestatus maintenancestatus, int hascertificate, string certificateattachement, string description, string actionsperformed, string amendedfrom)

        {
            ERPAsset_maintenance_log obj = new ERPAsset_maintenance_log();
            obj.asset_maintenance = assetmaintenance;
            obj.naming_series = namingseries;
            obj.asset_name = assetname;
            obj.item_code = itemcode;
            obj.item_name = itemname;
            obj.task = task;
            obj.maintenance_type = maintenancetype;
            obj.periodicity = periodicity;
            obj.assign_to_name = assigntoname;
            obj.due_date = duedate;
            obj.completion_date = completiondate;
            obj.maintenance_status = maintenancestatus;
            obj.has_certificate = hascertificate;
            obj.certificate_attachement = certificateattachement;
            obj.description = description;
            obj.actions_performed = actionsperformed;
            obj.amended_from = amendedfrom;
            return obj;
        }

        public string asset_maintenance
        {
            get { return data.asset_maintenance; }
            set
            {
                data.asset_maintenance = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        public string asset_name
        {
            get { return data.asset_name; }
            set { data.asset_name = value; }
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

        public string task
        {
            get { return data.task; }
            set { data.task = value; }
        }

        public string maintenance_type
        {
            get { return data.maintenance_type; }
            set { data.maintenance_type = value; }
        }

        public string periodicity
        {
            get { return data.periodicity; }
            set { data.periodicity = value; }
        }

        public string assign_to_name
        {
            get { return data.assign_to_name; }
            set { data.assign_to_name = value; }
        }

        public string due_date
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        public string completion_date
        {
            get { return data.completion_date; }
            set { data.completion_date = value; }
        }

        public Maintenancestatus maintenance_status
        {
            get { return parseEnum<Maintenancestatus>(data.maintenance_status); }
            set { data.maintenance_status = value.ToString(); }
        }

        private int _has_certificate = 0;
        public int has_certificate
        {
            get { return data._has_certificate; }
            set { data._has_certificate = value; }
        }

        public string certificate_attachement
        {
            get { return data.certificate_attachement; }
            set { data.certificate_attachement = value; }
        }

        public string description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        public string actions_performed
        {
            get { return data.actions_performed; }
            set { data.actions_performed = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Maintenancestatus
    {
        [Description("Planned")]
        Planned,
        [Description("Completed")]
        Completed,
        [Description("Cancelled")]
        Cancelled,
        [Description("Overdue")]
        Overdue,
    }


}