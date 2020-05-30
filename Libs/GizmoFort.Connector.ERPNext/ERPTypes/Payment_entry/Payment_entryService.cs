using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_entry
{
    public class Payment_entryService : SubServiceBase<ERPPayment_entry>
    {
        public Payment_entryService(ERPNextClient client)
            : base(DocType.Payment_entry, client) { }

        protected override ERPPayment_entry fromERPObject(ERPObject obj)
        {
            return new ERPPayment_entry(obj);
        }
    }
}