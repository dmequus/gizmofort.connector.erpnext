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

        public double collected_amount
        {
            get { return data.collected_amount; }
            set { data.collected_amount = value; }
        }

        public double expected_amount
        {
            get { return data.expected_amount; }
            set { data.expected_amount = value; }
        }

        public double difference
        {
            get { return data.difference; }
            set { data.difference = value; }
        }


    }

    //Enums go here

}