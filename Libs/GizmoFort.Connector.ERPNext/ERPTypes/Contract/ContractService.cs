using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Contract
{
    public class ContractService : SubServiceBase<ERPContract>
    {
        public ContractService(ERPNextClient client)
            : base(DocType.Contract, client) { }

        protected override ERPContract fromERPObject(ERPObject obj)
        {
            return new ERPContract(obj);
        }
    }
}