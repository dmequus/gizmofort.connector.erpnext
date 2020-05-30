using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Pos_closing_voucher_details
{
    public class ERPPos_closing_voucher_details : ERPNextObjectBase
    {
        public ERPPos_closing_voucher_details() : this(new ERPObject(DocType.Pos_closing_voucher_details)) { }
        public ERPPos_closing_voucher_details(ERPObject obj) : base(obj) { }

        public static ERPPos_closing_voucher_details Create(string modeofpayment, double collectedamount, double expectedamount, double difference)

        {
            ERPPos_closing_voucher_details obj = new ERPPos_closing_voucher_details();
            obj.mode_of_payment = modeofpayment;
            obj.collected_amount = collectedamount;
            obj.expected_amount = expectedamount;
            obj.difference = difference;
            return obj;
        }

        public string mode_of_payment
        {
            get { return data.mode_of_payment; }
            set
            {
                data.mode_of_payment = value;
                data.name = value;
            }

        }

        private double _collected_amount = 0.0;
        public double collected_amount
        {
            get { return data._collected_amount; }
            set { data._collected_amount = value; }
        }

        private double _expected_amount = 0.0;
        public double expected_amount
        {
            get { return data._expected_amount; }
            set { data._expected_amount = value; }
        }

        private double _difference = 0.0;
        public double difference
        {
            get { return data._difference; }
            set { data._difference = value; }
        }


    }

    //Enums go here

}