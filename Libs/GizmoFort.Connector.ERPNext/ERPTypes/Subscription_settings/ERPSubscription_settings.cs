using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Subscription_settings
{
    public class ERPSubscription_settings : ERPNextObjectBase
    {
        public ERPSubscription_settings() : this(new ERPObject(DocType.Subscription_settings)) { }
        public ERPSubscription_settings(ERPObject obj) : base(obj) { }

        public static ERPSubscription_settings Create(int graceperiod, long cancelaftergrace, long prorate)

        {
            ERPSubscription_settings obj = new ERPSubscription_settings();
            obj.grace_period = graceperiod;
            obj.cancel_after_grace = cancelaftergrace;
            obj.prorate = prorate;
            return obj;
        }

        public int grace_period
        {
            get { return data.grace_period; }
            set { data.grace_period = value; }
        }

        public long cancel_after_grace
        {
            get { return data.cancel_after_grace; }
            set { data.cancel_after_grace = value; }
        }

        public long prorate
        {
            get { return data.prorate; }
            set { data.prorate = value; }
        }


    }

    //Enums go here

}