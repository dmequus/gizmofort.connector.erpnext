using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Contract_template
{
    public class ERPContract_template : ERPNextObjectBase
    {
        public ERPContract_template() : this(new ERPObject(DocType.Contract_template)) { }
        public ERPContract_template(ERPObject obj) : base(obj) { }

        public static ERPContract_template Create(string title, string contractterms, long requiresfulfilment, string fulfilmentterms)

        {
            ERPContract_template obj = new ERPContract_template();
            obj.title = title;
            obj.contract_terms = contractterms;
            obj.requires_fulfilment = requiresfulfilment;
            obj.fulfilment_terms = fulfilmentterms;
            return obj;
        }

        public string title
        {
            get { return data.title; }
            set
            {
                data.title = value;
                data.name = value;
            }

        }

        public string contract_terms
        {
            get { return data.contract_terms; }
            set { data.contract_terms = value; }
        }

        public long requires_fulfilment
        {
            get { return data.requires_fulfilment; }
            set { data.requires_fulfilment = value; }
        }

        public string fulfilment_terms
        {
            get { return data.fulfilment_terms; }
            set { data.fulfilment_terms = value; }
        }


    }

    //Enums go here

}