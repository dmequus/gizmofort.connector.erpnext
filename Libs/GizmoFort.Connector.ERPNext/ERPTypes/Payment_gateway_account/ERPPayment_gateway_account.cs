using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_gateway_account
{
    public class ERPPayment_gateway_account : ERPNextObjectBase
    {
        public ERPPayment_gateway_account() : this(new ERPObject(DocType.Payment_gateway_account)) { }
        public ERPPayment_gateway_account(ERPObject obj) : base(obj) { }

        public static ERPPayment_gateway_account Create(string paymentgateway, long isdefault, string paymentaccount, string currency, string message, string messageexamples)

        {
            ERPPayment_gateway_account obj = new ERPPayment_gateway_account();
            obj.payment_gateway = paymentgateway;
            obj.is_default = isdefault;
            obj.payment_account = paymentaccount;
            obj.currency = currency;
            obj.message = message;
            obj.message_examples = messageexamples;
            return obj;
        }

        public string payment_gateway
        {
            get { return data.payment_gateway; }
            set
            {
                data.payment_gateway = value;
                data.name = value;
            }

        }

        public long is_default
        {
            get { return data.is_default; }
            set { data.is_default = value; }
        }

        public string payment_account
        {
            get { return data.payment_account; }
            set { data.payment_account = value; }
        }

        public string currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        public string message
        {
            get { return data.message; }
            set { data.message = value; }
        }

        public string message_examples
        {
            get { return data.message_examples; }
            set { data.message_examples = value; }
        }


    }

    //Enums go here

}