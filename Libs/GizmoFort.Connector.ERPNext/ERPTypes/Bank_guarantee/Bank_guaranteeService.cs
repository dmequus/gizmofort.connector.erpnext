using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank_guarantee
{
    public class Bank_guaranteeService : SubServiceBase<ERPBank_guarantee>
    {
        public Bank_guaranteeService(ERPNextClient client)
            : base(DocType.Bank_guarantee, client) { }

        protected override ERPBank_guarantee fromERPObject(ERPObject obj)
        {
            return new ERPBank_guarantee(obj);
        }
    }
}