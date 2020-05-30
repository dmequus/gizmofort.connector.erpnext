using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Activity_type
{
    public class ERPActivity_type : ERPNextObjectBase
    {
        public ERPActivity_type() : this(new ERPObject(DocType.Activity_type)) { }
        public ERPActivity_type(ERPObject obj) : base(obj) { }

        public static ERPActivity_type Create(string activitytype, double costingrate, double billingrate, long disabled)

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

        public double costing_rate
        {
            get { return data.costing_rate; }
            set { data.costing_rate = value; }
        }

        public double billing_rate
        {
            get { return data.billing_rate; }
            set { data.billing_rate = value; }
        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }


    }

    //Enums go here

}