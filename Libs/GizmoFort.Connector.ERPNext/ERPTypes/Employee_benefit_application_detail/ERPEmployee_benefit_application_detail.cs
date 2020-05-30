using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_benefit_application_detail
{
    public class ERPEmployee_benefit_application_detail : ERPNextObjectBase
    {
        public ERPEmployee_benefit_application_detail() : this(new ERPObject(DocType.Employee_benefit_application_detail)) { }
        public ERPEmployee_benefit_application_detail(ERPObject obj) : base(obj) { }

        public static ERPEmployee_benefit_application_detail Create(string earningcomponent, long payagainstbenefitclaim, double maxbenefitamount, double amount)

        {
            ERPEmployee_benefit_application_detail obj = new ERPEmployee_benefit_application_detail();
            obj.earning_component = earningcomponent;
            obj.pay_against_benefit_claim = payagainstbenefitclaim;
            obj.max_benefit_amount = maxbenefitamount;
            obj.amount = amount;
            return obj;
        }

        public string earning_component
        {
            get { return data.earning_component; }
            set
            {
                data.earning_component = value;
                data.name = value;
            }

        }

        public long pay_against_benefit_claim
        {
            get { return data.pay_against_benefit_claim; }
            set { data.pay_against_benefit_claim = value; }
        }

        public double max_benefit_amount
        {
            get { return data.max_benefit_amount; }
            set { data.max_benefit_amount = value; }
        }

        public double amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }


    }

    //Enums go here

}