using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Asset_repair
{
    public class ERPAsset_repair : ERPNextObjectBase
    {
        public ERPAsset_repair() : this(new ERPObject(DocType.Asset_repair)) { }
        public ERPAsset_repair(ERPObject obj) : base(obj) { }

        public static ERPAsset_repair Create(string assetname, string namingseries, string itemcode, string itemname, string failuredate, string assignto, string assigntoname, string completiondate, Repairstatus repairstatus, string description, string actionsperformed, string downtime, double repaircost, string amendedfrom)

        {
            ERPAsset_repair obj = new ERPAsset_repair();
            obj.asset_name = assetname;
            obj.naming_series = namingseries;
            obj.item_code = itemcode;
            obj.item_name = itemname;
            obj.failure_date = failuredate;
            obj.assign_to = assignto;
            obj.assign_to_name = assigntoname;
            obj.completion_date = completiondate;
            obj.repair_status = repairstatus;
            obj.description = description;
            obj.actions_performed = actionsperformed;
            obj.downtime = downtime;
            obj.repair_cost = repaircost;
            obj.amended_from = amendedfrom;
            return obj;
        }

        public string asset_name
        {
            get { return data.asset_name; }
            set
            {
                data.asset_name = value;
                data.name = value;
            }

        }

        public string naming_series
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
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

        public string failure_date
        {
            get { return data.failure_date; }
            set { data.failure_date = value; }
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

        public string completion_date
        {
            get { return data.completion_date; }
            set { data.completion_date = value; }
        }

        public Repairstatus repair_status
        {
            get { return parseEnum<Repairstatus>(data.repair_status); }
            set { data.repair_status = value.ToString(); }
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

        public string downtime
        {
            get { return data.downtime; }
            set { data.downtime = value; }
        }

        private double _repair_cost = 0.0;
        public double repair_cost
        {
            get { return data._repair_cost; }
            set { data._repair_cost = value; }
        }

        public string amended_from
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }


    }

    //Enums go here
    public enum Repairstatus
    {
        [Description("Pending")]
        Pending,
        [Description("Completed")]
        Completed,
        [Description("Cancelled")]
        Cancelled,
    }


}