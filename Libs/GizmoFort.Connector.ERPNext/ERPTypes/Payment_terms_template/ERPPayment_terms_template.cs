using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_terms_template
{
    public class ERPPayment_terms_template : ERPNextObjectBase
    {
        public ERPPayment_terms_template() : this(new ERPObject(DocType.Payment_terms_template)) { }
        public ERPPayment_terms_template(ERPObject obj) : base(obj) { }

        public static ERPPayment_terms_template Create(string terms)

        {
            ERPPayment_terms_template obj = new ERPPayment_terms_template();
            obj.terms = terms;
            return obj;
        }

        public string terms
        {
            get { return data.terms; }
            set
            {
                data.terms = value;
                data.name = value;
            }

        }

        public string template_name
        {
            get { return data.template_name; }
            set { data.template_name = value; }
        }

        public long allocate_payment_based_on_payment_terms
        {
            get { return data.allocate_payment_based_on_payment_terms; }
            set { data.allocate_payment_based_on_payment_terms = value; }
        }


    }

    //Enums go here

}