using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Payment_entry_deduction
{
    public class Payment_entry_deductionService : SubServiceBase<ERPPayment_entry_deduction>
    {
        public Payment_entry_deductionService(ERPNextClient client)
            : base(DocType.Payment_entry_deduction, client) { }

        protected override ERPPayment_entry_deduction fromERPObject(ERPObject obj)
        {
            return new ERPPayment_entry_deduction(obj);
        }
    }
}