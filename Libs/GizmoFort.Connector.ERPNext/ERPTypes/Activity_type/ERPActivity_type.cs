using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Activity_type
{
    public class ERPActivity_type : ERPNextObjectBase
    {
        public ERPActivity_type() : this(new ERPObject(DocType.Activity_type)) { }
        public ERPActivity_type(ERPObject obj) : base(obj) { }

        public static ERPActivity_type Create(string activitytype, double costingrate, double billingrate, int disabled)

        {
            ERPActivity_type obj = new ERPActivity_type();
            obj.activity_type = activitytype;
            obj.costing_rate = costingrate;
            obj.billing_rate = billingrate;
            obj.disabled = disabled;
            return obj;
        }

        public string activity_type
        {
            get { return data.activity_type; }
            set
            {
                data.activity_type = value;
                data.name = value;
            }

        }

        private double _costing_rate = 0.0;
        public double costing_rate
        {
            get { return data._costing_rate; }
            set { data._costing_rate = value; }
        }

        private double _billing_rate = 0.0;
        public double billing_rate
        {
            get { return data._billing_rate; }
            set { data._billing_rate = value; }
        }

        private int _disabled = 0;
        public int disabled
        {
            get { return data._disabled; }
            set { data._disabled = value; }
        }


    }

    //Enums go here

}