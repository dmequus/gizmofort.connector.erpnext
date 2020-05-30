using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Offer_term
{
    public class ERPOffer_term : ERPNextObjectBase
    {
        public ERPOffer_term() : this(new ERPObject(DocType.Offer_term)) { }
        public ERPOffer_term(ERPObject obj) : base(obj) { }

        public static ERPOffer_term Create(string offerterm)

        {
            ERPOffer_term obj = new ERPOffer_term();
            obj.offer_term = offerterm;
            return obj;
        }

        public string offer_term
        {
            get { return data.offer_term; }
            set
            {
                data.offer_term = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}