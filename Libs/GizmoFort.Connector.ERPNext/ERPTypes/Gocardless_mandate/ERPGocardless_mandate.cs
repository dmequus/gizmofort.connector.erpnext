using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Gocardless_mandate
{
    public class ERPGocardless_mandate : ERPNextObjectBase
    {
        public ERPGocardless_mandate() : this(new ERPObject(DocType.Gocardless_mandate)) { }
        public ERPGocardless_mandate(ERPObject obj) : base(obj) { }

        public static ERPGocardless_mandate Create(long disabled, string customer, string mandate, string gocardlesscustomer)

        {
            ERPGocardless_mandate obj = new ERPGocardless_mandate();
            obj.disabled = disabled;
            obj.customer = customer;
            obj.mandate = mandate;
            obj.gocardless_customer = gocardlesscustomer;
            return obj;
        }

        public long disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        public string customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        public string mandate
        {
            get { return data.mandate; }
            set { data.mandate = value; }
        }

        public string gocardless_customer
        {
            get { return data.gocardless_customer; }
            set { data.gocardless_customer = value; }
        }


    }

    //Enums go here

}