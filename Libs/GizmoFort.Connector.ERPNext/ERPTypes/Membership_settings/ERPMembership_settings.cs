using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Membership_settings
{
    public class ERPMembership_settings : ERPNextObjectBase
    {
        public ERPMembership_settings() : this(new ERPObject(DocType.Membership_settings)) { }
        public ERPMembership_settings(ERPObject obj) : base(obj) { }

        public static ERPMembership_settings Create()

        {
            ERPMembership_settings obj = new ERPMembership_settings();
            return obj;
        }

        public Billingcycle billing_cycle
        {
            get { return parseEnum<Billingcycle>(data.billing_cycle); }
            set { data.billing_cycle = value.ToString(); }
        }

        public long enable_razorpay
        {
            get { return data.enable_razorpay; }
            set { data.enable_razorpay = value; }
        }

        public int billing_frequency
        {
            get { return data.billing_frequency; }
            set { data.billing_frequency = value; }
        }


    }

    //Enums go here
    public enum Billingcycle
    {
        [Description("Monthly")]
        Monthly,
        [Description("Yearly")]
        Yearly,
    }


}