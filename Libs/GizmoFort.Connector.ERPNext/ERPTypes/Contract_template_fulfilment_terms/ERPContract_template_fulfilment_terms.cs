using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System.ComponentModel;
namespace GizmoFort.Connector.ERPNext.ERPTypes.Contract_template_fulfilment_terms
{
    public class ERPContract_template_fulfilment_terms : ERPNextObjectBase
    {
        public ERPContract_template_fulfilment_terms() : this(new ERPObject(DocType.Contract_template_fulfilment_terms)) { }
        public ERPContract_template_fulfilment_terms(ERPObject obj) : base(obj) { }

        public static ERPContract_template_fulfilment_terms Create(string requirement)

        {
            ERPContract_template_fulfilment_terms obj = new ERPContract_template_fulfilment_terms();
            obj.requirement = requirement;
            return obj;
        }

        public string requirement
        {
            get { return data.requirement; }
            set
            {
                data.requirement = value;
                data.name = value;
            }

        }


    }

    //Enums go here

}