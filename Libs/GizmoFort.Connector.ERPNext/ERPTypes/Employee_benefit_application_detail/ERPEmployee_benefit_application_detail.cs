using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Employee_benefit_application_detail
{
    public class ERPEmployee_benefit_application_detail : ERPNextObjectBase
    {
        public ERPEmployee_benefit_application_detail() : this(new ERPObject(DocType.Employee_benefit_application_detail)) { }
        public ERPEmployee_benefit_application_detail(ERPObject obj) : base(obj) { }

        public static ERPEmployee_benefit_application_detail Create(string earningcomponent, int payagainstbenefitclaim, double maxbenefitamount, double amount)

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

        private int _pay_against_benefit_claim = 0;
        public int pay_against_benefit_claim
        {
            get { return data._pay_against_benefit_claim; }
            set { data._pay_against_benefit_claim = value; }
        }

        private double _max_benefit_amount = 0.0;
        public double max_benefit_amount
        {
            get { return data._max_benefit_amount; }
            set { data._max_benefit_amount = value; }
        }

        private double _amount = 0.0;
        public double amount
        {
            get { return data._amount; }
            set { data._amount = value; }
        }


    }

    //Enums go here

}