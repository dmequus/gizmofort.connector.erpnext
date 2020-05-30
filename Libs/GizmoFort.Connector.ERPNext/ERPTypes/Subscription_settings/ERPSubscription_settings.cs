using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Subscription_settings
{
    public class ERPSubscription_settings : ERPNextObjectBase
    {
        public ERPSubscription_settings() : this(new ERPObject(DocType.Subscription_settings)) { }
        public ERPSubscription_settings(ERPObject obj) : base(obj) { }

        public static ERPSubscription_settings Create(int graceperiod, int cancelaftergrace, int prorate)

        {
            ERPSubscription_settings obj = new ERPSubscription_settings();
            obj.grace_period = graceperiod;
            obj.cancel_after_grace = cancelaftergrace;
            obj.prorate = prorate;
            return obj;
        }

        private int _grace_period = 0;
        public int grace_period
        {
            get { return data._grace_period; }
            set { data._grace_period = value; }
        }

        private int _cancel_after_grace = 0;
        public int cancel_after_grace
        {
            get { return data._cancel_after_grace; }
            set { data._cancel_after_grace = value; }
        }

        private int _prorate = 0;
        public int prorate
        {
            get { return data._prorate; }
            set { data._prorate = value; }
        }


    }

    //Enums go here

}