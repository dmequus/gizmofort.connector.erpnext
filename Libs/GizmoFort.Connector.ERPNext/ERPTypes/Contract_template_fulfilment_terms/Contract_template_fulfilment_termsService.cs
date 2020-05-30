using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Contract_template_fulfilment_terms
{
    public class Contract_template_fulfilment_termsService : SubServiceBase<ERPContract_template_fulfilment_terms>
    {
        public Contract_template_fulfilment_termsService(ERPNextClient client)
            : base(DocType.Contract_template_fulfilment_terms, client) { }

        protected override ERPContract_template_fulfilment_terms fromERPObject(ERPObject obj)
        {
            return new ERPContract_template_fulfilment_terms(obj);
        }
    }
}