using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_terms_template
{
    public class Payment_terms_templateService : SubServiceBase<ERPPayment_terms_template>
    {
        public Payment_terms_templateService(ERPNextClient client)
            : base(DocType.Payment_terms_template, client) { }

        protected override ERPPayment_terms_template fromERPObject(ERPObject obj)
        {
            return new ERPPayment_terms_template(obj);
        }
    }
}