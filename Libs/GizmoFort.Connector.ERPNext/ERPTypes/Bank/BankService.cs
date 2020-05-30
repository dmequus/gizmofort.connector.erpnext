using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Bank
{
    public class BankService : SubServiceBase<ERPBank>
    {
        public BankService(ERPNextClient client)
            : base(DocType.Bank, client) { }

        protected override ERPBank fromERPObject(ERPObject obj)
        {
            return new ERPBank(obj);
        }
    }
}