using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Membership_type
{
    public class ERPMembership_type : ERPNextObjectBase
    {
        public ERPMembership_type() : this(new ERPObject(DocType.Membership_type)) { }
        public ERPMembership_type(ERPObject obj) : base(obj) { }

        public static ERPMembership_type Create(string membershiptype, double amount)

        {
            ERPMembership_type obj = new ERPMembership_type();
            obj.membership_type = membershiptype;
            obj.amount = amount;
            return obj;
        }

        public string membership_type
        {
            get { return data.membership_type; }
            set
            {
                data.membership_type = value;
                data.name = value;
            }

        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }

        public string razorpay_plan_id
        {
            get { return data.razorpay_plan_id; }
            set { data.razorpay_plan_id = value; }
        }


    }

    //Enums go here

}