using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Job_card_time_log
{
    public class ERPJob_card_time_log : ERPNextObjectBase
    {
        public ERPJob_card_time_log() : this(new ERPObject(DocType.Job_card_time_log)) { }
        public ERPJob_card_time_log(ERPObject obj) : base(obj) { }

        public static ERPJob_card_time_log Create(double completedqty)

        {
            ERPJob_card_time_log obj = new ERPJob_card_time_log();
            obj.completed_qty = completedqty;
            return obj;
        }

        private double _completed_qty = 0.0;
        public double completed_qty
        {
            get { return data._completed_qty; }
            set { data._completed_qty = value; }
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

        private double _time_in_mins = 0.0;
        public double time_in_mins
        {
            get { return data._time_in_mins; }
            set { data._time_in_mins = value; }
        }


    }

    //Enums go here

}