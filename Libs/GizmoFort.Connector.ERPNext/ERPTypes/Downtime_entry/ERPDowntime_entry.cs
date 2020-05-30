using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Downtime_entry
{
    public class ERPDowntime_entry : ERPNextObjectBase
    {
        public ERPDowntime_entry() : this(new ERPObject(DocType.Downtime_entry)) { }
        public ERPDowntime_entry(ERPObject obj) : base(obj) { }

        public static ERPDowntime_entry Create(string workstation, string fromtime, string totime, string keyDELoperator, Stopreason stopreason)

        {
            ERPDowntime_entry obj = new ERPDowntime_entry();
            obj.workstation = workstation;
            obj.from_time = fromtime;
            obj.to_time = totime;
            obj.keyDELoperator = keyDELoperator;
            obj.stop_reason = stopreason;
            return obj;
        }

        public string workstation
        {
            get { return data.workstation; }
            set
            {
                data.workstation = value;
                data.name = value;
            }

        }

        public string from_time
        {
            get { return data.from_time; }
            set { data.from_time = value; }
        }

        public string to_time
        {
            get { return data.to_time; }
            set { data.to_time = value; }
        }

        public string keyDELoperator
        {
            get { return data.keyDELoperator; }
            set { data.keyDELoperator = value; }
        }

        public Stopreason stop_reason
        {
            get { return parseEnum<Stopreason>(data.stop_reason); }
            set { data.stop_reason = value.ToString(); }
        }

        private double _downtime = 0.0;
        public double downtime
        {
            get { return data._downtime; }
            set { data._downtime = value; }
        }

        public string remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }


    }

    //Enums go here
    public enum Stopreason
    {
        [Description("Excessive machine set up time")]
        Excessivemachinesetuptime,
        [Description("Unplanned machine maintenance")]
        Unplannedmachinemaintenance,
        [Description("On-machine press checks")]
        Onmachinepresschecks,
        [Description("Machine operator errors")]
        Machineoperatorerrors,
        [Description("Machine malfunction")]
        Machinemalfunction,
        [Description("Electricity down")]
        Electricitydown,
        [Description("Other")]
        Other,
    }


}