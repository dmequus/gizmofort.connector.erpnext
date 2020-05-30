using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_entry_reference
{
    public class Payment_entry_referenceService : SubServiceBase<ERPPayment_entry_reference>
    {
        public Payment_entry_referenceService(ERPNextClient client)
            : base(DocType.Payment_entry_reference, client) { }

        protected override ERPPayment_entry_reference fromERPObject(ERPObject obj)
        {
            return new ERPPayment_entry_reference(obj);
        }
    }
}