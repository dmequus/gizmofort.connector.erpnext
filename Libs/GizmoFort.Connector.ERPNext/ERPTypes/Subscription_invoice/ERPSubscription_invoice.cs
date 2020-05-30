using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Subscription_invoice
{
    public class ERPSubscription_invoice : ERPNextObjectBase
    {
        public ERPSubscription_invoice() : this(new ERPObject(DocType.Subscription_invoice)) { }
        public ERPSubscription_invoice(ERPObject obj) : base(obj) { }

        public static ERPSubscription_invoice Create(string invoice)

        {
            ERPSubscription_invoice obj = new ERPSubscription_invoice();
            obj.invoice = invoice;
            return obj;
        }

        public string invoice
        {
            get { return data.invoice; }
            set
            {
                data.invoice = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}