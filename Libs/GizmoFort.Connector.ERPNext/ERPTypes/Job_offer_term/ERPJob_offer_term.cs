using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Job_offer_term
{
    public class ERPJob_offer_term : ERPNextObjectBase
    {
        public ERPJob_offer_term() : this(new ERPObject(DocType.Job_offer_term)) { }
        public ERPJob_offer_term(ERPObject obj) : base(obj) { }

        public static ERPJob_offer_term Create(string offerterm, string value)

        {
            ERPJob_offer_term obj = new ERPJob_offer_term();
            obj.offer_term = offerterm;
            obj.value = value;
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

        public string value
        {
            get { return data.value; }
            set { data.value = value; }
        }


    }

    //Enums go here

}