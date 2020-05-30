using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_terms_template_detail
{
    public class Payment_terms_template_detailService : SubServiceBase<ERPPayment_terms_template_detail>
    {
        public Payment_terms_template_detailService(ERPNextClient client)
            : base(DocType.Payment_terms_template_detail, client) { }

        protected override ERPPayment_terms_template_detail fromERPObject(ERPObject obj)
        {
            return new ERPPayment_terms_template_detail(obj);
        }
    }
}